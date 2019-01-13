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
        //Chaque partie de la catapulte est initialidé à la création
        private Spoon spoon = new Spoon(1);
        private Rope rope = new Rope(1);
        private Beam beam = new Beam(1);
        private Arm arm = new Arm(1);
        private Body body;
        private Trigger trigger = new Trigger(1);

        public Catapult()
        {
            try
            {
                Console.WriteLine("Fabrication de la catapulte");
                arm = new Arm(getArm().GetPartsHP("arm"));
                Console.WriteLine("Arm pret !");
                spoon = new Spoon(getSpoon().GetPartsHP("spoon"));
                Console.WriteLine("Spoon pret !");
                beam = new Beam(getBeam().GetPartsHP("beam"));
                Console.WriteLine("Beam pret !");
                trigger = new Trigger(getTrigger().GetPartsHP("trigger"));
                Console.WriteLine("Trigger pret !");
                rope = new Rope(getRope().GetPartsHP("rope"));
                Console.WriteLine("Rope pret !");
            }
            catch (BrokenException be)
            {
                Console.WriteLine("Broken Exception " + be.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Catapulte construite ! A l'ATTAQUE !!");
            }

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

        //Tir de la catapulte
        public void tir()
        {
            if (trigger.verify() == true)
            {
                int boulet = spoon.ChoisirBoulet();
                int tense = rope.LowerSpoon();
                int velocity  = arm.move();
                arm.LaunchSpoon(boulet, tense, velocity);
                Console.WriteLine("FEU !!");
            }
            else
            {
                trigger.verify();
                Console.WriteLine("J'abaisse le levier");
            }
        }
    }
}
