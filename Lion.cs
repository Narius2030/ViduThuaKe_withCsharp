using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class Lion : AnThit
    {
        public Lion(string name, string taptinhT, double avgWeigth)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + TiengKeu();
        }
        public override string TiengKeu()
        {
            return "Tieng keu: Graowww, Graowww......";
        }
    }
}