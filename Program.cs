using System;

namespace LAB_2_ASSIGNMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Hello World!");

        
//         int a=20;
//         int b=3;
//         int c=a%b;

// Console.WriteLine(c);
            
            Console.WriteLine("Input first no: ");
            var inputNo1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second no: ");
            var inputNo2=Convert.ToInt32(Console.ReadLine());

            var returnReminder=inputNo1 % inputNo2;
            Console.WriteLine("The reminder is: " + returnReminder);


        }
    }
}
