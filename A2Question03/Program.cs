namespace A2Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question03: 
             Write a program to calculate the area of a circle. The user will enter the radius of the circle and the program will calculate and display the area according to the formula (area = 3.14 * radius * radius). You must accept fractions as the input. If the user enters 1.2 for the radius then the area will be 4.52. (Use the "F" format-specifier for floating point values).

            (Use the Convert.ToDouble() method to obtain a double from an input)
             */


            //1.Declare Variables.
            double radius;
            double area;

            //2. Collect Inputs.
            Console.WriteLine("Please enter the radius of the circle to calculate its area: ");
            radius = Convert.ToDouble(Console.ReadLine());

            //3. Algorithm.
            area = 3.14 * radius * radius;

            //4. Display Results. 
            Console.WriteLine($"The area of a circle with a {radius} is {area:F}.");

        }
    }
}
