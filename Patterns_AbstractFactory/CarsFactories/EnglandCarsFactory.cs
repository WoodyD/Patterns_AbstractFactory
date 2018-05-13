using Patterns_AbstractFactory.Cars;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.CarsFactories {

	public class EnglandCarsFactory : CarFactory {

		public override Car CreateCar(CarModel model) {

			CarDetails = new EnglandDetailsProducer();

			return base.CreateCar(model);

		}
	}
}