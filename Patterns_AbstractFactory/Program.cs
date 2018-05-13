using System;
using Patterns_AbstractFactory.CarsFactories;

namespace Patterns_AbstractFactory {
	
	class Program {
		
		static void Main(string[] args) {

			CarFactory germanyCars = new GermanCarsFactory();		
			germanyCars.CreateCar(Cars.CarModel.Model1);
			germanyCars.CreateCar(Cars.CarModel.Model3);
			germanyCars.CreateCar(Cars.CarModel.Model6);

			Console.WriteLine();
			
			CarFactory englandCars = new EnglandCarsFactory();
			englandCars.CreateCar(Cars.CarModel.Model1);
			englandCars.CreateCar(Cars.CarModel.Model3);
			englandCars.CreateCar(Cars.CarModel.Model6);
			
		}
	}
}
