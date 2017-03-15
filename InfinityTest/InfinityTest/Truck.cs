using System;
namespace InfinityTest
{
	public class Truck : Vehicle
	{
		public Truck() : base("Truck")
		{
			this.Speed = 45;
		}

		public Truck(string name) : base(name)
		{
			this.Speed = 45;
		}
	}
}
