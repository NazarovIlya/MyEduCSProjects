using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCS0002_Variables
{
    internal class Program
    {
        /// <summary>
        /// Work whit variables
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // integer types
            int intVar;
            intVar = 0;

            long longVar;
            longVar = 99999999;

            /// floating point variable
            
            float floatVar;
            floatVar = 3.4f; // suffix F is necessery

            // better
            float floatVarSecond = 3.4f; // suffix F is necessery

            // however, it is possible through casting to the type
            float floatVarThird = (float)3.4f; // the suffix is not needed

            double doubleVar;
            doubleVar = 0.00000001;

            double doubleVarBetter = 0.00000001;

            decimal decimalVar;
            decimalVar = 45.00000000000056m; // suffix M is necessery

            // better
            
            decimal decimalVarSecond = 45.00000000000056m; // suffix M is necessery

            // however, it is possible through casting to the type
            decimal decimalVarSecond = (decimal)45.00000000000056; // the suffix is not needed 


            Console.ReadKey();
        }
    }
}
