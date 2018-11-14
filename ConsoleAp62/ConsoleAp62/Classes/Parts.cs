using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
