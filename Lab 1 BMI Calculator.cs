using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************************************************************************************************************************
Authors : Mathew Ricketts, Micheal Ciani
Date : September 24th 2016

Purpose : To calculate the BMI using the height and weight entered by the users
**********************************************************************************************************************************************************************************/

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations:
            
            //personsHeight as a double variable
            double personsHeight;

            //personsWeight as a double variable
            double personsWeight;
            
            //personsBmi as a double varible
            double personsBmi;
            
            //MULITIPLIER as a constant set to 703
            const int MULTIPLIER = 703;

            //Input:
            
            //Display message: "Please enter the persons height in inches"
            Console.WriteLine("Please enter the persons height in inches");
            
            //Store input in personsHeight variable
            personsHeight = Convert.ToDouble(Console.ReadLine());
            
            //Display message: "Please enter the persons weight in pounds"
            Console.WriteLine("Please enter the persons weight in pounds");
            
            //Store input in personsWeight variable
            personsWeight = Convert.ToDouble(Console.ReadLine());

            //Process:
            
            //Calculate the persons BMI using this formula
            personsBmi = (personsWeight / Math.Pow(personsHeight, 2)) * MULTIPLIER;
            personsBmi = Math.Round(personsBmi, 2);

            //Output:
            
            //Display the message "The BMI for a person who is " personsHeight " tall and weighs " personsWeight " equals " personsBmi
            Console.Write("The BMI for a person who is " + personsHeight + " inches tall and weighs " + personsWeight + " pounds equals " + personsBmi);
            
            //Display the message "Enter any key to exit"
            Console.WriteLine("\nEnter any key to exit");
            Console.ReadKey();
        }
    }
}
