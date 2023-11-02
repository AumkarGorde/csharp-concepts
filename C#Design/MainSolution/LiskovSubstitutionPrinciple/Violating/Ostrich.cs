using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Violating
{
    public class Ostrich : Bird
    {
        // Ostriches cannot fly, but they inherit the Fly method.
    }
}
