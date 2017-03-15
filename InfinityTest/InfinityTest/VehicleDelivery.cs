using System;
namespace InfinityTest
{
	public class VehicleDelivery : DeliveryBase
	{
		Vehicle Transport { get; set; }

		public VehicleDelivery(Destination d, Vehicle v) : base(d)
		{
			this.Transport = v;
		}

		public override DateTime GetDeliveryTime()
		{
			return this.DepartureTime.AddHours(this.Transport.GetTravelTime(this.TargetDestination));
		}
	}
}
