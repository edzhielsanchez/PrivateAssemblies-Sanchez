using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Addition(float opperand1, float opperand2)
        {
            return opperand2 + opperand1;
        }

        public static float Subtraction(float opperand1, float opperand2)
        {
            return opperand2 - opperand1;
        }

        public static float Multiplication(float opperand1, float opperand2)
        {
            return opperand2 * opperand1;
        }

        public static float Divition(float opperand1, float opperand2)
        {
            return opperand2 / opperand1;
        }
    }
}
