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
            return (gallonsweight * 3.79);

        }

        public static double GallonstoLitersConvert(double literweight)
        {
            double lilters = literweight;
            return (literweight * 0.79);

        }

    }
}
