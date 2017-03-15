using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityTest
{
	public class DeliverySchedule
	{
		public string Name { get; set; }
		private Dictionary<string, DeliveryBase> DeliveryMap = new Dictionary<string, DeliveryBase>();

		public DeliverySchedule(string name)
		{
			this.Name = name;
		}

		public void AddDelivery(DeliveryBase d)
		{
			this.DeliveryMap.Add(d.GetTrackingNumber(), d);
		}

		public DeliveryBase GetDelivery(string trackingNum)
		{
			DeliveryBase d = null;

			if (DeliveryMap.ContainsKey(trackingNum)) 
			{
				d = DeliveryMap[trackingNum];
			}

			return d;
		}

		public void RemoveDelivery(string trackingNum)
		{
			if (DeliveryMap.ContainsKey(trackingNum))
			{
				DeliveryMap.Remove(trackingNum);
			}
		}

		public string OutputSchedule()
		{
			StringBuilder output = new StringBuilder();

			output.AppendLine(string.Format("Delivery Schedule for {0}", this.Name));

			foreach (string key in DeliveryMap.Keys)
			{
				DeliveryBase d = DeliveryMap[key];
				output.AppendLine(string.Format("Tracking Number: {0}, Destination: {1}, DepartureTime: {2}, DeliveryTime: {3}",
				                                d.GetTrackingNumber(), d.TargetDestination.Name, d.GetDepartureTime(),
				                                d.GetDeliveryTime()));
			}

			output.AppendLine("*** End of Schedule ***");

			return output.ToString();
		}
	}
}
