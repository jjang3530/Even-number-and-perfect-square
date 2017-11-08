/* Program ID: A3JayJangP1
 * Purpose: Assignment 3 Part 1
 * Revision History:
 * Jay Jang - Mar 3, 2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JayJangP1
{
    class Program
    {
        public static string menuOption(string input) //Menu Method
        {
            string inputString ="";
            do
            {
                Console.WriteLine(" ┌─────────────── MAIN MENU ───────────────┐");
                Console.WriteLine(" │1. Display a list of even numbers.       │");
                Console.WriteLine(" │2. Display a sequence of perfect squares.│");
                Console.WriteLine(" │3. Exit the program.                     │");
                Console.WriteLine(" └─────────────────────────────────────────┘");
                Console.Write("  Select Option(1 or 2 or 3) : ");
                inputString = Console.ReadLine();
                Console.WriteLine("");
            } while (inputString == "");
              return inputString;
        }

        // 1st Method of Even Number
        public static string evenNumberMethod(string input)
        {
            string inputString = "";
            int inputNumber = 0;
            int evenNumber = 0;
            Console.Write("How many do you want to display even numbers : ");
            inputString = Console.ReadLine();
            inputNumber = int.Parse(inputString);
            if (inputNumber <= 0)
            {
                throw new Exception();
            }

            for (evenNumber = 0; evenNumber < inputNumber;
                 evenNumber = evenNumber +1 )
                {
                 Console.WriteLine(" \'" + 2 * evenNumber + "\'");
                }
            return inputString;
        }

        // 2nd Method of Perfet Squares
        public static string perfectSquares(string input)
        {
            string inputString = "";
            int inputNumber = 0;
            int sequenceNumber = 2;
            inputString = Console.ReadLine();
            inputNumber = int.Parse(inputString);
            if (inputNumber != 1 && inputNumber != 2)
            {
                throw new Exception();
            }
            while (inputNumber == 1)
            {
                Console.WriteLine("");
                Console.WriteLine(" \'" + sequenceNumber
                                   * sequenceNumber + "\'");
                Console.WriteLine("");
                Console.WriteLine("1. Continue to display next square.");
                Console.WriteLine("2. Stop and return to the main menu.");
                Console.Write("Select Option(1 or 2) : ");
                inputString = Console.ReadLine();
                inputNumber = int.Parse(inputString);
                sequenceNumber = sequenceNumber + 1;
            }
            return inputString;
        }

        static void Main(string[] args) //Main Start
        {
            do
             {
            string inputOption = "";
            string inputNumberSting = "";
            string evenNumber = "";
            string inputString = "";

            inputOption = menuOption("");

                if (inputOption.Equals("1")) //Option.1 A List of Even Number
                {
                    Console.WriteLine("Option.1 Selected.");
                    try
                    {
                        evenNumber = evenNumberMethod(inputNumberSting);
                        Console.WriteLine("Listed "
                                           + evenNumber + " Even numbers");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid value please start again!");
                    }
                }

                //Option.2 A Sequence of Perfect Squares
                else if (inputOption.Equals("2"))
                {
                    Console.WriteLine("Option.2 Selected.");
                    Console.WriteLine("Display a sequence of perfect squares");
                    Console.WriteLine("");
                    Console.WriteLine(" \'1\'");
                    Console.WriteLine("");
                    Console.WriteLine("1. Continue to display next square.");
                    Console.WriteLine("2. Stop and return to the main menu.");
                    Console.Write("Select Option(1 or 2) : ");
                    try
                    {
                        inputNumberSting = perfectSquares(inputString);
                    }
                    catch (Exception)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid value please start again!");
                    }
                }

                else if (inputOption.Equals("3")) //Option.3 Exit the program
                    {
                    Console.WriteLine("Exit the program Selected! ByeBye:)");
                    Console.WriteLine("");
                            return;
                    }
                else if (inputString != "1" && inputString != "2"
                     && inputString != "3")
                {
                    Console.WriteLine("Invalid value please start again!");
                }
                Console.WriteLine("");
            } while (true);
        }
    }
    }
