using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class Tiger : AnThit
    {
        public Tiger(string name, string taptinhT, double avgWeigth):base(name, avgWeigth, taptinhT)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\n" + TiengKeu();
        }
        public override string TiengKeu()
        {
            return "Tieng keu: Gruuuw, Gruu......";
        }
    }
}