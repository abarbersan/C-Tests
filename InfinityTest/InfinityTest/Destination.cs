using System;
namespace InfinityTest
{
	public class Destination
	{
		public string Name { get; set; }
		public double Distance { get; set; }

		public Destination(string name, double distance)
		{
			this.Name = name;
			this.Distance = distance;
		}
	}
}
