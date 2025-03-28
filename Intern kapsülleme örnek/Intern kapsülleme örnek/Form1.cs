using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_kapsülleme_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            Kisi birey = new Kisi();

            birey.Ad = txtAd.Text;
            MessageBox.Show("Kişi Adı: " + birey.Ad);
        }
    }
}
