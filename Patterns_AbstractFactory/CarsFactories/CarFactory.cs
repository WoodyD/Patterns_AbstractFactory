using Patterns_AbstractFactory.Cars;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.CarsFactories {
	
	public abstract class CarFactory {

		protected CarDetailFactory CarDetails;
		
		public virtual Car CreateCar(CarModel model){
			
			if (model == CarModel.Model1)
				return new CarModel1(CarDetails);
			else if (model == CarModel.Model3)
				return new CarModel3(CarDetails);
			else
				return new CarModel6(CarDetails);
			
		}
		
	}
	
}
