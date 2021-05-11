using System;
using System.Collections.Generic;

namespace Assessment_1
{
    class Program
    {
        static void Main()
        {
            List<int> rolls = new List<int>();

            string input = "Anything but 3";
            while (input != 3) {
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("1. RollDice");
            System.Console.WriteLine("2. Examine Rolls");
            System.Console.WriteLine("3. Exit");
            System.Console.WriteLine("Select: ");   

            //User need to make a selection
            //int input = Convert.ToInt32(Console.ReadLine());

            int input = Convert.ToInt32(Console.ReadLine());

            switch (Console.ReadLine())
            {
                case "1":
                    rolls = RollMenu(rolls);
                    break;
                case "2":
                    ExamineMenu(rolls);
                    break;
                case "3":
                    return;
                default:
                    System.Console.WriteLine("Invalid Option");
                    Main();
                    break;
                }
            }
        }
        static List<int> RollMenu() {
            System.Console.WriteLine("RollMenu");
            System.Console.WriteLine("Press Enter to roll, type stop to stop rolling");

           string input = Console.ReadLine();
            while ( input != "stop") {
                //Roll dice
                Random rand = new Random();
                int roll = rand.Next(6) + 1;

                rolls.Add(roll);
                System.Console.WriteLine(roll);

                System.Console.WriteLine("Press Enter roll, type stop to stop rolling");
                input = Console.ReadLine();

            }

            return rolls;
        }
        static void ExamineMenu(List<int> rolls) {
            System.Console.WriteLine("ExamineMenu");
            System.Console.WriteLine("How many rolls do you want examined");
            int input = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            int average = 0;

            for (int index = 0; index<rolls< input; index++) {
                total = total + rolls[index];
            }
                PrintRolls(rolls, input);
                total = total + rolls(total);
                System.Console.WriteLine(total/input);
            }

        static void PrintRolls(List<int> rolls, int num) {
                Console.Write("[ ");
                for (int i = 0; i < rolls.Count; i++ ) {
                    if (i == num - 1) {
                        else {
                            Console.Write($"{rolls[i]},");
                        }
                    }
                    Console.WriteLine($"{rolls[i]}, ");
                }
                Console.WriteLine("]");
        }
    }
}