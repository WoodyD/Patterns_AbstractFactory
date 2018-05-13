using System;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.Cars {
	
	public class CarModel3 : Car {
		
		public CarModel3(CarDetailFactory carDetails) {
			CarModel = "Car model 3";
			BodyDetails = "Sedan";
			CarDetails = carDetails;

			ConfigureCar();
		}
	}
}
