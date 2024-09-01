using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class Util
    {
        public static string ratingToString(RATING pRating)
        {
            switch (pRating)
            {
                case RATING.ONE_STAR:
                    return "one star";
                case RATING.TWO_STAR:
                    return "two stars";
                case RATING.THREE_STAR:
                    return "three stars";
                case RATING.FOUR_STAR:
                    return "four stars";
                case RATING.FIVE_STAR:
                    return "five stars";
                default:
                    return "invalid rating";
            }

        }
        public static bool isHighRating(RATING pRating)
        {
            return pRating == RATING.FOUR_STAR || pRating == RATING.FIVE_STAR;
        }
    }
}
