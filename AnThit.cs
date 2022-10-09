using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class AnThit : Animal
    {
        private string taptinhT;

        public AnThit(string name, double avgWeigth, string taptinhT):base(name, avgWeigth)
        {
            TaptinhT = taptinhT;
        }

        public AnThit()
        {
        }

        public string TaptinhT
        {
            get => taptinhT;
            set
            {
                taptinhT = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Tap tinh loai an thit: " + TaptinhT;
        }
        public double CaNang()
        {
            return AvgWeigth;
        }
        public override string TiengKeu()
        {
            return "";
        }
    }
}