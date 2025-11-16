using Restouran_task.Abstracrion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Models
{
    public class Food: Position
    {
        public string Country { get; set; }
        public string Type { get; set; }
        public int Calories { get; set; }

        public Food(int cost, int weight, string name, string country, string type, int calories): base(cost, weight, name)
        {
            this.Country = country;
            this.Type = type;
            this.Calories = calories;
        }
    }
}
