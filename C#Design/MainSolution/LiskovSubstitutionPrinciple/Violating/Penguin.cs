using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Violating
{
    public class Penguin : Bird
    {
        // Penguins also cannot fly but inherit the Fly method.
    }
}
