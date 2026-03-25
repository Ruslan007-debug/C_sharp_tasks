using Modular_1.Task_2.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_1.Task_2.Logger
{
    public class FileLogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void Subscribe(MessagePublisher publisher)
        {
            publisher.MessageSent += WriteToFile;
        }

        private void WriteToFile(string message)
        {
            string log = $"[{DateTime.Now}] {message}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(log);
            }
        }
    }
}
