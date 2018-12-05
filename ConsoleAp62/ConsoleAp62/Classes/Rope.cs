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


        public Rope(int hp)
        {
            this.HP = hp;
            
        }

        public void LowerSpoon()
        {
            double abaissage = 1000;
            // Cast Explicit
            int pause = (int)abaissage;
            // Pause abaissage
            System.Threading.Thread.Sleep(pause);
            TendTheRope();
        }

        private void TendTheRope()
        {
            Random rnd = new Random();
            int minPuiss = 100;
            int maxPuiss = 500;
            this.puissance = rnd.Next(minPuiss, maxPuiss);
        }






    }
}
