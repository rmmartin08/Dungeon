using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkRoom
{
    public class DragNames
    {
        public static string GetBoogerDragName()
        {
            string[] dragNames =
            {
            "Anna Conda",
            "Tess-Toss Der'on",
            "Yoko No Honey",
            "Petty Labelle",
            "Gal GaDon't Comeferme",
            "Mariah Dontcarey",
            "Helen Isa Troy",
            "Shay D",
            "Alliston Chains,",
            "Anita Procedure",
            "April Showers",
            "Eileen Sideways",
            "Fibonaci Sequence",
            "Ivy Drip",
            "Izzy Straight",
            "Lois Common Denominator",
            "Olive Yu",
            "Paige Turner",
            "Rita Menu",
            "Adele Laptop",
            "Aliyah Alone",
            "Beah DaBest",
            "Cher D Wealth",
            "Coco Pebbles",
            "Corona Iris",
            "Imma Mann",
            "Kat Atonic",
            "Polly Amorous",
            "Ruby Slippers"
        };
            return dragNames[new Random().Next(0, dragNames.Length)];
        }

        public static string GetHeatherDragName()
        {
            string[] dragNames =
            {
                "BeBe Zahara Benet",
                "Ongina",
                "Tammie Brown",
                "Tyra Sanchez",
                "Raven",
                "JuJubee",
                "Mystique Summers Madison",
                "Nichole Paige Brooks",
                "Shangela",
                "Raja",
                "Manilla Luzon",
                "Mimi Imfurst",
                "Sharon Needles",
                "Chad Michaels",
                "Latrice Royale",
                "DiDa Ritz",
                "Jinkx Monsoon",
                "Alaska",
                "Detox",
                "Roxxy Andrews",
                "Bianca Del Rio",
                "Adore Delano",
                "Gia Gunn",
                "BenDeLaCreme",
                "Milk",
                "Violet Chachki",
                "Ginger Minj",
                "Pearl Liaison",
                "Kennedy Davenport",
                "Katya Zamolodchikova",
                "Trixie Mattel",
                "Jasmine Masters",
                "Bob the Drag Queen",
                "Kim Chi",
                "Sasha Velour",
                "Peppermint",
                "Aquaria",
                "Monet X Change",
                "Vanessa Vanjie Mateo",
                "Yvie Oddly",
                "Brooke Lynn Hytes",
                "Silky Nutmeg Ganache",
                "Alyssa Edwards",
                "CoCo Montrese",
                "Tatianna",
                "Willam"
            };
            return dragNames[new Random().Next(0, dragNames.Length)];
        }
    }
}
