namespace Example04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MATHEMATICAL OPERATIONS:
            double number = 5.1;
            double anotherNumber = 2.25;
            double total;

            // Addition:
            total = number + anotherNumber;
            Console.WriteLine("The sum is: " + total); // <-- Concatenation. 2 values put together in sequence. NOT A MATHEMATICAL OPERATION. 

            // Subtraction:
            total = number - anotherNumber;
            Console.WriteLine("The subtraction is: " + total); // <-- Concatenation

            // Multiplication:
            total = number * anotherNumber;
            Console.WriteLine("The multiplication is: " +total); // <--Concatenation 

            // Division:
            total = number / anotherNumber;
            Console.WriteLine("The division is: " + total); // <-- Concatenation

            // Modulo/Modulus:
            total = 15 % 4;    // % = modulo 
            Console.WriteLine("The remainder is:" + total); // Gives you the remainder of division. 



            // WARNING: Integer Division

            total = 15 / 4 * 3;  // Answer should be 11.25 but C# runs 9. Why? BECAUSE INTEGERS DON'T DO DECIMALS 
            Console.WriteLine(total);
            // When you get a floating point data C# discards/truncates the decimal. Need to convert an integer to a double before dividing: 
            /* Casting: */  total = (double)15 / 4 * 3;
                          Console.WriteLine(total);


            





        }
    }
}
