using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_3
{
    internal class Task_1
    {
        int lineCount = 0;
        int wordCount = 0;
        int charCount = 0;

        public void WriteInFileTask1()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\Acer\\source\\repos\\C#_PRs\\PR_3\\PR_3\\story.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Acer\\source\\repos\\C#_PRs\\PR_3\\PR_3\\report.txt"))
            {
                writer.WriteLine("Статистика тексту:");
                writer.WriteLine("Кількість рядків: " + lineCount);
                writer.WriteLine("Кількість слів: " + wordCount);
                writer.WriteLine("Кількість символів: " + charCount);

            }
            Console.WriteLine("End");
        }

    }
}
