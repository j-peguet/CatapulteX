using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    public class Catapult
    {
        private Spoon spoon = new Spoon(0);
        private Rope rope = new Rope(0) ;
        private Beam beam = new Beam(0);
        private Arm arm = new Arm(0);
        private Body body;
        private Trigger trigger = new Trigger(0);

        public Catapult()
        {
            arm = new Arm(getArm().Value("arm"));
            spoon = new Spoon(getSpoon().Value("spoon"));
            beam = new Beam(getBeam().Value("beam"));
            trigger = new Trigger(getTrigger().Value("trigger"));
            rope = new Rope(getRope().Value("rope"));

        }
        public Arm getArm()
        {
            return this.arm;
        }

        public Spoon getSpoon()
        {
            return this.spoon;
        }

        public Beam getBeam()
        {
            return this.beam;
        }

        public Trigger getTrigger()
        {
            return this.trigger;
        }
        public Rope getRope()
        {
            return this.rope;
        }


        public void tir()
        {
            spoon.ChoisirBoulet();
            rope.LowerSpoon();
            trigger.verify();
            arm.move();
        }



    }
}
