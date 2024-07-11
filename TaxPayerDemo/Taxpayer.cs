using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Taxpayer
    {
        private string socialSecurityNumber;
        private double yearlyGrossIncome;
        private double taxOwed;
        private static double totalTaxAmt = 0;

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }

        public double YearlyGrossIncome
        {
            get { return yearlyGrossIncome; }
            set
            {
                yearlyGrossIncome = value;
                CalculateTax();
            }
        }

        public double TaxOwed
        {
            get { return taxOwed; }
        }

        public static double TotalTaxAmt
        {
            get { return totalTaxAmt; }
        }

        private void CalculateTax()
        {
            if (yearlyGrossIncome < 30000)
                taxOwed = yearlyGrossIncome * 0.15;
            else
                taxOwed = yearlyGrossIncome * 0.28;

            totalTaxAmt += taxOwed;
        }
    }
}
