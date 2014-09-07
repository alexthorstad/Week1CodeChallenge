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
        {   // #2
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
        // #3
        static void Yodaizer(string word)
        {
            string text = "I like code";
            string reverse = string.Empty;

            text.Reverse();

            {
                Console.WriteLine();
                
            }



        }
        //4
        static void TextStats(string finder)
        {
            // Text Input and Write to Console
            string input = "Code is suhweet!";
            Console.WriteLine(input.Length);
            
        }
        // #5
        //IsPrime takes an integer parameter called "number" and performs logic
        // to determine if it is a prime number.
        static void IsPrime(string prime)

        {
            // #6
            //If the number is a prime number, your function will write:
            // "X is a prime number"
            //If the number is not prime, print out the number.

            //Create a loop from 1-25 - It calls IsPrime for each number from 1-25.
            for (int i = 1; i <= 25; i++)
            {
                
            }
                


        }




    }

} 