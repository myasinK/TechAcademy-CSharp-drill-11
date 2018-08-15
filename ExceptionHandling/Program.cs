using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers. Ask the user for a number 
            // to divide each number in the list by. Write a loop that 
            // takes each integer in the list, divides it by the number 
            // the user entered, and displays the result to the screen.
            // Run that code, entering in non-zero numbers as the user. 
            // Look at the displayed results.
            // Run that code, entering in zero as the number to divide by. 
            // Note any error messages you get.
            // Run that code, entering in a string as the number to divide 
            // by. Note any error messages you get.
            // Now put the loop in a try/catch block. 
            // Below and outside of the try/catch block, make the program 
            // display a message to the display to let you know the program 
            // has emerged from the try/catch block and continued on with 
            // program execution. In the catch block, display the error 
            // message to the screen. Then try various combinations of user 
            // input: valid numbers, zero and a string. Ensure the proper 
            // error messages display on the screen, and that the code 
            // after the try/catch block gets executed.
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++) {
                list.Add(rnd.Next(1,101));
            }
            // Get user input
            Console.WriteLine("Enter a number to divide all elements in the list: ");
            int divisor = Convert.ToInt16(Console.ReadLine());
            // Divide list by divisor
            int count = 0;
            foreach (int num in list)
            {
                try
                {
                    Console.WriteLine(num / divisor);
                    count++;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("ERROR: You cannot divide by zero");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Please enter an integer for the divisor");
                    break;
                }
                finally
                {
                    Console.WriteLine("Program has exited current loop. If no error has been displayed, loop has executed successfully");
                }
                Console.WriteLine("Program executed without errors");
                Console.ReadLine();
            }
            
        }
    }
}
