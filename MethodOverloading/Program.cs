using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer for the first example is "+  Add(4,2));
            Console.WriteLine("Answer for the second example is "+ Add(1.0m,2.0m));
            Console.WriteLine("Answer for the third example is " + Add(1, 2, true));
        }
       
        // Creating method with two int 
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method Overload  with decimals 

        public static decimal Add(decimal a,decimal b)
        {
            return a + b;
        }

        // Method Overload with two int and one bool
        public static string Add(int a, int b, bool ischeck)
        {
            var sum = a + b;
            if (ischeck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (ischeck == true && sum == 10)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();

            }
            
        }
    }
}
