using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            //for loop - FizzBuzz(i) pulls from below @ Static Void.

            //create a loop from 0=>20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            //create a loop from 92=<79
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }


            //make the console stay open
            Console.ReadKey();
        }
        //Functions go here
        //FizzBuzz() takes in a number and spits out "fizz", "buzz", "fizzbuss" or the number
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                //# is divisable by 5 & 3
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                //# is divisable by 5
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                //# is divisiaable by 3
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }


        }
        // #2
        static void Yodaizer(string word)
        {
            string text = "I like code";
            string reverse = string.Empty;

            text.Reverse();

            {
                Console.WriteLine();
                Console.ReadKey();
            }



        }
        //3
        static void TextStats(string finder)
        {
            string input = "Code is suhweet!";
            {
                Console.WriteLine(input.Length);



            }
        }
        // #4
        //IsPrime takes an integer parameter called "number" and performs logic
        // to determine if it is a prime number.
        static void IsPrime(int number)
        {
            if (number > 1 && number % number == 0 && number % 1 == 0 && number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else if (number == 3 || number == 5)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                //number is not prime
                Console.WriteLine(number);
            }

            Console.Read();
        }
        // # 5
        static void DashInsert(int number)
        {
            string numberString = number.ToString();

            string output = "";
            for (int i = 0; i < numberString.Length; i++)
            {
                int num1 = int.Parse(numberString[i].ToString());
                output = output + num1;
                if (i != numberString.Length - 1 && num1 % 2 != 0 && int.Parse(numberString[i + 1].ToString()) != 0)
                {
                    output = output + "-";
                }
            }
            // Print output
            Console.WriteLine(output);

        }
    }
}