using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace MethodOverloading
{
    public class Program
    {
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double add( double num1, double num2)
        {
            return num1 + num2;
        }

        public static string add(int num1, int num2, bool y)
        {
            var sum = num1 + num2;

            if (y == true && sum > 1)
            {
                return ($"{sum} dollars");
            }
            else if (y == true && sum == 1)
            {
                return ($"{sum} dollar");
            }
            else if ( y == true && sum < 1)
            {
                return ($"{sum} dollars");
            }
            else
                return sum.ToString();



        }
        
        static void Main(string[] args)
        {
            var total = add(2, 3);
            Console.WriteLine($"Total is: {total}");
            var deciSum = add(4.5, 5);
            Console.WriteLine($"Total is: {deciSum}");
            var money = add(3, 3, true);
            Console.WriteLine($"Total is: {money}");
        }
    }
}
