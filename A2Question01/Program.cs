namespace A2Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question01: 
             * Write a program to prompt the user to enter a single character. The program should display a message like “Your response was y”. For this question, you must use a variable of type char.
             * (Use the Convert.ToChar() method to obtain a char from an input.)
             */

            //1. Declare variables.
            char character;

            //2. Collect Inputs.
            Console.WriteLine("Please enter a single character: ");
            character = Convert.ToChar(Console.ReadLine());

            //4. Display Results. 
            Console.WriteLine($"Your response was {character}.");




           




        }
    }
}
