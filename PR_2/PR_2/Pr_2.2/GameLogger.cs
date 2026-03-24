using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Pr_2._2
{
    internal class GameLogger
    {
        public void LogHealthAndDamage(int health)
        {
            Console.WriteLine($"[GameLogger] Player's current health: {health}");
        }

        public void SubscribeToPlayer(Player player)
        {
            player.OnHealthChanged += LogHealthAndDamage;
        }
    }
}
