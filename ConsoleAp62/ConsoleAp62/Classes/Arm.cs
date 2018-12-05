using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    public class Arm : Parts
    {
        private int velocity;
        public Arm(int hp)
        {
            this.HP = hp;
        }

        public void move()
        {
            Random rnd = new Random();
            int minvelocity = 1;
            int maxvelocity = 5;
            velocity = rnd.Next(minvelocity, maxvelocity);
        }

        public void LaunchSpoon()
        {

        }
    }
}
