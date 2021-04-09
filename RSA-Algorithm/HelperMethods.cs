using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Algorithm
{
    class HelperMethods
    {
        // Checks if number is prime
        static public bool checkPrime(BigInteger n)
        {
            if (n <= 3 && n > 1)
            {
                return true;
            }
            else if (n == 1 || n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            else
            {
                for (BigInteger i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
