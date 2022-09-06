using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCS0006_ArethmitecOperators
{
    internal class Expression
    {
        public double First { get; set; }
        public double Second { get; set; }

        public Expression()
        {
        }
        public double Plus()
        {
            return First + Second;
        }
        public double Minus()
        {
            return First - Second;
        }
    }
}
