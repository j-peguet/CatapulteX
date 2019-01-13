using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    public class Spoon : Parts
    {

        public int puissance;

        public Spoon(int hp)
        {
            this.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(this + "!");
            }
        }

         public struct Rock
        {
            public int masse;
            public bool flame;
        }  


        public int ChoisirBoulet()
        {

            puissance = 0;
            Rock boulet = new Rock();
            // Choix de la masse du boulet 

            Random rnd = new Random();
            int minPoid = 40;
            int maxPoid = 200;

            boulet.masse = rnd.Next(minPoid, maxPoid);
           
            if (rnd.Next(1, 10) == 3) {

                  boulet.flame = true;
                  puissance = 500;

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

            // Definition Puissance du Spoon

            return puissance = puissance + boulet.masse;      

        }  

    }
}
