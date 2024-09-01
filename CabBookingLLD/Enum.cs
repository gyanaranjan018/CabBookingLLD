using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    public enum RATING{
        NO_RATING,
        ONE_STAR,
        TWO_STAR,
        THREE_STAR,
        FOUR_STAR,
        FIVE_STAR,
    }

    public enum TRIP_STATUS
    {
        SEARCHING_DRIVER,
        DRIVER_ON_THE_WAY,
        DRIVER_ARRIVED,
        TRIP_STARTED,
        TRIP_COMPLETED
    }
}
