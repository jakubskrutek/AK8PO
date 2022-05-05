using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK8PO
{
    public partial class MainForm : Form
    {
        private SpravceRozpisu spravceRozpisu = new SpravceRozpisu();

        public MainForm()
        {
            InitializeComponent();

            // tady přidám fajfku na formulář po úspěšném nahrání souboru
        }

        private void uspesnostiButton_Click(object sender, EventArgs e)
        {

        }

        private void pridatRozpisButton_Click(object sender, EventArgs e)
        {
            RozpisForm rozpisForm = new RozpisForm(spravceRozpisu);
            rozpisForm.ShowDialog();
        }
    }
}
