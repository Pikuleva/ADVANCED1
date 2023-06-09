using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedRacing
{
    public class Car
    {
        public Car() { }
        List<Car> cars;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km) 
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            
        }

        public void DistaceTraveled(string model, double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKilometer;
                    if (FuelAmount < neededFuel)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                       
                    }
                    else
                    {

                        FuelAmount -= distance*FuelConsumptionPerKilometer;
                        TravelledDistance += distance;
                    }
                
            
        }
    }
}
