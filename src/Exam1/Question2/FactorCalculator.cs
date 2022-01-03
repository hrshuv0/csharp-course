using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class FactorCalculator
    {
        public static int[] FindFactors(int number)
        {
            bool[] isPrime = new bool[35000]; // false = prime
            isPrime[1] = true;
            for (int i = 2; i < 35000; i++)
            {
                if (isPrime[i] == false)
                {
                    for (int j = i * i; j < 35000; j += i)
                    {
                        isPrime[j] = true;
                    }
                }
            }
            
            int[] factors = new int[350000];
            int k = 0;

            for (int i = 1; i <= number; i++)
            {
                if (isPrime[i] == false && number % i == 0)
                {
                    factors[k++] = i;
                }
            }

            int[] Factors = new int[k];

            for (int i = 0; i < k; i++)
            {
                Factors[i] = factors[i];
            }

            return Factors;
        }
    }
}
