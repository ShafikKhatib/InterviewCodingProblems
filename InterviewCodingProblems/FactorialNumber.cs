using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class FactorialNumber
    {
        public FactorialNumber() { }
        public long FactorialRecursive(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Number cant be negative");

            if (number == 0 || number == 1)
                return 1;

            return number * FactorialRecursive(number - 1);


        }

        //Calculate 3rd highest salary from Employee table  
        public long FactorialIterative(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Number cant be negative");
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
