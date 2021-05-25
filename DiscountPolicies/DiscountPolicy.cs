using System;

namespace DiscountPolicies
{
    public class DiscountPolicy
    {
        protected internal static double GetDiscount(int customerType)
        {
            switch(customerType)
            {
                case 1:
                    return double.MinValue;
                   
                case 2:
                    return double.MaxValue;
                    
                default:
                    return 0.00;
                    
            }
        }
    }
}
