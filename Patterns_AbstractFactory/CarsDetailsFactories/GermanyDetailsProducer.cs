using Patterns_AbstractFactory.CarsDetails;

namespace Patterns_AbstractFactory.CarsDetailsFactories {
	
	public class GermanyDetailsProducer : CarDetailFactory {

		public override Engine MountEngine() {
			return new DieselEngine();
		}

		public override Wheels MountWheels() {
			return new BigWheels();
		}

		public override DrivingWheel MountDrivingWheel() {
			return new LeftSideDrivingWheel();
		}

		public override Color Paint() {
			return new BlackColor();
		}
		
	}
}
