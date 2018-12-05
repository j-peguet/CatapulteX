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
        static void Main(string[] args)
        {
            Catapult catapult = new Catapult(20,25,15,17,56);
            catapult.getArm().SetPartsHP(catapult.getArm(), 10);
            Console.WriteLine(catapult.getArm().GetPartsHP(catapult.getArm()));

            Result json = Newtonsoft.Json.JsonConvert.DeserializeObject<Result>(catapult.Value());
            var Text = JsonConvert.DeserializeObject(catapult.Value());

            //JsonTextReader reader = new JsonTextReader(catapult.Value());

            Console.WriteLine(Text);
            //var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            //Newtonsoft.Json.JsonConvert.SerializeObject(catapult.Value())
            Console.WriteLine(catapult.Value());
            Console.Write("Fini");
            Console.ReadKey();
        }
    }
}
