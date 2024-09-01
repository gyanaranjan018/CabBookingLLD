using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class StrategyManager
    {
        private static StrategyManager? startegyMgrInstance = null;
        private static readonly Object lockObject = new Object();
        private StrategyManager() { }

        public static StrategyManager GetStrategyMgr()
        {
            if (startegyMgrInstance == null)
            {
                lock(lockObject)
                {
                    if(startegyMgrInstance == null)
                    {
                        startegyMgrInstance = new StrategyManager();
                    }
                }
            }
            return startegyMgrInstance;
        }

        public PricingStrategy determinePricingStrategy(TripMetadata pTripMetadata)
        {
            Console.WriteLine("Based on location and other factors, setting pricing strategy");
            return new DefaultPricingStrategy();
        }

        public DriverMatchingStrategy determineMatchingStrategy(TripMetadata pTripMetadata)
        {
            Console.WriteLine("Based on location and other factors, setting pricing strategy");
            return new LeastTimeBasedMatchingStrategy();
        }

    }
}
