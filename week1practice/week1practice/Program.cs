using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1practice
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARING VARIABLES
            // 1. Declare a string variable called "myName" and set it equal to your name
            string myName = "Alex";
            // 2. Declare a number varible called "myAge" and set it equal to your age
            int myAge = 26;
            // 3. Delcare a boolean value called "myBool" and set it equal to true or false;
            bool myBool = true;
            // 4. Declare an array of strings called "productsList" and set it equal to "basketball", "baseball glove", "tennis shoes", "hockey puck"
            string[] productsList = { "basketball", "baseball glove", "tennis shoes", "hockey puck" };
            

            // PRINTING VARIABLES TO THE CONSOLE USING CONSOLE.WRITELINE()
            // 1. Print your name to the console using the format: "My name is <myName> and I'm a beast of a programmer"
            {
                Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            }
            // 2. Print out your age to the console using the format: "I am <myAge> years awesome."
            {
                Console.WriteLine("I am " + myAge + " years awesome.");
            }
            // 3. Print out your boolean value using the format: "I set my boolean value equal to <myBool>"
            {
                Console.WriteLine("I set my boolean value equal to " + myBool);
            }
            // 4. Using a For loop, print out each value in productsList.

            // FOR LOOP PRACTICE
            // 1. Create a for loop that prints out the numbers 1 to 10.
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }
            // 2. Create a for loop that prints out the numbers 10 to 1.
            for (int i = 10; i >= 1; i = i -1)
            {
                Console.WriteLine(i);
            }
            // 3. Create a for loop that prints out the numbers 10 to 30, only printing the even numbers
            // 4. Create a for loop that prints out the numbers 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)


            // WHILE LOOP PRACTICE
            // 1. Create a while loop that prints out the numbers from 1 to 10.
            // 2. Create a while loop that prints out the numbers from 10 to 1.
            // 3. Create a while loop that prints out the numbers from 15 to 30, only printing the even numbers
            // 4. Create a while loop that prints out the numbers from 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            // 5. Create a while loop that prints out the numbers from 1 to 10 until it reaches one that is divisible by 4.

            // PUTTING IT TOGETHER
            // Use either FOR or WHILE loops to accomplish the following:
            // 1. Print out the number of letters in your name using the format: "My name, <myName>, has <number of letters> in it."
            // 2. Print out the numbers of elements in your array using the format: "My array has <number of elements> in it."
            // 3. Print out the number of letters in each element of your array using the format: "<product name> has <number of letters> in it."
            // 2. Print out the number of items in your list using the format: "My product list has <number of items> in it."
            // 3. Print out the number of letters of each item in productsList using the format: "<product> has <number of letters> in it."

            // DECLARING AND CALLING FUNCTIONS
            // 1. Create a function called "Greeting" that takes one string parameter called "name".  This function will print "Hello <name>"
            // 2. Call the Greeting function by passing in "Geronimo Kackson" as your parameter.
            // 2. Call the Greeting function by passing in "Geronimo Jackson" as your parameter.
            // 3. Call the Greeting function by passing in myName as your parameter.

            // 4. Create a function called "DoubleIt" that takes one integer parameter called "number".  This function will print "<number> doubled is <number * 2>"

            //DECLARING AND CALLING RETURN FUNCTIONS
            // 1. Create a function called "NewGreeting" that takes one string parameter called "name".  This function will return a string in the format of "Hello, <name>"
            // 2. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter "Neil deGrasse-Tyson"
            //          EX: Console.WriteLine(FunctionCall("myParameter"));
            // 3. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter myName.

            // 4. Create a function called "TripleIt" that takes one integer parameter called "number".  This function will return the number times 3.

        }
    }
}
