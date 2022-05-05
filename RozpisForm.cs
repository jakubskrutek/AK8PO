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
            string muzstvo = "tým A";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.Nahraj(muzstvo, rozpisText);
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
            string muzstvo = "tým B";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.Nahraj(muzstvo, rozpisText);
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
            string muzstvo = "tým C";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);

            try {
                spravceRozpisu.Nahraj(muzstvo, rozpisText);
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
    }
}
