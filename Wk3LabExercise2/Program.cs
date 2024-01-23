namespace Wk3LabExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STEP 01: Declare all variables:
            string name;
            string socialInsuranceNumber;
            double hourlyPayRate;
            double numberOfHoursWorked;

            double grossPay;
            double federalTax;
            double provincialTax;
            double netPay;

            //STEP 02: Collect Inputs
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Social Insurance Number: ");
            socialInsuranceNumber = Console.ReadLine();

            Console.WriteLine("Enter your hourly pay: ");
            hourlyPayRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of hours worked: " );
            numberOfHoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");


            //STEP 03: Algorithm
            grossPay = hourlyPayRate * numberOfHoursWorked;
            federalTax = grossPay * 0.15;
            provincialTax = grossPay * 0.10;
            netPay = grossPay - federalTax - provincialTax;


            //STEP 04: Display Results
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Social Insurance Number: " + socialInsuranceNumber);
            Console.WriteLine("Hourly pay rate: " + hourlyPayRate);
            Console.WriteLine("Hours worked: " + numberOfHoursWorked + "\n");

            Console.WriteLine("Payroll Summary for " + name);
            Console.WriteLine("SIN: " + socialInsuranceNumber);
            Console.WriteLine("You worked " + numberOfHoursWorked + " hours at $" + hourlyPayRate + " per hour" + "\n");

            Console.WriteLine("Gross pay: $" + grossPay);
            Console.WriteLine("Federal Tax: $" + federalTax);
            Console.WriteLine("Provincial Tax: $" + provincialTax + "\n");
            Console.WriteLine("Net Pay: $" + netPay);
             







        }
    }
}
