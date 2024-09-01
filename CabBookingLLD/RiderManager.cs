using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabBookingLLD
{
    internal sealed class RiderManager
    {
        private static RiderManager? riderMgrInstance = null;
        private static readonly Object lockObject = new Object();
        private Dictionary<string, Rider> ridersMap = new Dictionary<string, Rider>();
        private RiderManager() { }

        public static RiderManager GetRiderManager()
        {
            if(riderMgrInstance == null)
            {
                lock(lockObject)
                {
                    if(riderMgrInstance == null)
                    {
                        riderMgrInstance = new RiderManager();
                    }
                }
            }
            return riderMgrInstance;
        }

        public void addRider(Rider pRider)
        {
            if(!ridersMap.ContainsKey(pRider.getRiderName()))
            {
                ridersMap[pRider.getRiderName()] = pRider;
            }
            else
            {
                Console.WriteLine("Rider already Exists");
            }
        }

        public Rider GetRider(string pRiderName)
        {
            return ridersMap[pRiderName];
        }
    }
}
