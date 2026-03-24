using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2
{
    internal class SecuritySystem
    {
        public void CheckTemparature(double temparature)
        {
            if (temparature < 5)
            {
                Console.WriteLine("Security System: Warning! Extremely low temperature detected!");
            }
            else if (temparature > 40)
            {
                Console.WriteLine("Security System: Warning! Extremely high temperature detected!");
            }
        }
    }
}
