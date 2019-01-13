using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp62.Classes
{
    //Class Permetant de lever des exceptions quand les parties ont 0 HP
    class BrokenException : Exception
    {
        public BrokenException(string element) : base ("L'Element suivant n'a plus de point de vie: " + element)
        {

        }
    }
}
