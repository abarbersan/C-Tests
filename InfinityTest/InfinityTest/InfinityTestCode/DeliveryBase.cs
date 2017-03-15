using System;
namespace InfinityTest
{
	public abstract class DeliveryBase : DeliveryInterface
	{
		protected string TrackingNumber;
		protected DateTime DepartureTime;

		public Destination TargetDestination { get; set; }

		public DeliveryBase(Destination d)
		{
			this.TrackingNumber = Guid.NewGuid().ToString();
			this.TargetDestination = d;
		}

		public string GetTrackingNumber()
		{
			return TrackingNumber;
		}

		// Implement based on type of Delivery
		public abstract DateTime GetDeliveryTime();

		public void SetDepartureTime(DateTime d)
		{
			this.DepartureTime = d;
		}

		public DateTime GetDepartureTime()
		{
			return this.DepartureTime;
		}
	}
}
