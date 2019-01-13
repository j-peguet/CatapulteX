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

        static void Main()
        {
            //Création de la catapulte principale
            Catapult catapult = new Catapult();

            //Test que l'exception est bien levée
            Catapult catapult_test = new Catapult();
            try
            {
                catapult_test.getRope().SetPartsHP(catapult_test.getRope(), 0);
            }
            catch (BrokenException be)
            {
                Console.WriteLine("Broken Exception " + be.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de la modification");
            }

            //Test tir de la catapulte
            try
            {
                catapult.tir();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin du tir");
            }

            Console.WriteLine("Fini");
            Console.ReadKey();
        }
    }
}
