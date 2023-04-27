using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    internal class Program
    {
        static void Main(string[] args)
            /*What is needed
             enter details for a single recipe
            --> number of ingredients
            --> Name, quantity and unit of measurement for each ingredient. eg: one table spoon of sugar
            --> Number of steps in each recipe
            --> A description of what the user should do in each step.
            --> Display the full recipe including ingredients and steps.
            --> Tgbh
             */
            
        {
            Console.WriteLine("Please enter the number of ingredients.");
            int IngredientNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the name of the ingredient.");
            string IngredientName = Console.ReadLine();

            Console.WriteLine("Please enter the quantity of these ingredients");
            int IngredientQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the unit of measurement used for this ingredient.");
            string Measurement = Console.ReadLine();    


        }
    }
}
