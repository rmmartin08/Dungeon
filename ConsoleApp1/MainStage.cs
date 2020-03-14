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
            Console.ForegroundColor = ConsoleColor.White;
            Random rand = new Random();
            bool exit = false;
            //Logo.ThemeSong();
            string specialName = Speciality.GetSpeciality();
            Speciality boogerSpecial = new Speciality(specialName, Speciality.GetValue(specialName));
            Booger booger = new Booger(DragNames.GetBoogerDragName(), rand.Next(0, 21), rand.Next(5, 21),
                rand.Next(60, 301), rand.Next(21, 40), boogerSpecial, rand.Next(10, 31));
            //Console.WriteLine("You Walk into the WerkRoom, What is Your Real Name?");
            //string playerName = Console.ReadLine();
            Console.WriteLine("Welcome!\nYour Drag Name is: {0}\n", booger.Name);
            do
            {
                Heather heather = Heather.GenerateHeather();
                Heather heatherTwo = Heather.GenerateHeather();
                while (heather.Name == heatherTwo.Name)
                {
                    heatherTwo = Heather.GenerateHeather();
                }
                Song singleSong = new Song(Song.SelectASong());
                //Console.WriteLine($"You are in the bottom 3 with {heather.Name} and {heatherTwo.Name}");
                //for (int i = 0; i < 50; i++)
                //{
                //    Console.Write('-');
                //    Thread.Sleep(75);
                //}
                int draw = new Random().Next(0, 2);
                if (draw == 0)
                {
                    heather = heatherTwo;
                }
                //Console.WriteLine($"\nRuPaul: {booger.Name}, {heather.Name}...  I'm sorry my dears but you are both up for elimination"); Thread.Sleep(4000);
                //Console.WriteLine($"\tEach of you has been asked to prepare a lip sync to \"{singleSong.Name}\" by {singleSong.Artist}"); Thread.Sleep(4000);
                //Console.WriteLine("\tTwo queens stand before me, ladies this is your last chance to impress me and save yourself from elimination."); Thread.Sleep(4000);
                //Console.Write("\tThe time has come for you to lipsync");
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.Write('.');
                //    Thread.Sleep(900);
                //}
                //Console.Write("FOR"); Thread.Sleep(1000);
                //Console.Write(" YOUR"); Thread.Sleep(1000);
                //Console.WriteLine(" LIFE!"); Thread.Sleep(1000);
                //Lightning.LightningFlashes();
                //Console.Write("RuPaul: Good Luck"); Thread.Sleep(1000);
                //Console.WriteLine(" and don't *&#! it up!"); Thread.Sleep(2000);
                //Song.PlaySong(singleSong);
                bool reload = false;
                do
                {
                    Console.WriteLine("\nPlease Choose and action:\nL) Lipsync for Your Life\nT) Try to get Away with Lip Syncing with a Mask on\nP) Player Info\nO) Opponent Info\nX) Exit");
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
                                reload = true;
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
                            Console.WriteLine();
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            Console.WriteLine(booger);
                            break;
                        case ConsoleKey.O:
                            Console.WriteLine("Opponent Info");
                            Console.WriteLine(heather);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            booger.Nerve = 0;
                            reload = true;
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
                        reload = true;
                        exit = true;
                    }
                } while (!reload);

            } while (!exit);

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
            Console.WriteLine("Let the Music Play!");

        }
    }
}
