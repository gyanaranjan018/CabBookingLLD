using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class Rider
    {
        private string name;
        private RATING rating;
        public Rider(string pName, RATING pRating)
        {
            this.name = pName;  
            this.rating = pRating;
        }

        public string getRiderName() { return name; }
        public RATING getRating() { return rating; }
    }
}
