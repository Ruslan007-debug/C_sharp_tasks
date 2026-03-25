using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_1.Task_1.Operations
{
    public static class CountChars
    {
        public static string CountCharsFunc(string text)
        {
            int count = 0;

            if (text == null)
            {
                count = 0;
            }
            else
            {
                foreach (var c in text)
                {
                    count++;
                }
            }

            return "Characters: " + count;

        }   
        
    }
}
