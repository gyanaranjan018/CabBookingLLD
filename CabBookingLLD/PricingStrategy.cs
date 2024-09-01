using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal interface PricingStrategy
    {
        double calculatePrice(TripMetadata pTripMetadata);
    }
}
