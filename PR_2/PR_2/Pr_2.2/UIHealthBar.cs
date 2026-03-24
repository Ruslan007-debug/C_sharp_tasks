using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Pr_2._2
{
    internal class UIHealthBar
    {
        public void ShowCurrentHP(int health)
        {
            Console.WriteLine($"Health Bar: Current HP = {health}");
        }

        public void SubscribeToPlayer(Player player)
        {
            player.OnHealthChanged += ShowCurrentHP;
        }
    }
}
