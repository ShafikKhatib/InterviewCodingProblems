using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodingProblems
{
    public class PrimeNumber
    {
        // Check if a number is prime
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Generate a list of prime numbers up to a given limit
        public List<int> GeneratePrimesUpTo(int limit)
        {
            List<int> primes = new List<int>();
            for (int num = 2; num <= limit; num++)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
            }
            return primes;
        }
    }
}
