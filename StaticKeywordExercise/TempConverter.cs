using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    static public class TempConverter
    {
        static public double FahrenheitToCelcius(double fTemp)
        {
            return (fTemp - 32) * 5/9;
        }

        static public double CelciusToFahrenheit(double cTemp)
        {
            return cTemp * 9/5 + 32;
        }
    }
}
