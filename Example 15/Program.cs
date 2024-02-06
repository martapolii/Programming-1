namespace Example_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//WEEK 5

			/*
			 
			Write a console app that prompts the user to input the planet they came from.
			
			If the input is "Earth", display a message "You are an earthling.".
			If the input is "Mars", display a message "You are a martian.".
			If the input is "Jupiter", display a message "You are a jupiterian.".
			For any unspecified planets, display a message "I do not know that planet.".
			
			*/

			//1. Declare variables & collect inputs

			Console.WriteLine("What planet did you come from?");
			string planet = Console.ReadLine();

			//2. Switch statements


			switch (planet.ToUpper())
			{
				case "EARTH":
					Console.WriteLine("You are an earthling.");
					break;

				case "MARS":
					Console.WriteLine("You are a martain.");
					break;

				case "JUPITER":
					Console.WriteLine("You are a jupiterian.");
					break;

				default:
					Console.WriteLine("I donot know that planet.");
					break;

			}















        }
    }
}
