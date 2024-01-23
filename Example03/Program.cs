namespace Example03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPE CONVERSION: 

            // want to convert from data type A -> B

            char letter = "a";   // <- gives error because " " used for strings = DATA TYPE MISMATCH ERROR- char on left, string on right
            char letter = 'a';   // <- char on left and right

            //the line below gives an error:
            char latter = "a";
            // can't fix this by changing to single quotes because you won't typically have access to source code
            // want to teach computer how to perform a conversion 

            // STRING -> CHAR 

                 //1. The Convert Class:
                       char letter = "a";
                 char letter = Convert.ToChar("a");

                //2. The Parse method: 
                 letter = char.Parse("a");

               // can use these methods to convert between any two data types. Ex: 
                int number = "5";
                int number = Convert.ToInt32(letter"5"); //diff variable types will reserve diff amounts of memory for the program to run, 1 byte = 8 bits
                                                         // 32 bits = amount of space to store this data: "5"
                number = int.Parse("5");

            //IRL ALL INFO PROVIDED BY USER VIA CONSOLE COMES INTO PROGRAM AS A STRING. That's why we can't alter the code by hand.


            // CHAR -> STRING
             string text = 5; //error bc data type mismatch. 

               //1. The Convert Class
                     string text = Convert.ToString(5);

               //1. ToString method.  (All objcets in c# have this method)
                     text = 5.ToString();

            //IMPLICIT CONVERSION
            double anotherNumber = 5; //have integer on right and double on left = data ttype mismatch with no errors = implicit conversion
            //C# can convert integers to doubles - adds a .0      ( ex: 5 = 5.0 )


            //Line below throws an error.
            int oneMoreNumber = 1.9; //can't round on it's own = ambiguity
            // DOUBLE -> INT
                 //1. Convert class
                 int oneMoreNumber = Convert.ToInt32(1.9);
                  Console.WriteLine(oneMoreNumber);
            //Is Convert.ToInt32 rounding up, or rounding to the nearest integer? 



            //CASTING: let's you convert b/w two ANY two data types that are not strings. 
            oneMoreNumber = 1.9; //preceed the value with the destination datatype surrounded by paranthesis 
            oneMoreNumber = (int)1.9; // =  implicit casting. ROUNDS DOWN

            //Is casting rounding down, or truncating the value?


            /*Have to be careful when performing conversions because you are LOSING PRECISION. 
             *Ex: Won't matter for a first person shooter, but would mattter for a bank doing millions of calculations a day.
             *Losing precision important for when dealing with mathematical operations in code. 
            */

            /* Q: What's the difference between decimals and double?
             * A: How many bytes the computer will reserve in it's memory. Decimal variable is 2x as big as double variable.  
             *    Can work with much larger and more preciswe numbers when working with decimal type. (Financial systems use decimals bc more precision).*/





        }
    }
