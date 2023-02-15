using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public bool CanFly { get; set; }
		public bool DoPeopleEatThem { get; set; }
		public string Color { get; set; }
		public bool BirdOfPrey { get; set; }
	}
}

