namespace A2Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question02:
             * Write a program to ask the user about the validity of a simple statement. The program should accept the response then display the statement as well as the response. The response should be true or false. For this question, you must use a variable of type bool. It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.
             * 
             * (Use the Convert.ToBoolean() method to obtain a bool from an input.)
             */


            //1. Declare Variables.
            bool answer;

            //2. Collect Inputs.
            Console.WriteLine("Is the below statement valid?");
            Console.WriteLine("The sky is green.");
            Console.WriteLine("Please enter 'true' or 'false' as your answer");
            answer = Convert.ToBoolean(Console.ReadLine());

            //3. Display Results.
            Console.WriteLine($"You believe that the statement 'The sky is green' is {answer}."); 







        }
    }
}
