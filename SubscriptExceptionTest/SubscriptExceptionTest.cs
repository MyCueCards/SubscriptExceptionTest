/********************************************************************
 * Original from SDEV 240                                           *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 537, Exercise 1):                             *
 * Write a program named SubscriptExceptionTest in which you        *
 * declare an array of 20 doubles and store values in the array.    *
 * Write a try block in which you place a loop that prompts the     *
 * user for a subscript value and displays the value stored in the  * 
 * corresponding array position. Create a catch block that catches  * 
 * any IndexOutOfRangeException and displays an appropriate error   *
 * message.                                                         *
 ********************************************************************/
using System;

namespace SubscriptExceptionTest
{
    class SubscriptExceptionTest
    {
        static void Main(string[] args)
        {
            double[] myArray = { 0.99, 1.99, 2.99, 3.99, 4.99, 5.99, 6.99, 7.99, 8.99, 9.99, 10.99, 11.99, 12.99, 13.99, 14.99, 15.99, 16.99, 17.99, 18.99, 19.99 };
            int input;
            string name;

            Console.WriteLine("Hi there! Before we begin, what's your name?");
            name = Console.ReadLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                try
                {
                    Console.WriteLine("Hi {0}! Enter a subscript value of the array (0 - 19): ", name);
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Congrats! The number in position {0} is: {1}.", input, myArray[input]);
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("Oops! That subscript value is out of range, {0}. Time to exit the program. Buh bye!", name);

                    //stops program from automatically closing after above text displays.
                    Console.ReadLine();
                }
            }
        }
    }
}
