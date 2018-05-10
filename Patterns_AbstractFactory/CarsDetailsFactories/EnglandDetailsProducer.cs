using Patterns_AbstractFactory.CarsDetails;

namespace Patterns_AbstractFactory.CarsDetailsFactories {
	
	public class EnglandDetailsProducer : CarDetailFactory {
		
		public override Engine MountEngine() {
			return new GasolineEngine();
		}
		
		public override Wheels MountWheels() {
			return new MediumWheels();
		}
		
		public override DrivingWheel MountDrivingWheel() {
			return new RightSideDrivingWheel();
		}

		public override Color Paint() {
			return new WhiteColor();
		}
	}
}
