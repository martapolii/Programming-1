using System;

class Program
{
    static void Main()
    {
        // Prompting user for input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Social Insurance Number: ");
        string sin = Console.ReadLine();

        Console.Write("Hourly pay rate: ");
        double hourlyPayRate = double.Parse(Console.ReadLine());

        Console.Write("Hours worked: ");
        double hoursWorked = double.Parse(Console.ReadLine());

        // Calculating payroll details
        double grossPay = hourlyPayRate * hoursWorked;
        double federalTax = 0.15 * grossPay;
        double provincialTax = 0.10 * grossPay;
        double netPay = grossPay - federalTax - provincialTax;

        // Displaying the payroll summary
        Console.WriteLine("\nPayroll Summary for " + name);
        Console.WriteLine("SIN: " + sin);
        Console.WriteLine("You worked {0} hours at ${1:F2} per hour", hoursWorked, hourlyPayRate);
        Console.WriteLine("Gross pay: {0,8:C}", grossPay);
        Console.WriteLine("Federal Tax: {0,8:C}", federalTax);
        Console.WriteLine("Provincial Tax: {0,8:C}", provincialTax);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Net pay: {0,8:C}", netPay);

     // This is ChatGPT's answer. Still not displaying as a table. 
    }
}
