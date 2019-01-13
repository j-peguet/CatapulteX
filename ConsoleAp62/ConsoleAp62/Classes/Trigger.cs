using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
   
   public class Trigger : Parts
    {
        private bool etat_levier = true;
        public Trigger(int hp)
        {
            this.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(this + "!");
            }
        }

        public Boolean verify()
        {
            if(etat_levier == true)
            {
                etat_levier = false;
                return true;
            }
            else
            {
                etat_levier = true;
                return false;
            }

        }

    }
}
