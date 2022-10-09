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
            Buffalo b = new Buffalo("Trau", "an co, di cay", 450);
            AnCo ac = new AnCo("Dear", 150, "an co");
            Tiger t = new Tiger("Ho Chau Phi", "An thit, san moi", 500);
            AnThit at = new AnThit("Ho Chau Phi", 500, "An thi, san moi");

            Console.WriteLine(b + "\n");
            Console.WriteLine(ac + "\n");
            Console.WriteLine(t + "\n");
            Console.WriteLine(at);
            Console.ReadLine();
        }
    }
}
