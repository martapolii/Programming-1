namespace Question01
{
    using System;

    class Program
    {
        static void Main()
        {
            /*Question01: Create a program that prompts the user for her first name, middle initial and last name.
            The program will display the user name three times using the following three formats:
                first name and last name
                first name middle initial and last name
                last name, first name and middle initial 
            */

            //Declare variables
            string firstName;
            char middleInitial;
            string lastName;


            // Prompting user for input
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your middle initial: ");
            middleInitial = char.Parse(Console.ReadLine());

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            // Displaying user's name using different formats
            Console.WriteLine($"1. {firstName} {lastName}");
            Console.WriteLine($"2. {firstName} {middleInitial} {lastName}");
            Console.WriteLine($"3. {lastName}, {firstName} {middleInitial}");
        }
    }
}
