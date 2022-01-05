using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class DietFactory
    {
        
        public static IDietBase Give_Diat_Now(int Age, double Weight, double Height)
        {
            double BMI = Weight / Math.Pow(Height, 2);
            
                if (Age >= 30 && (BMI >= 22 && BMI < 28.9))
                {
                    return new Paleo_Diet();
                }
                else if (Age >= 40 && (BMI >= 28.9 && BMI < 37.4))
                {
                    return new Etkines_Diet();
                }
                else if (Age >= 50 && BMI >= 37.4)
                {
                    return new Vegetarian__Diet();
                }
                return new NoDiet();
            
            
        }
    }
}
