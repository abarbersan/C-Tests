using System;

namespace InfinityTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Infinity Test Project Starting");

			// Vehicles
			Vehicle truck1 = new Truck("Truck1");
			Vehicle truck2 = new Truck("Truck2");
			Vehicle van1 = new Van("Van1");
			Vehicle van2 = new Van("Van2");

			// Destinations
			Destination truckee = new Destination("Truckee", 30.2);
			Destination carsonCity = new Destination("Carson City", 50.4);
			Destination elko = new Destination("Elko", 150.7);
			Destination southLakeTahoe = new Destination("South Lake Tahoe", 60);
			Destination sacramento = new Destination("Sacramento", 120.4);

			// Deliveries
			VehicleDelivery d1 = new VehicleDelivery(truckee, truck1);
			d1.SetDepartureTime(new DateTime(2017, 2, 25, 8, 0, 0));

			VehicleDelivery d2 = new VehicleDelivery(carsonCity, truck2);
			d2.SetDepartureTime(new DateTime(2017, 2, 25, 8, 0, 0));

			VehicleDelivery d3 = new VehicleDelivery(elko, van1);
			d3.SetDepartureTime(new DateTime(2017, 2, 25, 8, 30, 0));

			VehicleDelivery d4 = new VehicleDelivery(southLakeTahoe, van2);
			d4.SetDepartureTime(new DateTime(2017, 2, 25, 9, 0, 0));

			VehicleDelivery d5 = new VehicleDelivery(sacramento, truck1);
			d5.SetDepartureTime(new DateTime(2017, 2, 26, 8, 0, 0));

			VehicleDelivery d6 = new VehicleDelivery(sacramento, van1);
			d6.SetDepartureTime(new DateTime(2017, 2, 26, 9, 0, 0));


			// Deliveries/Schedule
			DeliverySchedule schedule = new DeliverySchedule("Department A");
			schedule.AddDelivery(d1);
			schedule.AddDelivery(d2);
			schedule.AddDelivery(d3);
			schedule.AddDelivery(d4);
			schedule.AddDelivery(d5);
			schedule.AddDelivery(d6);

			// Output
			Console.WriteLine(schedule.OutputSchedule());
		}
	}
}
