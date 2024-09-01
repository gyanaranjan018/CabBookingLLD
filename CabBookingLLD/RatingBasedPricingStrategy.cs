using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class RatingBasedPricingStrategy : PricingStrategy
    {
        public double calculatePrice(TripMetadata pTripMetadata)
        {
            double price = Util.isHighRating(pTripMetadata.getRiderRating()) ? 55.0 : 65.0;
            Console.WriteLine($"Based on {Util.ratingToString(pTripMetadata.getRiderRating())} rider rating, price of trip is {price}");
            Console.WriteLine(" ");
            return price;
        }
    }
}
