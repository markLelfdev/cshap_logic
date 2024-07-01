using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_csharp
{
    public class Number_To_Roman
    {
        public int Number { get; set; }
        public Number_To_Roman(int number)
        {
            Number = number;
        }

        public string NumberToRoman()
        {
            Dictionary<string, int> roman_value = new Dictionary<string, int>
            {
                {"M",1000 },
                {"CM",900 },
                {"D",500 },
                {"CD",400 },
                {"C",100 },
                {"XC",90 },
                {"L", 50},
                {"XL",40 },
                {"X" ,10},
                {"IX" ,9},
                {"V" ,5},
                {"IV" ,4},
                {"I" ,1}
            };
            string roman_name = string.Empty;
            foreach (var item in roman_value)
            {
                while (Number >= item.Value)
                {
                    roman_name += item.Key;
                    Number -= item.Value;
                }
            }
            return roman_name;

        }

    }
}
