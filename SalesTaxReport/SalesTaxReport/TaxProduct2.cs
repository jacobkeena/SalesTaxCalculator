using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxReport
{
    class TaxProduct2
    {
        static public double userResponse()
        {
            Console.WriteLine("Please enter your total sales from the desired month");
            double userInput;
            double.TryParse(Console.ReadLine(), out userInput);
            double userResponse = userInput;
            return userInput;
        }
         double CalcTaxes(double revenue, double taxRate)
        {
            return (revenue * taxRate);
        }


        static public double countySales(double userInput)
            {
                double countyTaxRate = 0.02;
                double countyResults = countyTaxRate * userInput;
                return countyResults;
            }
            static public double stateSales(double userInput)
            {
                double stateTaxRate = 0.04;
                double stateResults = stateTaxRate * userInput;
                return stateResults;

            }
            static public double totalSalesTax(double stateResults, double countyResults)
            {
                double totalsalestax = countyResults + stateResults;
                return totalsalestax;

            }
    }
}
