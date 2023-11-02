using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Complying
{
    internal class FlyingBirds : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Making bird sounds.");
        }

        public void Fly()
        {
            Console.WriteLine("Flying in the sky.");
        }
    }
}
