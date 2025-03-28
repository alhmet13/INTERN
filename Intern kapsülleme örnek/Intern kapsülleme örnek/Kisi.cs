using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_kapsülleme_örnek
{
    public class Kisi
    {
        private string ad;
        public string Ad
        {
            get { return ad; }
            set { if (!string.IsNullOrWhiteSpace(value)) ad = value; }


        }
    }
}
