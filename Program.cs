/*  
 *  Created By: Johnathan Estes
 *  Date Created: 6/29/2020
 *  Date Updated: 6/29/2020
 *  File Name: Formulas.cs
 *  Purpose: Create a Master Program to perform a vairety of computations.
 *
 */
using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Forumla menu. Press Enter to Continue.");
            EnterInput();
            MainMenu();


        }

        static void EnterInput() 
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //User can enter anything but the program wont continue unless enter is pushed.
            }
        }

        static void MainMenu()
        {
            Console.Clear(); //Clear the console
            int selection;
            //Master Menu to lead to each submenu. 
            Console.WriteLine("Enter in an integer.");
            Console.WriteLine("Select 1 for Area, 2 for Volume, or and other number to exit.");

            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("That was invalid. Enter a valid Grid Size.");
            }

            switch (selection)
            {
                case 1:
                    Area();
                    break;

                case 2:
                    break;

                default:
                    break;

            }

        }

        static void Area()
        {
            Console.Clear(); //Clear the console
            double length, width;
            double result;

            Console.WriteLine("Enter in the length of the rectangle.");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in the width of the rectangle.");
            width = Convert.ToDouble(Console.ReadLine());

            result = length * width;
            Console.WriteLine("The result using l*w is: " + result + ".");
            Console.WriteLine("Press Enter to Return to the Main Menu.");
            EnterInput();
            MainMenu();
        }
    }

}
