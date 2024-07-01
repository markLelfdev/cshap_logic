using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_csharp
{
    public class Number_To_Thaibaht
    {
        public int Number { get; set; }
        public Number_To_Thaibaht(int number)
        {
            Number = number;
        }

        public string NumberToThaibaht()
        {
            List<string> digit = new List<string>();
            List<string> numans = new List<string>();
            digit = ["", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน", "สิบล้าน"];
            numans = ["", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก่า"];
            if (Number < 0) { return "Number less Zero"; }
            else if (Number == 0) { return "ศูนย์"; }
            else
            {
                string result = "";
                string c_number = Number.ToString(); // convert number to string ex 101 => "101"
                int len = c_number.Length;
                for (int i = 0; i < len; i++)
                {
                    char c = c_number[i]; //have 1 character digit 1
                    int n = int.Parse(c.ToString());
                    int place = len - i - 1;

                    if (n != 0)
                    {
                        if (place == 1 && n == 1) { result = result + digit[i]; } // digit ten
                        else if (place == 1 && n == 2) { result = result + "ยี่สิบ"; } // digit twenty 
                        else if (place == 0 && n == 1) { result = result + "เอ็ด"; } // last place this one is thai digit
                        else { result += numans[n] + digit[place]; }
                    }
                    else { continue; }
                }
                return result;
            }

        }
    }
}
