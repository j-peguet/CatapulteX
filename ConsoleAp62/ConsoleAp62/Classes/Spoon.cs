using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
  public  class Spoon : Parts
    {
        public Spoon(int hp)
        {
            this.HP = hp;
        }

       public struct Rock
        {
            public int masse;
            public bool flame;
        }

        public Rock ChoisirBoulet()
        {
            
            Rock boulet = new Rock();
            // Choix de la masse du boulet 
            Random rnd = new Random();
            int minPoid = 40;
            int maxPoid = 200;
            boulet.masse = rnd.Next(minPoid, maxPoid);
            if (rnd.Next(1, 10) == 3) {

                boulet.flame = true;
            }
            else {
                boulet.flame = false;
            }

            // Calcul du temps de chargement
            double chargement = (boulet.masse * 0.05) * 1000;
            // Cast Explicit
            int pause = (int)chargement;
            // Pause du chargement

            System.Threading.Thread.Sleep(pause);
            return boulet;

        }

        


    }
}
