using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        internal enum VehicleType
        {
            Car,
            Truck
        }
        internal class Vehicle
        {
            public Vehicle(VehicleType type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }
            public VehicleType Type { get; }
            public string Model { get; }
            public string Color { get; }
            public int HorsePower { get; }
            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Type: {Type}");
                builder.AppendLine($"Model: {Model}");
                builder.AppendLine($"Color: {Color}");
                builder.AppendLine($"Horsepower: {HorsePower}");
                return builder.ToString().TrimEnd();
            }


        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End")
                {
                    break;
                }

                var tokens = cmd.Split();
                VehicleType vehicleType;
                bool isVehicleTypeParsable = Enum.TryParse(tokens[0], true, out vehicleType);

                if (isVehicleTypeParsable)
                {
                    string currentModel = tokens[1];
                    string currColor = tokens[2];
                    int currHorsePower = int.Parse(tokens[3]);
                    var currVehicle = new Vehicle(vehicleType, currentModel, currColor, currHorsePower);
                    vehicles.Add(currVehicle);
                }

            }
            while (true)
            {
                string cmdArgs = Console.ReadLine();
                if (cmdArgs == "Close the Catalogue")
                {
                    break;

                }
                Vehicle deseriedVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmdArgs);
                Console.WriteLine(deseriedVehicle);

            }
            var cars = vehicles.Where(cars => cars.Type == VehicleType.Car);
            var trucks = vehicles.Where(truck => truck.Type == VehicleType.Truck);
            double carsAvgHp = cars.Any() ? cars.Average(car => car.HorsePower) : 0.0;
            double truckSAvgHp = trucks.Any() ? trucks.Average(truck => truck.HorsePower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckSAvgHp:F2}.");
        }
    }
}

