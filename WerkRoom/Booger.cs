using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class Booger : Queen
    {
        public int WigStrength { get; set; }

        public Booger(string name, int charisma, int uniqueness, int nerve, int talent, Speciality special, int wigStrength) : base(name, charisma, uniqueness, nerve, talent, special)
        {
            WigStrength = wigStrength;
            Nerve += wigStrength;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()}Wig Strength: {WigStrength}");
        }
    }
}
