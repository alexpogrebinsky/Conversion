using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion.Business
{
    public class Methods
    {
        public static double LiterstoGallonsConvert (double gallonsweight)
        {
            double gallons = gallonsweight;
            return (gallonsweight / 0.26417);

        }

        public static double GallonstoLitersConvert(double literweight)
        {
            double lilters = literweight;
            return (literweight * 0.26417);

        }


        public static double CelsiusToFahrenheit(double tempC)
        {
            double celsius = tempC;
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double tempF)
        {
            double fahrenheit = tempF;
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double PoundstoKilos(double poundsconvert)
        {
            double pounds = poundsconvert;
            return (pounds / 2.2046);
        }

        public static double KilostoPounds(double kilosconvert)
        {
            double kilos = kilosconvert;
            return (kilos * 2.2046);
        }

    }
}
