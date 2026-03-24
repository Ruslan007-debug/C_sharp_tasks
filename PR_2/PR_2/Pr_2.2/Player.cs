using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Pr_2._2
{
    internal class Player
    {
        private int helth;
        public event Action<int> OnHealthChanged;

        public Player(int initialHealth)
        {
            helth = initialHealth;
        }

        public void GetDamage(int damage)
        {
            helth -= damage;
            Console.WriteLine($"Player received {damage} damage.");
            OnHealthChanged?.Invoke(helth);
        }


    }
}
