using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class Trip
    {
        private Rider rider;
        private Driver driver;
        private Location srcLoc;
        private Location destLoc;
        private TRIP_STATUS staus;
        private int tripId;
        private double price;
        private PricingStrategy pricingStrategy;
        private DriverMatchingStrategy driverMatchingStrategy;
        private static int nextTripId = 1;

        public Trip(Rider pRider, Driver pDriver, Location pSrcLoc, Location pDestLoc, double pPrice, PricingStrategy pPricingStrategy, DriverMatchingStrategy pDriverMatchingStrategy )
        {
            rider = pRider;
            driver = pDriver;
            srcLoc = pSrcLoc;
            destLoc = pDestLoc;
            price = pPrice;
            pricingStrategy = pPricingStrategy;
            driverMatchingStrategy = pDriverMatchingStrategy;
            staus = TRIP_STATUS.DRIVER_ON_THE_WAY;
            tripId = nextTripId;
            nextTripId++;
        }

        public int getTripId()
        {
            return tripId;
        }

        public void displayTripDetails()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Trip Id - {tripId}");
            Console.WriteLine($"Rider - {rider.getRiderName()}");
            Console.WriteLine($"Driver - {driver.getDriverName()}");
            Console.WriteLine($"Price - {price}");
            Console.WriteLine($"Locations - {srcLoc.Latitude},{srcLoc.Longitude} and {destLoc.Latitude},{destLoc.Longitude}");
            Console.WriteLine("");
        }

    }
}
