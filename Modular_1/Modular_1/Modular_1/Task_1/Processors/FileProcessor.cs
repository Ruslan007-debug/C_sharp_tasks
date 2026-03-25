using Modular_1.Task_1.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_1.Task_1.Processors
{
    public class FileProcessor
    {
        public static void Process(string inputFile, string outputFile, TextOperation operation)
        {
            using (var reader = new StreamReader(inputFile))
            using (var writer = new StreamWriter(outputFile,true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string result = operation(line);
                    writer.WriteLine(result);
                }
                writer.WriteLine("---------");
            }


        }
    }
}
