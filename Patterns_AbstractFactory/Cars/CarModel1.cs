using System;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.Cars {
	
	public class CarModel1 : Car {
		
		public CarModel1(CarDetailFactory carDetails) {
			CarModel = "Car model 1";
			BodyDetails = "Hutchback";
			CarDetails = carDetails;

			ConfigureCar();
		}
		
	}
}
