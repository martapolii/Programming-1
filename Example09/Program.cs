namespace Example09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BOOLEAN EXPRESSIONS = use operators to verify whether an expression is true or false

            // COMPOUND BOOLEAN EXPRESSIONS:
            // We can use Boolean operators to combine two or more Boolean expressions.

            // OPERATORS:
            // And: &&
            // Or: ||
            // Not: !


                //AND &&
                bool result = (3 < 5) && (1 < 0); // true + false = false
                Console.WriteLine(result); 

                bool result = (3 < 5) && (1 > 0);
                 Console.WriteLine(result); // false


                 //OR ||
                result = (3 < 5) || (0 > 10);
                 Console.WriteLine(result); // = true. bc atleast one side is true. 

                result = (3 < 5) || (0 > 10);
                Console.WriteLine(result); // = false. bc both sides are false.


                //NOT !
                // Inverts the input. 
                result = !(3 < 5);
                Console.WriteLine(result); // FALSE bc '!" inverts the answer.


            // OPERATOR PRECEDENCE:
            // And (&&) operators are solved first UNLESS we have brackets
            // Expressions are evaluated left to right.

            result = 3 < 5 && 1 < 0 || 3 != 5 && 0 == 0;
            Console.WriteLine(result); // True. 

            // OPERATOR PRECEDENCE:
            // And (&&) operators are solved first.
            // Expressions are evaluated left to right.

            result = 3 < 5 && 1 < 0 || 3 != 5 && 0 == 0; // (3 < 5 && 1 < 0) || (3 != 5 && 0 == 0) = True.
            Console.WriteLine(result);
        }
    }
}
