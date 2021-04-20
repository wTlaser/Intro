using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            string age;

            Console.WriteLine("User's Gender");
            gender = Console.ReadLine();

            Console.WriteLine("User's Age");
            age = Console.ReadLine();

            int int_age;

            int_age = int.Parse(age);

            if(int_age > 17) {
                Console.WriteLine(gender + " " + "is an adult");
            } else {
                Console.WriteLine(gender + " " + "is not an adult");
            }
        }
    }
}
