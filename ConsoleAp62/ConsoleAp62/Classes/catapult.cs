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
        private Spoon spoon;
        private Rope rope;
        private Beam beam;
        private Arm arm;
        private Body body;
        private Trigger trigger;

        public Catapult(int Arm_HP, int Spoon_HP,int Beam_HP, int Trigger_HP, int Rope_HP )
        {
            arm = new Arm(Arm_HP);
            spoon = new Spoon(Spoon_HP);
            beam = new Beam(Beam_HP);
            trigger = new Trigger(Trigger_HP);
            rope = new Rope(Rope_HP);

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

        public string Value()
        {
            var client = new WebClient { Credentials = new NetworkCredential("groupe8", "WWTPnLfg") };
            var value = client.DownloadString("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=beam");
            return value;
        }



    }
}
