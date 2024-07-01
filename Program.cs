using System;
using System.Drawing;
using System.Text;
namespace code_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number = 0;
            do
            {
                Console.WriteLine("Enter number to funtion :");
                Console.WriteLine("1 : Find Tail zero in Factorial");
                Console.WriteLine("2 : Find Max index in list");
                Console.WriteLine("3 : Change Number to Thaibath");
                Console.WriteLine("4 : Change Number to Roman");
                Console.WriteLine("999 : Exit");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Enter Number to find tail zero");
                        int numerric = Convert.ToInt32(Console.ReadLine());
                        Find_Tail_Zero fn1 = new Find_Tail_Zero(numerric);
                        Console.WriteLine("Result Tail zero = " + fn1.FindTailZero());
                        Console.WriteLine("Result Factorial = " + fn1.factorial());
                        break;
                    case 2:
                        List<int> listdata = new List<int>();
                        Console.WriteLine("Enter number in list (enter a non-integer value to finish) :");
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!int.TryParse(input, out number))
                            {
                                break;
                            }
                            listdata.Add(number);
                        }
                        Find_max_index fn_index = new Find_max_index(listdata);
                        int max_index = fn_index.FindMaxIndex();
                        Console.WriteLine("Data index Max :" + max_index);
                        break;
                    case 3:
                        Console.WriteLine("Enter number to bath thai :");
                        int cost_in = Convert.ToInt32(Console.ReadLine());
                        Number_To_Thaibaht thb = new Number_To_Thaibaht(cost_in);
                        Console.WriteLine(thb.NumberToThaibaht());
                        break;
                    case 4:
                        Console.WriteLine("Enter Interger To Roman :");
                        int roman = Convert.ToInt32(Console.ReadLine());
                        Number_To_Roman rohm = new Number_To_Roman(roman);
                        Console.WriteLine(rohm.NumberToRoman());
                        break;
                    default:
                        break;
                }
            } while (number != 999);

        }
    }
}