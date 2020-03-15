using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Animations;
using WerkRoom;

namespace ConsoleApp1
{
    class MainStage
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(208, 40);
            Console.SetWindowPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Random rand = new Random();            
            Logo.ThemeSong();
            string specialName = Speciality.GetSpeciality();
            Speciality boogerSpecial = new Speciality(specialName, Speciality.GetValue(specialName));
            Booger booger = new Booger(DragNames.GetBoogerDragName(), rand.Next(0, 21), rand.Next(5, 21),
                rand.Next(60, 301), rand.Next(21, 40), boogerSpecial, rand.Next(10, 31));
            Console.WriteLine("You Walk into the WerkRoom");
            Console.WriteLine("Welcome!\nYour Drag Name is: {0}\n", booger.Name);
            byte playOption = 3;
            do
            {

                Console.WriteLine("Would you like to:\n");
                Console.WriteLine("1) Shante til you Drop\n");
                Console.WriteLine("2) Try to Snatch That Crown\n");
                Console.WriteLine("3) Rules of the Game");
                playOption = Convert.ToByte(Console.ReadLine());
                switch (playOption)
                {
                    case 1:
                        PlayOptionOne(booger);
                        break;
                    case 2:
                        PlayOptionTwo(booger);
                        break;
                    case 3:
                        DisplayRules();
                        break;
                    default:
                        break;
                }

            } while (playOption ==3); 
            Console.WriteLine("And Remember, If You Can't Love Yourself How in the Hell You Gonna Love Somebody Else?");
            Console.WriteLine("Can I Get an Amen?");
            string input = "";
            do
            {
                input = Console.ReadLine().ToLower();
                if (input != "amen")
                {
                    Console.WriteLine("Okay But Can I Get an Amen?");
                }
            } while (input != "amen");
            Console.WriteLine("Now let the Music Play!");

        }

        static void PlayOptionOne(Booger booger)
        {
            booger.Nerve += 200;
            bool exit = false;
            byte heatherCounter = 0;
            do
            {
                Heather heather = Heather.GenerateHeather();
                Heather heatherTwo = Heather.GenerateHeather();
                while (heather.Name == heatherTwo.Name)
                {
                    heatherTwo = Heather.GenerateHeather();
                }
                Song singleSong = new Song(Song.SelectASong());
                Console.WriteLine($"You are in the bottom 3 with {heather.Name} and {heatherTwo.Name}");
                for (int i = 0; i < 50; i++)
                {
                    Console.Write('-');
                    Thread.Sleep(75);
                }
                int draw = new Random().Next(0, 2);
                if (draw == 0)
                {
                    heather = heatherTwo;
                }
                Console.WriteLine($"\nRuPaul: {booger.Name}, {heather.Name}...  I'm sorry my dears but you are both up for elimination"); Thread.Sleep(4000);
                Console.WriteLine($"\tEach of you has been asked to prepare a lip sync to \"{singleSong.Name}\" by {singleSong.Artist}"); Thread.Sleep(4000);
                Console.WriteLine("\tTwo queens stand before me, ladies this is your last chance to impress me and save yourself from elimination."); Thread.Sleep(4000);
                Console.Write("\tThe time has come for you to lipsync");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write('.');
                    Thread.Sleep(900);
                }
                Console.Write("FOR"); Thread.Sleep(1000);
                Console.Write(" YOUR"); Thread.Sleep(1000);
                Console.WriteLine(" LIFE!"); Thread.Sleep(1000);
                //Lightning.LightningFlashes();
                Console.Write("RuPaul: Good Luck"); Thread.Sleep(1000);
                Console.WriteLine(" and don't *&#! it up!"); Thread.Sleep(2000);
                Song.PlaySong(singleSong);
                Console.Clear();
                LipSync.RandomRules(booger, heather, singleSong);
                Random rand = new Random();
                bool exit2 = false;
                do
                {                    
                    Console.WriteLine("\nPlease Choose and action:\nL) Lipsync for Your Life\nT) Try to get Away with Lip Syncing with a Mask on\nP) Player Info\nO) Opponent Info\nR) Rules\nX) Exit");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.L:
                            LipSync.ForYourLife(booger, heather);
                            if (heather.Nerve <= 0)
                            {
                                Console.WriteLine("\n{0} You're a Winner Baby", booger.Name);
                                Console.WriteLine("\n{0} Now Sashay Away....\n", heather.Name);
                                LipSync.Loot(booger, heather, rand);
                                heatherCounter++;
                                Console.WriteLine("You defeated {0} Queen{1}", heatherCounter, heatherCounter == 0 ? "" : "s");                                
                                exit2 = true;
                            }
                            else
                            {
                                LipSync.ForYourLife(heather, booger);
                            }
                            break;
                        case ConsoleKey.T:
                            Console.WriteLine("You Ask RuPaul To Keep the Mask On");
                            Console.WriteLine($"{heather.Name} knows You Don't Know the Words and Throws Shade on Twitter!");
                            LipSync.ThrowShade(heather, booger);
                            exit2 = true;
                            Console.WriteLine("You've defeated {0} Queen{1}", heatherCounter, heatherCounter == 0 ? "" : "s");
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            Console.WriteLine(booger);
                            break;
                        case ConsoleKey.O:
                            Console.WriteLine("Opponent Info");
                            Console.WriteLine(heather);
                            break;
                        case ConsoleKey.R:
                            DisplayRules();
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            booger.Nerve = 0;
                            exit2 = true;
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Roxxy Andrews Made it Clear... That Was Not a Valid Selection...");
                            break;
                    }

                    if (booger.Nerve <= 0)
                    {
                        Console.WriteLine("\n{0} You're a Winner Baby", heather.Name);
                        Console.WriteLine("{0} Now Sashay Away....\n", booger.Name);
                        Console.WriteLine("You defeated {0} Queen{1}", heatherCounter, heatherCounter == 1 ? "" : "s");
                        exit2 = true;
                        exit = true;
                    }
                } while (!exit2);

            } while (!exit);

        }

        static void PlayOptionTwo(Booger player)
        {
            Console.WriteLine("Would you like to battle against:\n1) 4 Queens\n2) 8 Queens\n3) 16 Queens\n");
            byte userSelection = Convert.ToByte(Console.ReadLine());
            byte heatherNumber = 2;
            switch (userSelection)
            {
                case 1:
                    heatherNumber = 4;
                    break;
                case 2:
                    heatherNumber = 8;
                    break;
                case 3:
                    heatherNumber = 16;
                    break;
            }
            Heather[] heathers = new Heather[heatherNumber];
            Random rand = new Random();
            for (int i = 0; i < heatherNumber - 1; i++)
            {
                Random rand2 = new Random();
                string heatherName = DragNames.GetHeatherDragName(false, (byte)rand.Next(0, 45));
                Speciality heatherSpecial = new Speciality(Heather.GenerateHeatherSpecial(heatherName));
                heathers[i] = (new Heather(heatherName, rand2.Next(0, 21), rand2.Next(5, 21),
                    rand2.Next(60, 201), rand2.Next(21, 40), heatherSpecial, rand2.Next(10, 31)));
            }
            Speciality ruSpecial = new Speciality(Heather.GenerateHeatherSpecial("RuPaul"));
            heathers[heatherNumber - 1] = (new Heather("RuPaul", rand.Next(0, 21), rand.Next(5, 21),
                    rand.Next(60, 401), rand.Next(21, 40), ruSpecial, rand.Next(10, 31)));
            bool exit = false;
            int heatherCounter = 0;
            do
            {

                Song singleSong = new Song(Song.SelectASong());
                    if (heatherCounter != heatherNumber-1)
                    {
                        Console.WriteLine($"You are up against {heathers[heatherCounter].Name}");
                        Console.WriteLine($"\nRuPaul: {player.Name}, {heathers[heatherCounter].Name}...  I'm sorry my dears but you are both up for elimination"); Thread.Sleep(4000);
                        Console.WriteLine($"\tEach of you has been asked to prepare a lip sync to \"{singleSong.Name}\" by {singleSong.Artist}"); Thread.Sleep(4000);
                        Console.WriteLine("\tTwo queens stand before me, ladies this is your last chance to impress me and save yourself from elimination."); Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("RuPaul: That is it, you are coming for my crown and I can't have it...");
                        Console.Write("You will now battle against the true Queen... Me! Now truly....");
                    }
                    Console.Write("\tThe time has come for you to lipsync");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write('.');
                        Thread.Sleep(900);
                    }
                    Console.Write("FOR"); Thread.Sleep(1000);
                    Console.Write(" YOUR"); Thread.Sleep(1000);
                    Console.WriteLine(" LIFE!"); Thread.Sleep(1000);
                    //Lightning.LightningFlashes();
                    if (heatherCounter != heatherNumber - 1)
                    {
                        Console.Write("RuPaul: Good Luck"); Thread.Sleep(1000);
                        Console.WriteLine(" and don't *&#! it up!"); Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("RuPaul: Good Luck...."); Thread.Sleep(1000);
                        Console.WriteLine("RuPaul Laughs"); Thread.Sleep(2000);
                    }
                    LipSync.RandomRules(player,heathers[heatherCounter],singleSong);
                    Song.PlaySong(singleSong);
                    bool exit2 = false;
                    do
                    {
                        Console.WriteLine("\nPlease Choose and action:\nL) Lipsync for Your Life\nP) Player Info\nR) Rules\nO) Opponent Info\nX) Exit");
                        ConsoleKey userChoice = Console.ReadKey(true).Key;
                        Console.Clear();
                        switch (userChoice)
                        {
                            case ConsoleKey.L:
                                LipSync.ForYourLife(player, heathers[heatherCounter]);
                                if (heathers[heatherCounter].Nerve <= 0)
                                {
                                    Console.WriteLine("\n{0} You're a Winner Baby", player.Name);
                                    Console.WriteLine("\n{0} Now Sashay Away....\n", heathers[heatherCounter].Name);
                                    LipSync.Loot(player, heathers[heatherCounter],rand);
                                    exit2 = true;
                                    heatherCounter++;
                                    Console.WriteLine("You've defeated {0} Queen{1}", heatherCounter, heatherCounter == 0 ? "" : "s");
                                }
                                else
                                {
                                    LipSync.ForYourLife(heathers[heatherCounter], player);
                                }
                                break;
                            case ConsoleKey.P:
                                Console.WriteLine("Player Info");
                                Console.WriteLine(player);
                                break;
                            case ConsoleKey.O:
                                Console.WriteLine("Opponent Info");
                                Console.WriteLine(heathers[heatherCounter]);
                                break;
                            case ConsoleKey.R:
                                DisplayRules();
                            break;
                            case ConsoleKey.X:
                            case ConsoleKey.E:
                                player.Nerve = 0;
                                exit2 = true;
                                exit = true;
                                break;

                            default:
                                Console.WriteLine("Roxxy Andrews Made it Clear... That Was Not a Valid Selection...");
                                break;
                        }

                        if (player.Nerve <= 0)
                        {
                            Console.WriteLine("\n{0} You're a Winner Baby", heathers[heatherCounter].Name);
                            Console.WriteLine("{0} Now Sashay Away....\n", player.Name);
                            Console.WriteLine("You defeated {0} Queen{1}", heatherCounter, heatherCounter == 0 ? "" : "s");
                            exit2 = true;
                            exit = true;
                        }                        
                    } while (!exit2);
            } while (!exit);
        }

        static void DisplayRules()
        {

            Console.Clear();
            Console.WriteLine("General Gameplay:\nYou Battle Lip Syncing Against Queens. Each of You Has Your Own Level of:\nCharisma - Block\n" +
                "Uniqueness - Min Attack\nNerve - Life\nTalent - Max Attack\nThe Last Queen Standing is the Winner of That Round\n" +
                "In Game Options Inclue Lip Syncing Which Starts the Battle, Checking Your or Your Opponent's Stats, and Exiting the Game\n" +
                "When You Win a Lip Sync the Defeated Queen Might Drop Loot Which Can Boost Your Stats." +
                "\n\n*****Game Options*****\n" +
                "Shante til you Drop:\nYou Will Lip Sync Until You Are Out of Life or Give Up. Bonus Option to Attempt to Try to get Away with Lip Syncing with a Mask on " +
                "Which Means You Get to Try to Beat That Queen Without Knowing The Words.\n**Caution if You Choose This Option the Other Queen is Going to Know You Don't" +
                " Know the Words and Will Attempt to Throw Some Shade.\n\n" +
                "Try to Snatch That Crown:\nYou Will Lip Sync Against Either 4, 8, or 16 Queens in Order to Snatch The Ultimate Crown\n");
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
