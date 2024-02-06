namespace Wk2Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question02: Write a program that prompts the user for the number
                            of siblings his has. The program should display a
                            message, “I also have 4 siblings” (assuming that the
                            user enters 4)*/

            //1. declare variables.

            string siblings;

            //1.Take inputs

            Console.WriteLine("How many siblings do you have? ");
            siblings = Console.ReadLine();

            //2. Display output
            Console.WriteLine($"I also have {siblings} sibling(s).");
        }
    }
}
