using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountPolicies
{
    public class DiscountCalculator
    {
        private protected double CalculateDiscountForCustomer(Customer customer)
        {
            double discount = DiscountPolicy.GetDiscount(customer.CustomerType);
            Console.WriteLine(discount);
            Console.WriteLine($"{customer.CustomerName} has a {discount} discount");
            return discount;
        }
    }
}
