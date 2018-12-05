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
    public abstract class Parts
    {
        protected int HP;


        public int GetPartsHP(Parts P)
        {
            return P.HP;
        }

        public void SetPartsHP(Parts P, int hp)
        {
            P.HP = hp;
        }
        public int Value(string P)
        {
            var client = new WebClient { Credentials = new NetworkCredential("groupe8", "WWTPnLfg") };
            var value = client.DownloadString("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target="+P);
            dynamic Json = JsonConvert.DeserializeObject(value);
            int PV = Json.result.life;
            return PV;
        }
    }
}
