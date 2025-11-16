using Restouran_task.Abstracrion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Models
{
    public class Drink: Position
    {
        public bool Alcohol { get; set; }
        public string Taste { get; set; }
        public string Temparature { get; set; }

        public Drink(bool alco, string taste, string temp, string name, int weight, int cost): base(cost, weight, name)
        {
            this.Alcohol = alco;
            this.Taste = taste;
            this.Temparature = temp;
        }
    }
}
