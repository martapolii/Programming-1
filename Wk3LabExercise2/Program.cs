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
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your Social Insurance Number: ");
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
            Console.WriteLine("\n");

            Console.WriteLine("Gross Pay:                      $" + grossPay);
            Console.WriteLine("Federal Tax:                    $" + federalTax);
            Console.WriteLine("Provincial Tax:                 $" + provincialTax);
            Console.WriteLine(String.Format("--------------------------------------"));
            Console.WriteLine("\n");
            Console.WriteLine("Net Pay:                        $" + netPay);


            /* Last chunk of code wouldn't generate the table I wanted so I emailed the prof, and he offered these two solutions: 
             * (neither worked - either terminal crashed after entering values or error popped up).
             * 
            *Console.WriteLine($"Gross Pay:{grossPay,8:C}");
            *Console.WriteLine($"Federal Tax:{federalTax,8:C}");
            *Console.WriteLine($"Provincial Tax:{provincialTax,8:C}");
            *Console.WriteLine("\n");
            *Console.WriteLine("Net Pay:{8:C}",netPay);
            *
            *Console.WriteLine("Gross Pay:{0,8:C}", grossPay);
            *Console.WriteLine("Federal Tax:{0,8:C}", federalTax);
            *Console.WriteLine("Provincial Tax:{0,8:C}", provincialTax);
            *Console.WriteLine("\n");
            *Console.WriteLine("Net Pay:{0,8:C}", netPay); 
            *
             */







        }
    }
}
