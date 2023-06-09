using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber) 
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {this.Make}");
            sb.Append($"Model: {this.Model}");
            sb.Append($"HorsePower: {this.HorsePower}");
            sb.Append($"MRegistrationNumberake: {this.RegistrationNumber}");

            return sb.ToString();
        }
    }
}
