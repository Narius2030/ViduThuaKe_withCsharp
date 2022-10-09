using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public abstract class Animal
    {
        private string name;
        private double avgWeigth;

        public Animal()
        {
            
        }

        public Animal(string name, double avgWeigth)
        {
            Name = name;
            AvgWeigth = avgWeigth;
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public double AvgWeigth
        {
            get => avgWeigth;
            set
            {
                avgWeigth = value;
            }
        }

        public override string ToString()
        {
            return "Ten: "+ name + "\n" + "Can nag trung binh: " + avgWeigth + "\n";
        }
        public abstract string TiengKeu();
    }
}