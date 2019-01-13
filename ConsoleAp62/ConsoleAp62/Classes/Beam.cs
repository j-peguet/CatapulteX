using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
 public  class Beam : Parts
    {
        public Beam(int hp)
        {
            this.HP = hp;
            if (hp <= 0)
            {
                throw new BrokenException(this + "!");
            }
        }

        public int Launch()
        {

            return 0;
        }
    }
}
