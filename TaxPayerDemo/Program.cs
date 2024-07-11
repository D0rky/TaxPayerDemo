using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of taxpayers: ");
            int numTaxpayers = int.Parse(Console.ReadLine());

            Taxpayer[] taxpayers = new Taxpayer[numTaxpayers];

            for (int i = 0; i < numTaxpayers; i++)
            {
                Console.WriteLine($"\nEnter data for taxpayer {i + 1}");
                Console.Write("Social Security Number: ");
                string ssn = Console.ReadLine();
                Console.Write("Yearly Gross Income: ");
                double income = double.Parse(Console.ReadLine());

                taxpayers[i] = new Taxpayer
                {
                    SocialSecurityNumber = ssn,
                    YearlyGrossIncome = income
                };
            }

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Taxpayer Data");
                Console.WriteLine("2. Display Total Tax Amount");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayTaxpayerData(taxpayers);
                        break;

                    case 2:
                        Console.WriteLine("Total Tax Amount: $" + Taxpayer.TotalTaxAmt);
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayTaxpayerData(Taxpayer[] taxpayers)
        {
            Console.WriteLine("\nTaxpayer Data:");
            foreach (var taxpayer in taxpayers)
            {
                Console.WriteLine($"SSN: {taxpayer.SocialSecurityNumber}, Tax Owed: ${taxpayer.TaxOwed}");
            }
        }
    }
}