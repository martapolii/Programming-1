namespace Wk2Question04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question04: Write a program that prompts the user for the number of siblings his has. The program
should display a message, “I have 4 siblings” (assuming that the user enters 3). This
question is not the same as question 2.*/

            //1. Declare variables
            int siblings;

            int siblingsPlusOne;

            //2. Collect Inputs
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            //3. Arithmetic
            siblingsPlusOne = siblings + 1;


            //4. Output
            Console.WriteLine($"I have {siblingsPlusOne}."); 










        }
    }
}
