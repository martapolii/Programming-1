namespace A2Question04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question04: 
             Write a program that prompts the user for a number (that may be a fraction). The program reads in the input and prints the following: the input as a double, the input as an int and finally the input as a char.
                e.g. if the input is 65.790, then the output will be 65.790, 65, and A.
             */

            //1.Declare Variables.
            double number;
            int integerValue;
            char charValue; 
          

            //2. Collect Inputs.
            Console.WriteLine("Please enter a rational number: ");
            number = Convert.ToDouble(Console.ReadLine());
           

            //3. Algorithm.
            //CASTING
            integerValue = (int)number;
            charValue = (char)number;



            //4. Display Results. 
            Console.WriteLine($"{number}, {integerValue}, and {charValue}.");


        }
    }
}
