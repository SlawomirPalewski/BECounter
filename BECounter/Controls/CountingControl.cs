using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Diagnostics;

namespace BECounterNew.Controls
{
    public partial class CountingControl : UserControl
    {
        private List<ChampionData> _championData;
        private Save _save;
        private string _executePath;

        public CountingControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                _executePath = "C:/Users/Dorokai/Source/repos/BECounter/BECounterNew/bin/Debug/";
            else
                _executePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);


            LoadTemplate();

            championViewControl.CountingLabelReload += new EventHandler<EventArgs>(CountingLabelReload);
            CreateOrLoadSave();

        }

        /// <summary>
        /// Create new save if "Load previous save" is not checked.
        /// If it is checked, load recent one.
        /// After that, send save to Champion View.
        /// </summary>
        private void CreateOrLoadSave()
        {
            Boolean loadPreviousSave = Convert.ToBoolean(Properties.Settings.Default["loadRecently"]);

            if (loadPreviousSave)
                LoadChampions();
            else
            {
                _save = new Save();

                List<SavedChampion> listSavedChampion = new List<SavedChampion>();

                foreach (ChampionData cd in _championData)
                {
                    listSavedChampion.Add(new SavedChampion() { name = cd.name, quantity = 0 });
                }

                _save.currentBE = 0;
                _save.champion = listSavedChampion;
            }
            championViewControl.LoadChampionSave(_save);
        }

        /// <summary>
        /// Loads template and sends it to Champion View.
        /// </summary>
        private void LoadTemplate()
        {

            using (StreamReader r = new StreamReader(_executePath+"/Data/Template.json"))
            {
                string json = r.ReadToEnd();
                _championData = JsonConvert.DeserializeObject<List<ChampionData>>(json);
            }
            championViewControl.AddPictureBoxes(_championData);

            numericUpDown.Value = 0;
        }

        #region Buttons

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Boolean alertLoad = Convert.ToBoolean(Properties.Settings.Default["alertLoad"]);

            DialogResult dialogResult = DialogResult.No;

            if (alertLoad)
            {
                DialogWindow dw = new DialogWindow("Load confirm", "Load last save?");
                dw.ShowDialog();
                dialogResult = dw.DialogResult;
            }

            if (dialogResult == DialogResult.Yes || !alertLoad)
            {
                LoadChampions();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Boolean alertSave = Convert.ToBoolean(Properties.Settings.Default["alertSave"]);

            DialogResult dialogResult = DialogResult.No;

            if (alertSave)
            {
                DialogWindow dw = new DialogWindow("Save confirm", "Save values?");
                dw.ShowDialog();
                dialogResult = dw.DialogResult;
            }

            if (dialogResult == DialogResult.Yes || !alertSave)
            {
                SaveChampions();
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Boolean alertReset = Convert.ToBoolean(Properties.Settings.Default["alertReset"]);

            DialogResult dialogResult = DialogResult.No;

            if (alertReset)
            {
                DialogWindow dw = new DialogWindow("Reset confirm", "Reset values to 0?");
                dw.ShowDialog();
                dialogResult = dw.DialogResult;
            }

            if (dialogResult == DialogResult.Yes || !alertReset)
            {
                ResetChampions();
            }
        }

        #endregion

        #region Champion Operations

        private void ResetChampions()
        {
            if(_save != null)
            {
                foreach (SavedChampion champion in _save.champion)
                {
                    champion.quantity = 0;
                }

                championViewControl.LoadChampionSave(_save);
            }

            numericUpDown.Value = 0;
            SetCountingLabels();
        }

        private void SaveChampions()
        {
            
            _save.currentBE = Convert.ToInt32(numericUpDown.Value);
            string jsonSave = JsonConvert.SerializeObject(_save);
            string fileName = _executePath + "/Data/Save.json";

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(jsonSave);
            }
            
        }

        private void LoadChampions()
        {
            
            using (StreamReader r = new StreamReader(_executePath + "/Data/Save.json"))
            {
                string json = r.ReadToEnd();
                _save = JsonConvert.DeserializeObject<Save>(json);
            }
            championViewControl.LoadChampionSave(_save);
            numericUpDown.Value = _save.currentBE;

            SetCountingLabels();
            
        }

        #endregion

        /// <summary>
        /// Update counting labels.
        /// </summary>
        private void SetCountingLabels()
        {
            int l90 = 0, l270 = 0, l630 = 0, l960 = 0, l1260 = 0, l1560 = 0;
            int total = 0;

            if(_save != null)
            {
                foreach (ChampionData champion in _championData)
                {
                    SavedChampion champ = _save.champion.FirstOrDefault(x => x.name.Equals(champion.name));
                    switch (champion.price)
                    {
                        case 450:
                            l90 += champ.quantity;
                            total = total + 90 * champ.quantity;
                            break;
                        case 1350:
                            l270 += champ.quantity;
                            total = total + 270 * champ.quantity;
                            break;
                        case 3150:
                            l630 += champ.quantity;
                            total = total + 630 * champ.quantity;
                            break;
                        case 4800:
                            l960 += champ.quantity;
                            total = total + 960 * champ.quantity;
                            break;
                        case 6300:
                            l1260 += champ.quantity;
                            total = total + 1260 * champ.quantity;
                            break;
                        case 7800:
                            l1560 += champ.quantity;
                            total = total + 1560 * champ.quantity;
                            break;
                    }
                }
            }


            label90.Text = l90 + " x 90";
            label270.Text = l270 + " x 270";
            label630.Text = l630 + " x 630";
            label960.Text = l960 + " x 960";
            label1260.Text = l1260 + " x 1260";
            label1560.Text = l1560 + " x 1560";

            total = total + Convert.ToInt32(numericUpDown.Value);

            labelScore.Text = total + " BE";
        }

        /// <summary>
        /// Event for firing updates of labels when other control changes data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountingLabelReload(object sender, EventArgs e)
        {
            SetCountingLabels();
        }

    }
}
