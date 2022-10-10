using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class AnCo : Animal
    {
        private string taptinhC;

        public AnCo(string name, double avgWeigth, string taptinhC):base(name, avgWeigth)
        {
            TaptinhC = taptinhC;
        }

        public AnCo() {}

        public string TaptinhC
        {
            get => taptinhC;
            set
            {
                taptinhC = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Tap tinh loai an co: " + TaptinhC;
        }
        public override string TiengKeu()
        {
            return "Tieng keu:.........";
        }
    }
}
