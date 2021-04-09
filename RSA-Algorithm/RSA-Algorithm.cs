using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Algorithm
{
    class RSA_Algorithm
    {
        private List<int> asciiList;
        private BigInteger p { get; set; }
        private BigInteger q { get; set; }
        private BigInteger n { get; set; }
        private BigInteger phi { get; set; }
        private BigInteger e { get; set; } 
        private BigInteger d { get; set; }

        private BigInteger[] encryptedText;

        public string Encryption()
        {
            try
            {
                this.e = e;
                string result = string.Empty;
                Console.WriteLine(e + "<- E encrypt");
                foreach (int i in asciiList)
                {
                    result += BigInteger.Pow(i, (int)e) % n + " "; // We convert e int to not take up a lot of memory
                }
                result = result.Substring(0, result.Length - 1);


                SQL sql = new SQL();
                sql.InsertValues(result, e, n);
                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Encryption ex {0}", ex);
                return null;
            }
        }



    }
}
