namespace A2Question06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question06: 
             	Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the user for the current flowing and the resistance of the wire. Potential difference is the product of the current and the resistance of the wire and may include a fractional part. (Again, use the "F" format-specifier for floating point values).
             */

            //1.Declare Variables.
            double current;
            double resistance;

            double potentialDifference;

            //2. Collect Inputs.
            Console.WriteLine("To calculate the potential difference between the ends of your wire, please enter:");
            Console.WriteLine("The current flowing through the wire: ");
            current = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("The resistance of the wire: ");
            resistance = Convert.ToDouble(Console.ReadLine());

            //3. Algorithm.
            potentialDifference = current * resistance;

            //4. Display Results. 
            Console.WriteLine($"The potential difference between the ends of your wire is: {potentialDifference:F}");

        }
    }
}
