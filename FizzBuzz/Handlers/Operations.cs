using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Handlers
{
    public class Operations
    {
        public bool is_prime(int n)
        {
            double sqrRoot = Math.Sqrt(n);
            int sqrRootConverted = (int)Math.Ceiling(sqrRoot);

            for (int i = 2; i < sqrRootConverted; i++)
            {
                //Check if prime
                if ((i % 2) == 0){
                return false;
                }
            }
            return true;
        }
    }
    
}
