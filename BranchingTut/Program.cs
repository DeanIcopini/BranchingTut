using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingTut
{
    class Program
    {
        static void Main()
        {
            // first line 
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // The user must be prompted for the package weight.
            Console.WriteLine("What is the weight of the package you would like to send?");
            string packageWeightInput = Console.ReadLine();
            double packageWeight = Convert.ToDouble(packageWeightInput);


            // If the weight is greater than 50, display the error message, "Package too heavy to be shipped via Package Express. Have a good day."
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            // The user must then be prompted for the package width.
            Console.WriteLine("What is the width of the package?");
            string packageWidthInput = Console.ReadLine();
            double packageWidth = Convert.ToDouble(packageWidthInput);

            // Then the package height.
            Console.WriteLine("What is the height of the package?");
            string packageHeightInput = Console.ReadLine();
            double packageHeight = Convert.ToDouble(packageHeightInput);

            // Then the package length.
            Console.WriteLine("What is the lenght of the package?");
            string packageLengthInput = Console.ReadLine();
            double packageLength = Convert.ToDouble(packageLengthInput);

            // If the dimensions total greater than 50, display the error message, "Package too big to be shipped via Package Express." end program
            double totalDimensions = packageWidth * packageHeight * packageLength;
            // The total dimensions are then multiplied by the weight and then divided by 100.
            double quoteCalculation = totalDimensions * packageWeight / 100.0;
            decimal quoteAmount = Convert.ToDecimal(quoteCalculation);
            quoteAmount = Math.Round(quoteAmount, 2);
            

            if (totalDimensions > 50.0)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            // The result of the calculation is the quote.
            // Display the quote to the user as a dollar amount.
            else if (totalDimensions < 50.0)
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quoteAmount  + "\nThank you." );
            }

            Console.Read();

        }
    }
}
