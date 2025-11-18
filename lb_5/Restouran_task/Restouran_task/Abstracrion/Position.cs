using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Abstracrion
{
    public abstract class Position
    {
        private int cost;
        public int Cost
        {
            get => cost;
            set => cost = value == 0 ? 100 : value;
        }

        private int weight;
        public int Weight
        {
            get => weight;
            set => weight = value == 0 ? 100 : value;
        }
        public string Name { get; set; }

        public Position(int cost, int weight, string name)
        {
            this.Cost = cost;
            this.Weight = weight;
            this.Name = name;
        }
    }
}
