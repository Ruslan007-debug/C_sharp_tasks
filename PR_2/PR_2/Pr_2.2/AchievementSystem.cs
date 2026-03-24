using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Pr_2._2
{
    internal class AchievementSystem
    {
        public void CheckAchievement(int health)
        {
            if (health <= 50)
            {
                Console.WriteLine("Achievement: Half Health");
            }
            else if (health <= 0)
            {
                Console.WriteLine("Achievement: First Death");
            }
        }

        public void SubscribeToPlayer(Player player)
        {
            player.OnHealthChanged += CheckAchievement;
        }
    }
}
