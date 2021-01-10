using System;

namespace var
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize a variable
            string myName ;
            int myAge;
            
            // assign a value to the vars
            Console.Write("What is your name?: ");
            myName = Console.ReadLine();

            Console.WriteLine("How old are you?: ");
            myAge = int.Parse(Console.ReadLine());

            //Console.Write("Input your password \nmake sure its alphanumeric : ");
            //myPassword = Console.ReadLine();

            Console.WriteLine("Your are welcome " + myName + " your password is " + myName + myAge);
            
            //Console.WriteLine("Your are welcome " + myName + "we believe you are " + myAge "years old and your password code is " + myPassword);
        }
    }
}
