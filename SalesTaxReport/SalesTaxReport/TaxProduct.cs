using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxReport
{
    public class TaxProduct
    {
        double countyTaxRate;
        double stateTaxRate;
        double countyResults;
        double stateResults;
       


        static public void countystateSales()
        {
            Console.WriteLine("Please enter your total sales from the desired month");
            double userInput;
            double.TryParse(Console.ReadLine(), out userInput);
            double countyTaxRate = 0.02;
            double countyResults = countyTaxRate * userInput;
            double stateTaxRate = 0.04;
            double stateResults = stateTaxRate * userInput;
            double totalsalestax = countyResults + stateResults;
            Console.WriteLine("Your county sales tax amount is           " + countyResults);
            Console.WriteLine("Your state sales tax amount is            " + stateResults);
            Console.WriteLine("Your total sales tax for the month is     " + totalsalestax);
            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
