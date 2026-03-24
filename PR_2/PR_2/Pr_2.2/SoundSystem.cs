using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2.Pr_2._2
{
    internal class SoundSystem
    {
        public void DamageSound(int health)
        {
            if (health <= 20)
            {
                Console.WriteLine("Critical damage sound");
            }
            else
            {
                Console.WriteLine("Normal damage sound");
            }
        }

        public void SubscribeToPlayer(Player player)
        {
            player.OnHealthChanged += DamageSound;
        }
    }
}
