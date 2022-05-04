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
        public RozpisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openAButton_Click(object sender, EventArgs e)
        {
            openADialog.ShowDialog();            
            string muzstvo = "tým A";
            string nazevSouboru = openADialog.FileName;
            string rozpisText = File.ReadAllText(nazevSouboru);
        }
    }
}
