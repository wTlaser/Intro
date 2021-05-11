using System;

namespace Assessment_1
{
    class Program
    {
        static void Main()
        {
         System.Console.WriteLine("Welcome");
         System.Console.WriteLine("1. RollDice");
         System.Console.WriteLine("2. Examine Rolls");
         System.Console.WriteLine("3. Exit");
         System.Console.WriteLine("Select: ");   

         //User need to make a selection
         int input = Convert.ToInt32(Console.ReadLine());

         switch (Console.ReadLine())
         {
            case "1":
                RollMenu();
                break;
            case "2":
                ExamineMenu();
                break;
            case "3":
                return;
            default:
                System.Console.WriteLine("Invalid Option");
                Main();
                break;
         }
        }
        static void RollMenu() {
            System.Console.WriteLine("RollMenu");
            System.Console.WriteLine("Press Enter to roll, type stop to stop rolling");

           string input = Console.ReadLine();
            while ( input != "stop") {
                //Roll dice
                Random rand = new Random();
                int roll = rand.Next(6) + 1;

                System.Console.WriteLine(roll);

                System.Console.WriteLine("Press Enter roll, type stop to stop rolling");
                input = Console.ReadLine();

            }

            Main();
        }
        static void ExamineMenu() {
            System.Console.WriteLine("ExamineMenu");

            Main();
        }
    }
}