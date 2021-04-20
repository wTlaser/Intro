using System;

namespace Selection_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string age;

            Console.WriteLine("User's Age");
            age = Console.ReadLine();

            int int_age;

            int_age = int.Parse(age);


            if(int_age > 17) {
                Console.WriteLine("Legally Adult Age");
            } else { 
                Console.WriteLine("Legally Not Adult Age");
            }





        }
    }
}
