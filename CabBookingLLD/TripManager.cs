using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class TripManager
    {
        private static TripManager? tripManagerinstance = null;
        private static readonly Object lockObject = new Object();
        private RiderManager ridermanager;
        private DriverManager drivermanager;
        private Dictionary<int, TripMetadata> tripsMetadataInfo = new Dictionary<int, TripMetadata>();
        private Dictionary<int, Trip> tripsInfo = new Dictionary<int, Trip>();

        TripManager()
        {
            ridermanager = RiderManager.GetRiderManager();
            drivermanager = DriverManager.GetDriverManager();
        }

        public static TripManager GetTripManager()
        {
            if (tripManagerinstance == null)
            {
                lock(lockObject)
                {
                    if(tripManagerinstance == null)
                    {
                        tripManagerinstance = new TripManager();
                    }
                }
            }
            return tripManagerinstance;
        }

        public void createTrip(Rider pRider, Location pSrcLoc, Location pDestLoc)
        {
            TripMetadata tripMetadata = new TripMetadata(pSrcLoc, pDestLoc, pRider.getRating());
            StrategyManager strategyManager = StrategyManager.GetStrategyMgr();
            PricingStrategy pricingStrategy = strategyManager.determinePricingStrategy(tripMetadata);
            DriverMatchingStrategy driverMatchingStrategy = strategyManager.determineMatchingStrategy(tripMetadata);

            Driver driver = driverMatchingStrategy.matchDricer(tripMetadata);
            double tripPrice = pricingStrategy.calculatePrice(tripMetadata);

            Trip trip = new Trip(pRider, driver, pSrcLoc, pDestLoc, tripPrice, pricingStrategy, driverMatchingStrategy);
            int tripId = trip.getTripId();
            tripsInfo[tripId] = trip;
            tripsMetadataInfo[tripId] = tripMetadata;

        }

        public Dictionary<int, Trip> getTripsMap()
        {
            return tripsInfo;
        }
    }
}
