using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubStrings;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kieu Buffalo, gan object Buffalo
            Buffalo b = new Buffalo("Trau", "an co, di cay", 450);
            Console.WriteLine(b.ToString() + "\n");

            //Kieu AnThit, gan object AnThit
            AnThit a = new AnThit("Bao", 450, "an thit, di san");
            Console.WriteLine(a.ToString() + "\n");

            //Kieu AnCo NHUNG gan object Buffalo
            AnCo c = new Buffalo("Bo sua", "an co", 400);
            Console.WriteLine(c.ToString() + "\n");

            //Hiding method TiengKeu()
            AnCo ac = new Dear("Dear", "an co", 200);
            Console.WriteLine("Tieng keu loai an co: " + "\n" + ac.TiengKeu() + "\n");

            Dear d = new Dear("Dear", "an co", 150);
            Console.WriteLine("Tieng keu loai Huou: " + "\n" + d.TiengKeu() + "\n");

            //Overriding method TiengKeu()
            AnThit at = new Tiger("Ho Chau A", "An thit, san moi", 455);
            Console.WriteLine("Tieng keu loai an thit: " + "\n" + at.TiengKeu() + "\n");

            Tiger t = new Tiger("Ho Chau Phi", "An thit, san moi", 500);
            Console.WriteLine("Tieng keu loai Ho: " + "\n" + t.TiengKeu() + "\n");

            Console.ReadLine();
        }
    }
}
