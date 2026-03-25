using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_1.Task_2.Publisher
{
    public class MessagePublisher
    {
        public event Action<string> MessageSent;

        public void Send(string message)
        {
            if (MessageSent != null)
            {
                MessageSent(message);
            }
        }
    }
}
