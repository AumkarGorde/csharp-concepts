using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Complying
{
    public class Ostrich : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ostrich is making bird sounds.");
        }
    }

}
