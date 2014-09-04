using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenge_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
        }
        //function for IsPrime
        static void IsPrime(int number)
        {
            //need to check all numbers in between 1 and itself to see if it is divisible by anything else
            bool prime = true;

            for (int i = 2; i <= 25; i++)
            {
                if (number % i == 0)
                {
                    //it's divisible a number, not a prime
                    prime = false;
                    break; //escape the loops
                }
            }
            //done with the loop, time for output
            if (prime)
            {
                Console.WriteLine(number + " is prime");
            }
            else
            {
                Console.WriteLine(number);
            }
            
        }
    
        //function for DashInsert
        static void DashInsert(int number)
        {
            //Goal: Insert a dash between two odd numbers
            //declare a string to hold our output
            string output = "";
            //declare a string to hold our number as a string
            //and convert the input number to a string
            string numberString = number.ToString();
            //loop through each digit of our string
            for (int i = 0; i <= numberString.Length; i++)
            {
                //get our current digit and the one next to it.
                string num1String = numberString[i].ToString();
                string num2String = numberString[i + 1].ToString();
                //convert our numberStrings to actual numbers
                int num1 = int.Parse(num1String);
                int num2 = int.Parse(num2String);
                //see if they are both odd numbers
                if (num1 % 2 != 0 && num2 % 2 != 0)
                {
                    //both odd, add to the output
                    output = output + num1 + "-";
                }
                else
                {
                    //not both add just add num1
                    output = output + num1;
                }
            }
            //need to add the last digit to our output, because the loop does not add it
            output = output + numberString[numberString.Length - 1];
            //print output
            Console.WriteLine(output);
            
        }
    
    }
}
