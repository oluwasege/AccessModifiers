using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountPolicies
{
    public class YearlyDiscountCalculator :DiscountCalculator
    {
        public double CalculateYearlyDiscount(int totalNumberOfYears,Customer customer)
        {
            double discount=0.00;
            for(int currentYear=1;currentYear<=totalNumberOfYears;currentYear++)
            {
                discount += CalculateDiscountForCustomer(customer);
            }

            return discount;
        }
    }
}
