using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class Queen
    {
        public string Name { get; set; }
        public int Charisma { get; set; }
        public int Uniqueness { get; set; }
        public int Nerve { get; set; }
        public int Talent { get; set; }
        public Speciality Special { get; set; }

        public Queen() { }

        public Queen(string name, int charisma, int uniqueness, int nerve, int talent, Speciality special)
        {
            Name = name;
            Charisma = charisma;
            Uniqueness = uniqueness;
            Nerve = nerve;
            Talent = talent;
            Special = special;
            CalculateSpecialBonus(Special);
            if (Uniqueness < 0)
            {
                Uniqueness += 10;
            }
            if (Talent < Uniqueness)
            {
                Talent += 10;
            }
        }

        public override string ToString()
        {
            return string.Format($"Name: {Name}\nCharisma: {Charisma}\nUniqueness: {Uniqueness}\nNerve: {Nerve}\nTalent: {Talent}\nSpecial: {Special.Name}\n");
        }

        public void CalculateSpecialBonus(Speciality special)
        {
            if (special.Name == "Lip Sync Assassin" || special.Name == "Pageant Queen" || special.Name == "From Chicago" || special.Name == "Impersonator" || special.Name == "NOT JOKING *****")
            {
                Charisma += special.Value;
            }
            if (special.Name == "Camp Queen" || special.Name == "Party City Queen" || special.Name == "Can Get a Sugar Daddy" || special.Name == "From Chicago" || special.Name == "NOT JOKING *****")
            {
                Uniqueness += special.Value;
            }
            if (special.Name == "Wig Snatching" || special.Name == "Instagram Queen" || special.Name == "Can Get a Sugar Daddy" || special.Name == "Up-and-Coming Booger"
                || special.Name == "From Chicago" || special.Name == "Up-and-Coming Heather" || special.Name == "Costume Queen" || special.Name == "NOT JOKING *****")
            {
                Nerve += special.Value;
            }
            if (special.Name == "Death Drop" || special.Name == "Singing" || special.Name == "Comedy Queen" || special.Name == "Not THAT kind of Girl"
                || special.Name == "From Chicago" || special.Name == "Librarian" || special.Name == "NOT JOKING *****")
            {
                Talent += special.Value;
            }
        }

        public int CalcShade()
        {
            return new Random().Next(Uniqueness, Talent + 1);
        }
    }
}