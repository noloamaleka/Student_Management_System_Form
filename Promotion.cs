using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_Project
{
    internal class Promotion
    {
        const int MinAge = 25;
        const double FemaleDiscount = 0.7, MaleDiscount = 0.81;

        public double DiscountPercentage(int age, string gender)
        {
            if (age > MinAge)
            {
                if (gender.ToLower() == "female")
                {
                    
                    return FemaleDiscount;
                }
                else if (gender.ToLower() == "male")
                {
                    return MaleDiscount;
                }
            }
            return 1;   
        }
       
        
    }
}
