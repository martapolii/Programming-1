using System.Runtime.ConstrainedExecution;
using System;
using System.Transactions;

namespace Example05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          
            Q: Write a console application that performs a mathematical operation of your choice between two user-provided numbers. 

            (Always display the result even if the exercise tells you not to. (Why would you use something that never displays the result?))

            How to Solve:
             Learn how to structure the problem logically. (Define a strategy/algorithm that goes from point A -> point B). 
               Tools to use: IPO chart. (see OneNote notes).
                            - tool used to identify what the inputs are for the problem and what the expected outputs would be. 
                            - point A = inputs. point B = outputs. 

            STEP 01: Declaring variables.
            STEP 02: Collecting Inputs.
            STEP 03: Algorithm.
            STEP 04: Displaying Results.

            */

            // =====================================================================================
            // |     INPUT      |                   PROCESSING                    |     OUTPUT     |
            // |================|=================================================|================|
            // |                |                                                 |                |  
            // | firstNumber    | 1. Collect value for firstNumber                | total          |  
            // | secondNumber   | 2. Store input in firstNumber                   |                |  
            // |                | 3. Collect value for secondNumber               |                |  
            // |                | 4. Store input in secondNumber                  |                |  
            // |                | 5. Calculate total per formula:                 |                |  
            // |                |    total = firstNumber * secondNumber           |                |  
            // |                | 6. Print total to console                       |                |  
            // |                |                                                 |                |  
            // |                |                                                 |                |  
            // =====================================================================================


            //STEP 01: Declaring variables. (use double bc it can handle more and variable type wasn't specified)
            double firstNumber;
            double secondNumber;
            double total;

            //STEP 02: Collecting Inputs. (Asking user to provide the inputs)
            //Use WriteLine to output instructions to console. ReadLine reads inputs and stores it in a variable.
            Console.WriteLine("Please provide two numbers to multiply.");

            Console.WriteLine("Enter the first number: ");
           // error: firstNumber = Console.ReadLine();  <-- have a data type mismatch error bc ALL INPUTS PROVIDED VIA CONSOLE ARE STRINGSSS!!!!!!!!!
            firstNumber = double.Parse(Console.ReadLine());
            // or use this method to fix error: firstNumber = Convert.ToDouble(Console.ReadLine());\

            Console.WriteLine("Enter the second number: ");
            secondNumber = double.Parse(Console.ReadLine());    

            // STEP 3
            total = firstNumber * secondNumber;

            //STEP 04:
            Console.WriteLine("The result is: " + total); 


















        }
    }
}
