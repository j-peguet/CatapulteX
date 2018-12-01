using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAp62.Classes;

namespace ConsoleAp62
{
    class Program
    {
        static void Main(string[] args)
        {
            Catapult catapult = new Catapult(20, 25,30,40,30);
            catapult.getArm().SetPartsHP(catapult.getArm(), 10);
            Console.WriteLine(catapult.getArm().GetPartsHP(catapult.getArm()));
           

            Console.ReadKey();
        }
    }
}
