using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public bool DoesItHaveATail { get; set; }
		public string IsItBig { get; set; }
		public bool IsItVenomous { get; set; }
		public string NativeLand { get; set; }
	}
}

