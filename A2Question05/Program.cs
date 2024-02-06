namespace A2Question05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Question05: 
              Adult tickets cost $3.75 and child tickets cost $2.25. Write a program to prompt the user for the amount of adult and child tickets that she needs. The program will display a user-friendly message of the number of tickets bought as well as the total cost. (Use the "C" format-string for currency).
             */

            //1.Declare Variables.
            int adult;
            int child;

            double adultCost;
            double childCost;

            double totalCost;
            int ticketsBought;


            //2. Collect Inputs.
            Console.WriteLine("Enter the number of adult tickets you wish to purchase: ");
            adult = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of child tickets you wish to purchase: ");
            child = int.Parse(Console.ReadLine());

            //3. Algorithm.
            adultCost = adult * 3.75;
            childCost = child * 2.25;
            totalCost = adultCost + childCost;
            ticketsBought = adult + child;

            //4. Display Results. 
            Console.WriteLine($"You have purchased {adult} adult tickets and {child} child tickets.");
            Console.WriteLine($"The total cost is {totalCost:C}"); 

        }
    }
}
