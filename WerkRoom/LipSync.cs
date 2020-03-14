using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class LipSync
    {
        public static void ForYourLife(Queen attacker, Queen defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 31);
            int shade = attacker.CalcShade();
            int clapBack = shade - defender.Charisma;

            if ((diceRoll + shade) >= clapBack && clapBack > 0)
            {
                int damageDealt = clapBack;                
                defender.Nerve -= damageDealt;
                Console.WriteLine("RuPaul: {0} Threw Some Shade at {1} for {2} a hit to {1}'s Nerve\n", attacker.Name, defender.Name, damageDealt);
            }
            else if ((diceRoll + shade) >= clapBack && clapBack < 0)
            {
                Console.WriteLine("Rupaul: {0}'s Shade was no match for {1}'s Charisma!\n",attacker.Name, defender.Name);                
            }
            else
            {
                Console.WriteLine("Rupaul: {0}'s Shade was Weak! {0} is Shook\n", attacker.Name);
            }
        }
        public static void ThrowShade(Queen attacker, Queen defender)
        {
            ForYourLife(attacker, defender);
        }        
    }
}
