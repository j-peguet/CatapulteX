using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    public class Catapult
    {
        private Spoon spoon;
        private Rope rope;
        private Beam beam;
        private Arm arm;
        private Body body;
        private Trigger trigger;

        public Catapult(int Arm_HP, int Spoon_HP)
        {
            arm = new Arm(Arm_HP);
            spoon = new Spoon(Spoon_HP);

        }
        public Arm getArm()
        {
            return this.arm;
        }

    }
}
