using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class Location
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public Location(int latitude, int longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
