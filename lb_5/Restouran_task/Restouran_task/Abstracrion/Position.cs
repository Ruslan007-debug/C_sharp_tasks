using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Abstracrion
{
    public abstract class Position
    {
        public int Cost { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Position(int cost, int weight, string name)
        {
            this.Cost = cost;
            this.Weight = weight;
            this.Name = name;
        }
    }
}
