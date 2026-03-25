using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_1.Task_1.Operations
{
    public static class CountWords
    {
        public static string CountWordsFunc(string text)
        {
            int count = 0;
            if (text == null)
            {
                count = 0;
            }
            else
            {
                string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                count = words.Length;
            }
            return "Words: " + count;
        }
    }
}
