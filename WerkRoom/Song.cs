using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WerkRoom
{
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        public Song(string name)
        {
            Name = name;
            Artist = FindArtist(name);
        }

        public static string SelectASong()
        {
            string[] songs =
            {
                "Dancing on My Own",
                "Supermodel(You Better Work)",
                "My Lovin' (You're Never Gonna Get It)",
                "Something He Can Feel",
                "Bad Romance",
                "Believe",
                "Straight Up",
                "Toxic",
                "Bad Grils",
                "This Will Be (An Everlasting Love)",
                "Vouge",
                "Born This Way",
                "Whip My Hair",
                "Cold Hearted"
            };
            return songs[new Random().Next(0, songs.Length)];
        }

        public static string FindArtist(string song)
        {
            switch (song)
            {
                case "Dancing on My Own":
                    return "Robyn";
                case "Supermodel(You Better Work)":
                    return "RuPaul";
                case "My Lovin' (You're Never Gonna Get It)":
                    return "En Vougue";
                case "Something He Can Feel":
                    return "Aretha Franklin";
                case "Bad Romance":
                case "Born This Way":
                    return "Lady Gaga";
                case "Believe":
                    return "Cher";
                case "Straight Up":
                case "Cold Hearted":
                    return "Paula Abdul";
                case "Toxic":
                    return "Britney Spears";
                case "Bad Grils":
                    return "Donna Summer";
                case "This Will Be (An Everlasting Love)":
                    return "Natalie Cole";
                case "Vouge":
                    return "Madonna";
                case "Whip My Hair":
                    return "WILLOW";
                default:
                    return "";
            }
        }

        public static void PlaySong(Song song)
        {
            switch (song.Name)
            {
                case "Dancing on My Own":
                    Console.Beep(1000, 125);
                    Console.Beep(900, 125);
                    Thread.Sleep(125);
                    Console.Beep(1000, 125);
                    Console.Beep(1000, 600);
                    Thread.Sleep(250);
                    Console.Beep(800, 400);
                    Thread.Sleep(1000);
                    Console.Beep(1000, 300);
                    Console.Beep(900, 125);
                    Thread.Sleep(125);
                    Console.Beep(1000, 125);
                    Console.Beep(1000, 500);
                    Thread.Sleep(125);
                    Console.Beep(800, 600);
                    Thread.Sleep(300);
                    Console.Beep(1000, 600);
                    Console.Beep(900, 200);
                    Console.Beep(800, 200);
                    break;
                case "My Lovin' (You're Never Gonna Get It)":
                    Console.Beep(300, 100);
                    Thread.Sleep(50);
                    Console.Beep(300, 100);
                    Thread.Sleep(50);
                    Console.Beep(350, 100);
                    Thread.Sleep(50);
                    Console.Beep(350, 100);
                    Thread.Sleep(50);
                    Console.Beep(350, 100);
                    Console.Beep(350, 100);
                    Thread.Sleep(50);
                    Console.Beep(350, 100);
                    Thread.Sleep(50);
                    Console.Beep(325, 100);
                    break;
                default:
                    break;

            }


        }




    }
}
