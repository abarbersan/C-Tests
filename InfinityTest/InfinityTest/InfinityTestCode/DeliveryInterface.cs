using System;
namespace InfinityTest
{
	public interface DeliveryInterface
	{
		void SetDepartureTime(DateTime time);
		DateTime GetDepartureTime();
		DateTime GetDeliveryTime();
		string GetTrackingNumber();
	}
}
