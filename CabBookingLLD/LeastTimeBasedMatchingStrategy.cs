using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal class LeastTimeBasedMatchingStrategy : DriverMatchingStrategy
    {
        public Driver matchDricer(TripMetadata pMetadata)
        {
            DriverManager driverManager = DriverManager.GetDriverManager();

            if((driverManager.getDriversMap()).Count() == 0)
            {
                Console.WriteLine("No drivers at your area!!");
            }

            Console.WriteLine("Using quadtree to see nearest cabs, using driver manager to get details of drivers.");
            Driver driver = driverManager.getDriversMap().First().Value;
            Console.WriteLine($"Setting {driver.getDriverName()} as driver.");
            pMetadata.setDriverRating(driver.getRating());
            return driver;
        }
    }
}
