namespace Example02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DATA TYPES:

            // TEXT: 
            string text; // Declaring a variable. <- needs to be done to store info [data type, identifier]
            // this is the syntax for declaring a variable that can hold text
            // telling the program we need space in the cp's memory to store info (a piece of text = string)
            // STRING USES " " DOUBLE QUOTES

            char letter; // char = character. 'letter' - to store a single letter 
            // ^ this is declaring a varible again. declaring data type and variable identifier 
            // CHAR USES ' ' SINGLE QUOTES

                 // INITIALIZING/ASSIGNING VARIBLES: 
                 string text;
                 text = "This is a text"; // <- intiliazing (/assigning a value to) a variable 
                 // STRING uses " " *double quotes*

                 char letter = 'a'; // <- initializing
                 // CHAR uses ' ' *single quotes*

                 //ERRORS
                 char letter = "a"; // <- underlined in red. hover over it to see error & click error code for documentation
        }
    }         // NUMBERS:
              int number = 5; // int = integers only. positive and negative

    double floatingPointNumber = 3.14; // for numbers with decimals (or integers, capable of storing both)
                                       // positive and negative
                                       // Camel Casing

    // BOOLEANS: 
    bool trueOrFalse = false; // binary system. only true or false
              bool trueOrFalse = true;
              
}
