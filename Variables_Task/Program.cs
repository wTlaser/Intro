using System;

namespace Variables_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string surname;
            string yob;
            string cy;

           Console.WriteLine("Enter First Name");
           firstname = Console.ReadLine();

           Console.WriteLine("Enter Surname");
           surname = Console.ReadLine();

           Console.WriteLine("Enter studentID");
           Console.ReadLine();

           Console.WriteLine("Year of birth");
           yob = Console.ReadLine();
           
           Console.WriteLine("Enter Current Year");
           cy = Console.ReadLine();

            int YOB;
            int CY; 
        
            YOB = int.Parse(yob); 
            CY = int.Parse(cy);



           Console.WriteLine(firstname + " " + surname);
           Console.WriteLine(CY - YOB);
        }
    }
}
