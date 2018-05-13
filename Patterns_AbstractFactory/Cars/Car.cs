using System;
using Patterns_AbstractFactory.CarsDetailsFactories;

namespace Patterns_AbstractFactory.Cars {

	public enum CarModel { Model1, Model3, Model6 }

	public abstract class Car {

		protected string CarModel;
		protected string BodyDetails;
		protected CarDetailFactory CarDetails;

		public virtual void ConfigureCar(){
			Console.WriteLine("Model: {0}", CarModel);
			Console.WriteLine("Body: {0}", BodyDetails);
			
			CarDetails.MountEngine();
			CarDetails.MountWheels();
			CarDetails.MountDrivingWheel();
			CarDetails.Paint();
		}
		
	}
}
