using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxReport
{
    class Program
    {
        static void Main(string[] args)
        {
            const double stateSalesTax = .04;
            const double countySalesTax = .02;
            Console.WriteLine("Please enter your total sales from the desired month");
            double ttlSales;
            //double.TryParse(Console.ReadLine(), out ttlSales);
            ttlSales = double.Parse(Console.ReadLine());

            double countySalesTaxes = CalcTaxes(ttlSales, countySalesTax);
            double stateSalesTaxes = CalcTaxes(ttlSales, stateSalesTax);
            double TotalSalesTax = CalcTotal(countySalesTaxes, stateSalesTaxes);
            Console.WriteLine($"Your county sales tax amount is     {countySalesTaxes:c} ");
            Console.WriteLine("Your state sales tax amount is            " + stateSalesTaxes);
            Console.WriteLine("Your total sales tax for the month is     " + TotalSalesTax);
            Console.ReadLine();
            Console.ReadLine();

            //TaxProduct taxresults = new TaxProduct();
            //{
            //    TaxProduct.countystateSales();
            //}
        }

        static double CalcTaxes(double revenue, double taxRate)
        {
            return (revenue * taxRate);
        }
        static double CalcTotal(double StateTaxResults, double CountyTaxResults)
        {
            return (StateTaxResults + CountyTaxResults);
        }
    }
}
