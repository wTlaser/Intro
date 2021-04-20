using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           string numberone;
           string numbertwo;
           
            Console.WriteLine("Eneter first Number");
            numberone = Console.ReadLine();

            Console.WriteLine("Eneter second Number");
            numbertwo = Console.ReadLine();

            int int_numberone;
            int int_numbertwo;

            int_numberone = int.Parse(numberone);
            int_numbertwo = int.Parse(numbertwo);

            if(int_numberone + int_numbertwo > 10) {
                Console.WriteLine("Sum of Numbers is greater than 10");
            } else if(int_numberone + int_numbertwo == 10) {
                Console.WriteLine("Sum of Numbers equal to 10");
            } else {
                Console.WriteLine("Sum of Numbers is less than 10");
            }
        }
    }
}