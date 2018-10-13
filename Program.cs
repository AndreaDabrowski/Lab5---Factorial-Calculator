using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)

        {
            string response;
            Console.WriteLine("Welcome to the factorial calculator!");
            do
            {
                //prompts user for input, converts to int
                Console.Write("Please enter a number between 1-20: ");
                long userInput = long.Parse(Console.ReadLine());

                //displays original input and factorial
                Console.WriteLine("{0} factored out is {1}.", userInput, getFactorial(userInput));

                //prompts user to continue
                Console.Write("Would you like to continue (y/n): ");
                response = Console.ReadLine().ToLower();


            }
            while (YesOrNo(response));
            Console.ReadLine();

        }

        //determines action (bool) based on y/n reponse from user
        public static bool YesOrNo(string response)
        {

            while (response == "y")
            {
                return true;
            }

            if (response == "n")
            {
                Console.WriteLine("Exiting program...");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, try again later."); //i could not figure out how to loop this back to the top of method
                response = Console.ReadLine().ToLower();
                return false;
            }

        }

        //calculates the factorial value using recursion
        public static long getFactorial(long num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * getFactorial(num - 1); //recursion used (extended challenge)

        }
        //calculates factorial value using for loop

        /*public static long getFactorialForLoop(long num)
        {
            long result = num;
            if (num <=1)
            {
                return 1;
            }
            for (int i = 1; i <= num; i++) //for loop used
            {
                result = result * i;
                
                return result;
            }
        }*/
    }
}
