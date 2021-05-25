using System;
using System.Collections.Generic;
using System.Text;
using DiscountPolicies;

namespace AccessModifiers
{
    public class LoyaltyDiscountPolicy : DiscountPolicy
    {
        public void CalculateLoyaltyDiscount(Investor investor )
        {
            double investorDiscount = GetDiscount(investor.InvestorType);
            Console.WriteLine(investorDiscount);
        }
    }
}
