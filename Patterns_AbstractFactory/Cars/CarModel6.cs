using System;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.Cars {
	
	public class CarModel6 : Car {
		
		public CarModel6(CarDetailFactory carDetails) {
			CarModel = "Car model 6";
			BodyDetails = "Crossover";
			CarDetails = carDetails;

			ConfigureCar();
		}
		
	}
}
