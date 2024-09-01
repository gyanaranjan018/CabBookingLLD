namespace CabBookingLLD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Riders and Drivers
            Rider riderArambh = new Rider("Arambh", RATING.FOUR_STAR);
            Rider riderVidya = new Rider("Vidya", RATING.TWO_STAR);
            RiderManager riderManager = RiderManager.GetRiderManager();
            riderManager.addRider(riderArambh);
            riderManager.addRider(riderVidya);

            Driver driverBala = new Driver("Bala", RATING.ONE_STAR);
            Driver driverSambhu = new Driver("Sambhu", RATING.TWO_STAR);
            DriverManager driverManager = DriverManager.GetDriverManager();
            driverManager.addDriver(driverBala);
            driverManager.addDriver(driverSambhu);

            //These detyails in turn will be stored in datatbase

            TripManager tripManager = TripManager.GetTripManager();

            Console.WriteLine($"Creating trip for {riderArambh.getRiderName()} from Location (10, 10) to (30, 30) ");
            tripManager.createTrip(riderArambh, new Location(10, 10), new Location(30, 30));


            Console.WriteLine($"Creating trip for {riderVidya.getRiderName()} from Location (200, 230) to (870, 730) ");
            tripManager.createTrip(riderVidya, new Location(200, 230), new Location(870, 730));

            //Display all the trips created
            Dictionary<int, Trip> tripsMap = tripManager.getTripsMap();
            foreach(var mapVal in tripsMap)
            {
                mapVal.Value.displayTripDetails();
            }

        }
    }
}
