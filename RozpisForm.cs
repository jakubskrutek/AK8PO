using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK8PO
{
    public partial class RozpisForm : Form
    {
        private SpravceRozpisu spravceRozpisu;

        public RozpisForm(SpravceRozpisu spravceRozpisu)
        {
            InitializeComponent();

            this.spravceRozpisu = spravceRozpisu;
            rozpisListBox.DataSource = spravceRozpisu.Teamy;
        }

        private void openAButton_Click(object sender, EventArgs e)
        {
            openADialog.ShowDialog();            
            string muzstvo = "teamA";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.NahrajRozpis(muzstvo, rozpisText);
                checkAPictureBox.Visible = true;
                muzstvoACheckBox.Checked = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openBButton_Click(object sender, EventArgs e)
        {
            openADialog.ShowDialog();
            string muzstvo = "teamB";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.NahrajRozpis(muzstvo, rozpisText);
                checkBPictureBox.Visible = true;
                muzstvoBCheckBox.Checked = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openCButton_Click(object sender, EventArgs e)
        {
            openADialog.ShowDialog();
            string muzstvo = "teamC";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.NahrajRozpis(muzstvo, rozpisText);
                checkCPictureBox.Visible = true;
                muzstvoCCheckBox.Checked = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rozpisZpetButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void RozpisForm_Load(object sender, EventArgs e)
        {

        }

        private void generujRozpisButton_Click(object sender, EventArgs e)
        {
            string team = "";
            if (muzstvoACheckBox.Checked)
                team = "teamA";
            else if (muzstvoBCheckBox.Checked)
                team = "teamB";
            else if (muzstvoCCheckBox.Checked)
                team = "teamC";
            Rozpis vracenyRozpis = spravceRozpisu.GenerujRozpis(team);

            generujSaveFileDialog.Filter = "csv file (*.csv)|*.csv| txt files (*.txt)|*.txt| All Files (*.*)|*.*";
            generujSaveFileDialog.FilterIndex = 1;
            generujSaveFileDialog.RestoreDirectory = true;

            if (generujSaveFileDialog.ShowDialog() == DialogResult.OK) {
                System.IO.StreamWriter file = new System.IO.StreamWriter(generujSaveFileDialog.FileName.ToString());
                for (int i = 0; i < vracenyRozpis.RozpisText.GetLength(0); i++) {
                     string obsah = "";
                     for (int j = 0; j < vracenyRozpis.RozpisText.GetLength(1); j++) {
                         if (j == 0)
                             obsah = vracenyRozpis.RozpisText[i, j].ToString();
                         else
                             obsah += ";" + vracenyRozpis.RozpisText[i, j].ToString();
                     }
                     file.WriteLine(obsah);
                 }
                file.Close();
            }
        }
    }
}
