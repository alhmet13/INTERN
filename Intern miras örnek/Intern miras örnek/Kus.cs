using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_miras_örnek
{
    public class Kus
    {
        public int ayaksayisi { get; set; }
        public int kanatsayisi { get; set; }

        public virtual string ses()
        {
            return "cik cik";
        }
    }
}
