using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAp62.Classes;
using System.Web;
//using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace ConsoleAp62
{
    class Program
    {
        public class Result
        {
            public int life { get; set; }
        }
        static void Main()
        {
            Catapult catapult = new Catapult();

            Console.WriteLine(catapult.getRope().GetPartsHP(catapult.getRope()));
            catapult.getRope().SetPartsHP(catapult.getRope(), 10);
            Console.WriteLine(catapult.getRope().GetPartsHP(catapult.getRope()));

            Console.Write("Fini");
            Console.ReadKey();
        }
    }
}
