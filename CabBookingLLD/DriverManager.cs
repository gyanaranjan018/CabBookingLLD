using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal sealed class DriverManager
    {
        private static DriverManager? driverMgrInstance = null;
        private static readonly Object lockObject = new Object();
        private Dictionary<string, Driver> driversMap = new Dictionary<string, Driver>();
        private DriverManager() { }

        public static DriverManager GetDriverManager()
        {
            if (driverMgrInstance == null)
            {
                lock (lockObject)
                {
                    if (driverMgrInstance == null)
                    {
                        driverMgrInstance = new DriverManager();
                    }
                }
            }
            return driverMgrInstance;
        }

        public void addDriver(Driver pDriver)
        {
            if (!driversMap.ContainsKey(pDriver.getDriverName()))
            {
                driversMap[pDriver.getDriverName()] = pDriver;
            }
            else
            {
                Console.WriteLine("Rider already Exists");
            }
        }

        public Driver GetRider(string pDriverName)
        {
            return driversMap[pDriverName];
        }

        public Dictionary<string, Driver> getDriversMap()
        {
            return driversMap;
        }
    }
}
