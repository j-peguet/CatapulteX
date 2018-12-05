using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
   
   public class Trigger : Parts
    {
        private bool etat_levier;
        public Trigger(int hp)
        {
            this.HP = hp;
        }

        public void verify()
        {
            if(etat_levier == true)
            {
                Console.WriteLine("FEU !!");
            }
            else
            {
                Console.WriteLine("J'abaisse le levier");
                verify();
            }

        }





    }
}
