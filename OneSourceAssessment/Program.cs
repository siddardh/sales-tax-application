using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneSourceAssessment.Business;

namespace OneSourceAssessment
{
    class Program
    {
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            var myBooks = new Book(12.49m, false);
            var myMusicCDs = new MusicCd(14.99m, false);
            var myChocolateBars = new ChocolateBar(0.85m, false);
            PrintProducts(myBooks, myMusicCDs, myChocolateBars);
            PrintBlankLines();

            var importedChocolateBox = new ChocolateBox(10.00m, true);
            var importedPerfume = new Perfume(47.50m, true);
            PrintProducts(importedChocolateBox, importedPerfume);
            PrintBlankLines();
            
            var anotherImportedPerfume = new Perfume(27.99m, true);
            var myPerfume = new Perfume(18.99m, false);
            var myHeadachePilles = new HeadachePills(9.75m, false);
            var anotherImportedChocolateBox = new ChocolateBox(11.25m, true);
            PrintProducts(anotherImportedPerfume, myPerfume, myHeadachePilles, anotherImportedChocolateBox);
            PrintBlankLines();


            Console.Read();

        }

		/// <summary>
		/// Prints the products.
		/// </summary>
		/// <param name="myProducts">My products.</param>
        public static void PrintProducts(params Product[] myProducts)
        {
            var totalTaxAmount = 0m;
            var totalAmount = 0m;
            foreach (var myProduct in myProducts)
            {
                Console.WriteLine(myProduct);
                totalTaxAmount += myProduct.GetTaxAmount();
                totalAmount += myProduct.PriceWithTaxes;
            }
            Console.WriteLine("Sales Taxes: {0}", totalTaxAmount);
            Console.WriteLine("Total: {0}", totalAmount);
        }

		/// <summary>
		/// Prints the blank lines.
		/// </summary>
        public static void PrintBlankLines()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
