using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes

{
   public class Rope : Parts
    {
        // False = Corde PAS Tendu , True = Corde Tendu
        private bool state;
        private int puissance;
        private int min = 100;
        private int max = 200;

        public Rope(int hp)
        {
            this.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(this + "!");
            }

        }

        //Création d'un delegate
        public delegate int Calcul(int x, int y);

        public int LowerSpoon()
        {
            double abaissage = 1000;
            // Cast Explicit
            int pause = (int)abaissage;
            // Pause abaissage
            System.Threading.Thread.Sleep(pause);
            //Cast Implicit
            double min2 = min;
            double max2 = max;
            //Utilisation d'un anonyme
            TendTheRope(delegate(int x, int y) { return min - max; },100,500);
            return this.puissance;
        }

        //Utilisation du délégate dans un paramètre de la fonction
        private void TendTheRope(Calcul Cal,int min, int max)
        {
            Random rnd = new Random();
            int nbr = Cal(min,max);
            this.puissance = rnd.Next(nbr, max);
        }
    }
}
