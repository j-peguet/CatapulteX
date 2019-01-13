using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    public class Arm : Parts
    {
        private int velocity;
        public Arm(int hp)
        {
            this.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(this + "!");
            }
        }

        //return un nombre aléatoire
        public int move()
        {
            Random rnd = new Random();
            int minvelocity = 1;
            int maxvelocity = 5;
            velocity = rnd.Next(minvelocity, maxvelocity);
            return velocity;
        }

        //envoie au serveur les nombre de dégat sur la cible 
        public void LaunchSpoon(int boulet, int tense, int velocity)
        {
            Console.WriteLine("attaque avec une puissance de: "+boulet + tense + velocity);
            var url = "https://dev18504.service-now.com/api/20557/catapulte/fire";//?power=" + boulet + "&target=groupe11";
            var client = new WebClient { Credentials = new NetworkCredential("groupe8", "WWTPnLfg") };
            //client.Headers[HttpRequestHeader.ContentType] =  "application/json; charset=utf-8";
            //var method = "POST"; 
            var parameters = new NameValueCollection();
            string param = "power=39&target=groupe11";

            //var response_data =;// (url, method, parameters);
            Console.WriteLine(client.UploadValues(url,"POST",parameters));
            // Parse the returned data (if any) if needed.
            //var responseString = UnicodeEncoding.UTF8.GetString(data);
        }
    }
}
