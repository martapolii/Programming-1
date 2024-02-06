using System;

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
			/*  WEEK 5
			 
			Write a console application that prompts the user to input the current ambient temperature.
			
			If the temperature is lower than 15, display a message "Too cold!".
			If the temperature is between 15 and 25, display a message "Perfect!".
			If the temperature is greater than 25, display a message "Too hot!".
			 
			*/

			//1. Declare Variables
			double temperature;


			//2. Collect Input
			Console.WriteLine("Please input the current amient temperature:");
			temperature = double.Parse(Console.ReadLine());


			if (temperature < 15)
			{
				//too cold
				Console.WriteLine("Too cold!");
			}
            else if (temperature is >= 15 && temperature <= 25)
            {
				// perfect   
				Console.WriteLine("perfect!");
            }
			else 
			{
				//too hot
				Console.WriteLine("Too hot!");
			}








        }
}