using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class TripMetadata
    {
        private RATING riderRating;
        private RATING driverRating;
        private Location srcLoc;
        private Location destLoc;

        public TripMetadata(Location pSrcLoc, Location pDestLoc, RATING pRiderRating)
        {
            riderRating = pRiderRating;
            srcLoc = pSrcLoc;
            destLoc = pDestLoc;
        }
        
        public RATING getRiderRating()
        {
            return riderRating;
        }

        public RATING getDriverRating()
        {
            return driverRating;
        }

        public void setDriverRating(RATING pDriverRating)
        {
            this.driverRating = pDriverRating;
        }

    }
}
