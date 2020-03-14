using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class Heather : Queen
    {
        public int HeelHeight { get; set; }

        public Heather() { }

        public Heather(string name, int charisma, int uniqueness, int nerve, int talent, Speciality special, int heelheight) : base(name, charisma, uniqueness, nerve, talent, special)
        {
            HeelHeight = heelheight;
            Talent += heelheight;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}Heel Height: {HeelHeight}");
        }
        
        public static Heather GenerateHeather()
        {
            Random rand = new Random();
            string heatherName = DragNames.GetHeatherDragName();
            Speciality heatherSpecial = new Speciality(GenerateHeatherSpecial(heatherName));
            return new Heather(heatherName, rand.Next(0, 21), rand.Next(5, 21),
                rand.Next(60, 201), rand.Next(21, 40), heatherSpecial, rand.Next(10, 31));
        }
        
        public static string GenerateHeatherSpecial(string heatherName)
        {
            switch (heatherName)
            {
                case "BeBe Zahara Benet":
                    return "Lip Sync Assassin";
                case "Tammie Brown":
                case "Jinkx Monsoon":
                case "Alaska":
                case "Bianca Del Rio":
                case "BenDeLaCreme":
                case "Ginger Minj":
                case "Katya Zamolodchikova":
                case "Trixie Mattel":
                case "Bob the Drag Queen":
                    return "Comedy Queen";
                case "Raven":
                case "JuJubee":
                case "Tatianna":
                    return "Wig Snatching";
                case "Mystique Summers Madison":
                case "DiDa Ritz":
                case "Gia Gunn":
                case "Kim Chi":
                case "Silky Nutmeg Ganache":
                    return  "From Chicago";
                case "Shangela":
                    return "Can Get a Sugar Daddy";
                case "Mimi Imfurst":
                    return "Not THAT kind of Girl";
                case "Raja":
                case "Manilla Luzon":
                    return "Up-and-Coming Heather";
                case "Sharon Needles":
                    return "Party City Queen";
                case "Chad Michaels":
                    return "Impersonator";
                case "Adore Delano":
                    return "Singing";
                case "Kennedy Davenport":
                    return "Death Drop";
                case "CoCo Montrese":
                return "NOT JOKING *****";
                default:
                    return Speciality.GetSpeciality();
            }
        }
    }
}
