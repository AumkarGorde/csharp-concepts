using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Complying
{
    public class Penguin : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Penguin is making bird sounds.");
        }
    }
}
