using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_soyutlama_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSesCikar_Click(object sender, EventArgs e)
        {
            hayvan kedi1 = new kedi();
            hayvan insan1 = new insan();
            

            MessageBox.Show(Convert.ToString(kedi1.sescikar()));
        }
    }
}
