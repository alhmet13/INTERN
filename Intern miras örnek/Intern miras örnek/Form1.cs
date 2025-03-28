using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_miras_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikarilacakSes_Click(object sender, EventArgs e)
        {
            Kus ppg = new papağan();
            ppg.ayaksayisi = int.Parse(txtAyakSayisi.Text);
            ppg.kanatsayisi = int.Parse(txtKanatSayisi.Text);

            MessageBox.Show(ppg.ses());
            MessageBox.Show(Convert.ToString(ppg.ayaksayisi));
            MessageBox.Show(Convert.ToString(ppg.kanatsayisi));
        }
    }
}
