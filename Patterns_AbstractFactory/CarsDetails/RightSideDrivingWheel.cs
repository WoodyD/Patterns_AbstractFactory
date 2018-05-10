using System;

namespace Patterns_AbstractFactory.CarsDetails {
	
	public class RightSideDrivingWheel : DrivingWheel {
		
		public RightSideDrivingWheel() {
			Console.WriteLine("Driving wheel is on the right side");
		}
	}
}
