using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class Speciality
    {
        public string Name { get; set; }

        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = GetValue(Name); }
        }

        public Speciality(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public Speciality(string name)
        {
            Name = name;
            Value = GetValue(name);
        }

        public Speciality() { }

        public static string GetSpeciality()
        {
            string[] specialities =
            {
            "Death Drop",
            "Wig Snatching",
            "Singing",
            "Comedy Queen",
            "Camp Queen",
            "Lip Sync Assassin",
            "Party City Queen",
            "Instagram Queen",
            "Pageant Queen",
            "Not THAT kind of Girl",
            "Can Get a Sugar Daddy",
            "From Chicago",
            "Librarian",
            "Up-and-Coming Booger",
            "Up-and-Coming Heather",
            "Costume Queen",
            "Impersonator",
            "NOT JOKING *****"
        };

            return specialities[new Random().Next(0, specialities.Length)];
        }

        public static int GetValue(string name)
        {
            switch (name)
            {
                case "Death Drop":
                    return 10;
                case "Wig Snatching":
                    return 15;
                case "Singing":
                    return 10;
                case "Comedy Queen":
                    return 15;
                case "Camp Queen":
                    return 10;
                case "Lip Sync Assassin":
                    return 18;
                case "Party City Queen":
                    return 10;
                case "Instagram Queen":
                    return 5;
                case "Pageant Queen":
                    return 10;
                case "Not THAT kind of Girl":
                    return -10;
                case "Can Get a Sugar Daddy":
                    return 10;
                case "From Chicago":
                    return 15;
                case "Librarian":
                    return 15;
                case "Up-and-Coming Booger":
                    return -5;
                case "Up-and-Coming Heather":
                    return 8;
                case"Costume Queen":
                    return 9;
                case "Impersonator":
                    return 10;
                case "NOT JOKING *****":
                    return 15;
                default:
                    return 0;
            }
        }
    }
}
