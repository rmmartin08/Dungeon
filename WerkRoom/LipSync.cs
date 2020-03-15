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
        
        public static void RandomRules(Booger player, Heather opponent, Song song)
        {
            int rand = new Random().Next(0, 101);
            switch (opponent.Name)
            {
                
                case "Alaska":
                case "Roxxy Andrews":
                case "Detox":
                    if (opponent.Name == "Roxxy Andrews" && song.Name == "Whip My Hair")
                    {
                        Console.WriteLine("Roxy Andrews Just Pulled Off A Wig to Reveal Another Wig Underneath!!\nHer Talent is increased.");
                        opponent.Talent += 20;
                    }
                    if (rand >80)
                    {
                        Console.WriteLine("\nBattling his queen invoked \"RoLaskaTox\"!\nRoxxy, Alaska, and Detox Merge into One MEGAQUEEN...\nYou are Petrified, but Ru Throws " +
                            "you a Golden Wig that Boosts Your Nerve");
                        opponent.Name = "RoLaskaTox";
                        opponent.Charisma *= 3;
                        opponent.Uniqueness *= 3;
                        opponent.Nerve *= 3;
                        opponent.Talent *= 3;

                        opponent.Nerve *= 5;
                    }
                    break;

                case "Willam":

                    if ( rand > 90)
                    {
                        Console.WriteLine("Ru: Willam... will you please step forward...\nIt has come to my attention that you have broken the rules.");
                        Console.WriteLine("Rules that are in place to protect The fairness of this competition ");
                        Console.WriteLine("Your actions have consequences. Willam I have to ask you to leave the competition immediately");
                        opponent.Nerve = 0;
                    }
                    break;
                case "DiDa Ritz":
                    if (song.Name == "This Will Be (An Everlasting Love)")
                    {
                        Console.WriteLine("DiDa Ritz is Performing the Most EXPLOSIVE Lip Sync Anyone Has Seen.\nYou Lose All but 1 of Your Nerve\nIt Would Take a Miracle For" +
                            " You to Win This One...\n");
                        player.Nerve = 1;
                    }
                    break;
                default:
                    break;
            }
            
        }

        public static void Loot(Booger player, Heather opponent,Random random)
        {
            byte rand = (byte)random.Next(0, 15);
            string droppedItem="";
            string boostedQuality="";
            byte increasedByNumber=0;
            switch (rand)
            {
                case 0:
                    droppedItem = "CoCo's Dorito Clutch";
                    boostedQuality = "Charisma";
                    increasedByNumber = 10;
                    player.Charisma += increasedByNumber;
                    break;
                case 1:
                    droppedItem = "Roxxy's Discarded Wig";
                    boostedQuality = "Talent";
                    increasedByNumber = 13;
                    player.Talent += increasedByNumber;
                    break;
                case 2:
                    droppedItem = "Violet Chachki's 2-in-1 Outfit";
                    boostedQuality = "Nerve";
                    increasedByNumber = 70;
                    player.Nerve += increasedByNumber;
                    break;
                case 3:
                    droppedItem = "Robbie Turner's Roller Skates";
                    boostedQuality = "Talent";
                    increasedByNumber = 10;
                    player.Talent += increasedByNumber;
                    break;
                case 4:
                    droppedItem = "Valentina's Mask";
                    boostedQuality = "Nerve";
                    increasedByNumber = 100;
                    player.Nerve += increasedByNumber;
                    break;
                case 5:
                    droppedItem = "Shasha Velour's Rose Petals";
                    boostedQuality = "Nerve";
                    increasedByNumber = 150;
                    player.Nerve += increasedByNumber;
                    break;
                case 6:
                    droppedItem = "Sharon Needles' Apocalyptic Drag Look";
                    boostedQuality = "Charisma";
                    increasedByNumber = 13;
                    player.Charisma += increasedByNumber;
                    break;
                case 7:
                    droppedItem = "Lil' Pound Cake";
                    boostedQuality = "Nerve";
                    increasedByNumber = 200;
                    player.Nerve += increasedByNumber;
                    break;
                case 8:
                    droppedItem = "Ornacia";
                    boostedQuality = "Talent";
                    increasedByNumber = 14;
                    player.Talent += increasedByNumber;
                    break;
                case 9:
                    droppedItem = "That Something On Pearl's Face";
                    boostedQuality = "Charisma";
                    increasedByNumber = 10;
                    player.Charisma += increasedByNumber;
                    break;
                case 10:
                    droppedItem = "One of Bob the Drag Queen's Purses";
                    boostedQuality = "Charisma";
                    increasedByNumber = 10;
                    player.Charisma += increasedByNumber;
                    break;
                case 11:
                    droppedItem = "CoCo's Dorito Clutch";
                    boostedQuality = "Charisma";
                    increasedByNumber = 10;
                    player.Charisma += increasedByNumber;
                    break;
                case 12:
                    droppedItem = "Bianca Del Rio's Officer Bryd Puppet";
                    boostedQuality = "Charisma";
                    increasedByNumber = 10;
                    player.Charisma += increasedByNumber;
                    break;
                case 13:
                    droppedItem = "Ru's Glamazon CD";
                    boostedQuality = "Talent";
                    increasedByNumber = 200;
                    player.Talent += increasedByNumber;
                    break; ;
                default:
                    break;
            }
            if (droppedItem != "")
            {
                Console.WriteLine("{0} dropped {1}! Your {2} has been boosted by {3}!\n", opponent.Name, droppedItem, boostedQuality, increasedByNumber);
            }
            else
            {
                Console.WriteLine("This Queen Dropped No Items");
            }
            
        }
    }
}
