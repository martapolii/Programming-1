namespace Wk3LabExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.	Write a program that declares four variables to hold the number of eggs produced in a month by each of four hens. Your program should sum the eggs, and then display the total in dozens. For example, a total of 127 eggs is 10 dozens and 7 eggs.
              */

            //Input: henOne, henTwo, henThree, henFour
            //Output:total
            /* Processing: totalEggNumber, dozensOfEggs
             * 1. Collect values for henOne, henTwo, henThree, henFour
             * 2. Store the inputs for henOne, henTwo, henThree, henFour
             * 3. Calculate totalEggNumber and divide by 12 to get dozensOfEggs.
             * 4. State dozensOfEggs. 
             * 5. State the remainder as x eggsRemaining. 
             * 6. Print total to console.
             */

            //STEP 01: Declare variables. 
            int henOne;
            int henTwo;
            int henThree;
            int henFour;

            int totalEggNumber;
            int dozensOfEggs;
            int eggsRemaining;

            //STEP 02: Collect Inputs.

            Console.WriteLine("Please provide the number of eggs produced by each hen this month:");

            Console.WriteLine("Enter the amount of eggs produced by hen one: ");
            henOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of eggs produced by hen two: ");
            henTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of eggs produced by hen three: ");
            henThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of eggs produced by hen four: ");
            henFour = Convert.ToInt32(Console.ReadLine());

            //STEP 03: Algorithm.
            totalEggNumber = henOne + henTwo + henThree + henFour;
            dozensOfEggs = totalEggNumber / 12;
            eggsRemaining = totalEggNumber % 12;

            //STEP 04: Display Result 
            Console.WriteLine("The total number of eggs produced this month by the four hens is " + dozensOfEggs + " dozens and " + eggsRemaining + " eggs");







        }
    }
}
