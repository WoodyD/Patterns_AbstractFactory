using System;
using Patterns_AbstractFactory.CarsDetails;

namespace Patterns_AbstractFactory.CarsDetailsFactories {
	
	public abstract class CarDetailFactory {
		
		public abstract Engine MountEngine();
		public abstract Wheels MountWheels();
		public abstract DrivingWheel MountDrivingWheel();
		public abstract Color Paint();
		
	}
}
