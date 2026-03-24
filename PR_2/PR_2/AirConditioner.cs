using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2
{
    internal class AirConditioner
    {
        public void ReactToTemperatureChange(double temperature)
        {
            if (temperature < 17)
            {
                Console.WriteLine("Display: увімкнути обігрів");
            }
            else if (temperature < 25)
            {
                Console.WriteLine("Display: вимкнути кондиціонер");
            }
            else
            {
                Console.WriteLine("Display: увімкнути охолодження");
            }
        }
    }
}
