using System;
namespace InfinityTest
{
	public class Van : Vehicle
	{
		public Van() : base("Van")
		{
			this.Speed = 60;
		}

		public Van(string name) : base(name)
		{
			this.Speed = 60;
		}
	}
}
