using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrrad F1 = new Fahrrad(29);
            Console.WriteLine(F1.Fahren());



            Console.WriteLine();
            Console.WriteLine("--------------Erad------------");
            Console.WriteLine();




            ERad ER1 = new ERad(35,59.99);
            Console.WriteLine(ER1.Fahren());


            ERad ER2 = new ERad(35, 0);
            Console.WriteLine(ER2.Fahren());


            Console.ReadLine();
        }
    }
}
