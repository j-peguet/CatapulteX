using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace ConsoleAp62.Classes
{
    //Classe principale des parties de la catapulte
    public abstract class Parts
    {
        //Chaque partie contient des HP
        protected int HP;

        //GET et SET des HP d'une partie
        public int GetPartsHP(Parts P)
        {
            return P.HP;
        }

        public void SetPartsHP(Parts P, int hp)
        {
            P.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(P + "!");
            }
        }

        //Polymorphisme sur la fonction GetPartsHP
        public int GetPartsHP(string P)
        {
            var client = new WebClient { Credentials = new NetworkCredential("groupe8", "WWTPnLfg") };
            var value = client.DownloadString("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target="+P);
            dynamic Json = JsonConvert.DeserializeObject(value);
            int PV = Json.result.life;
            return PV;
        }
    }
}
