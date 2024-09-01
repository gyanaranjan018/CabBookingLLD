using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class DefaultPricingStrategy : PricingStrategy
    {
        public double calculatePrice(TripMetadata pTripMetadata)
        {
            Console.WriteLine("Based on default startegy, price is 100");
            return 100;
        }
    }
}
