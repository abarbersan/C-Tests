using System;

namespace InfinityTest
{
	public abstract class Vehicle
	{
		public string Name { get; set; }
		public double Speed { get; protected set; }

		public Vehicle()
		{
			this.Name = "Generic Vehicle";
		}

		public Vehicle(string name)
		{
			this.Name = name;
		}

		public double GetTravelTime(Destination dest)
		{
			return Math.Round(dest.Distance / this.Speed, 2);
		}
	}
}
