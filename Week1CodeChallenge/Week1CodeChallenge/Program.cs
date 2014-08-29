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
    }
}
