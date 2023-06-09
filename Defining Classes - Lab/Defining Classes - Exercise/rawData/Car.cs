using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawData
{
    public class Car
    {
        public Car(string model, int speed, int power, int weight, string type,
            double tire1pressure, int age1,double tire2pressure, int age2, double tire3pressure,
            int age3,double tire4pressure, int age4) 
        {
            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tire[4];
            Tires[0] = new(tire1pressure, age1);
            Tires[1] = new(tire2pressure, age2);
            Tires[2] = new(tire3pressure, age3);
            Tires[3] = new(tire4pressure, age4);


        }    
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
    }
}
