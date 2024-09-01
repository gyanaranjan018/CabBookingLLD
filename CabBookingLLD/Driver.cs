using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class Driver
    {
        private string name;
        private bool availability;
        private RATING rating;
        public Driver(string pName, RATING pRating)
        {
            this.name = pName;
            this.rating = pRating;
        }

        public string getDriverName() { return name; }
        public void updateAvailability(bool pAvail)
        {
            this.availability = pAvail;
        }
        public RATING getRating() { return rating; }
    }
}
