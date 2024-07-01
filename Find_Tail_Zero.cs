using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_csharp
{
    public class Find_Tail_Zero
    {
        public int Number { get; set; }
        public Find_Tail_Zero(int number)
        {
            Number = number;
        }

        public string FindTailZero()
        {
            if (Number < 0) { return "Number not less 1"; }
            int count = 0;
            int power = 5;
            while (Number / power >= 1)
            {
                count += Number / power;
                power *= 5;
            }
            return count.ToString();
        }
        public string factorial()
        {
            if (Number < 0) { return "Number not less 1"; }
            long result = 1;
            for (int i = 1; i <= Number; i++)
            {
                result *= i;
                Console.WriteLine("Step " + i + ": " + result);

            }
            return result.ToString();

        }
    }
}
