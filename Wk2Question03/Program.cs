namespace Wk2Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question03: Write a program that prompts the user for two integers. 
             * The program will display the result of summing and finding the difference. 
             * (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5)*/

            //1. Declare variables:
            int integerOne;
            int integerTwo;
            int sum;
            int difference;


            //2. take inputs.
            Console.WriteLine("Please enter an integer value:  ");
            integerOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second integer value: ");
            integerTwo = Convert.ToInt32(Console.ReadLine());

            //3. Arithmetic 
            sum = integerOne + integerTwo;
            difference = integerOne - integerTwo;

            //4. Display outputs
            Console.WriteLine($"{integerOne} + {integerTwo} = {sum} and {integerOne} - {integerTwo} = {difference}");




        }
    }
}
