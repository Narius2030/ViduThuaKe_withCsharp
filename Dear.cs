using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class Dear : AnCo
    {
        public Dear(string name, string taptinhC, double avgWeigth) : base(name, avgWeigth, taptinhC)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\n" + TiengKeu();
        }
        public new string TiengKeu()
        {
            return "Tieng keu: beeee beeee....";
        }
    }
}
