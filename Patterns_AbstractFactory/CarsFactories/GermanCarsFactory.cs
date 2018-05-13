using Patterns_AbstractFactory.Cars;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.CarsFactories {

	public class GermanCarsFactory : CarFactory {
		
		public override Car CreateCar(CarModel model) {

			CarDetails = new GermanyDetailsProducer();
			
			return base.CreateCar(model);
			
		}
	}
}
