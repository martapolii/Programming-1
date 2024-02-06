namespace Example08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // COMPARISON OPERATORS:
            // Perform comparisons between two values (operands).
            // Such comparisons can be called Boolean expressions, as they return true or false.

            // OPERATORS:
            // Less than: <
            // Less than or equal to: <=
            // Greater than: >
            // Greater than or equal to: >=
            // Equals: ==
            // Different (Not equal): !=

            // Example: 3 > 5 = False. BOOLEAN EXPRESSIONS = use operators to verify whether an expression is true or false
            // Example: 3 < 5 = True.

            // Verifying if 3 is less than 5.
            bool result = 3 < 5;
            Console.WriteLine(result); // true

            // Verifying if 3 is greater than 5.
            result = 3 > 5;
            Console.WriteLine(result); // false




            // Comparisons can be made between any data types.


            result = "true" == "True"; // False.
            Console.WriteLine(result);

            // We need to be careful when comparing strings.
            result = "TrUe".ToUpper() == "tRuE".ToUpper();
            Console.WriteLine(result);

            // We can also compare chars.
            result = 'a' != 'A';
            Console.WriteLine(result); // false

           Console.WriteLine((int)'a'); //converting a to integer. = 97
           Console.WriteLine((int)'A'); // = 65
                                         // ^ WHY? bc computers are binary systems. so alphabet characters represent numbers.
                                         // all info in computer systems = bites of bits ( 0 & 1's strung together) 

            


        }
    }
}
