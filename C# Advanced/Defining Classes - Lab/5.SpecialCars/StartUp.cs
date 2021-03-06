﻿namespace _5.SpecialCars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;

            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = input.Split();

                Tire tireCollection = new Tire(int.Parse(tokens[0]),double.Parse(tokens[1]),
                    int.Parse(tokens[2]), double.Parse(tokens[3]),
                    int.Parse(tokens[4]), double.Parse(tokens[5]),
                    int.Parse(tokens[6]), double.Parse(tokens[7]));

                tires.Add(tireCollection);
            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = input.Split();
                Engine engine = new Engine(int.Parse(tokens[0]), double.Parse(tokens[1]));
                engines.Add(engine);
            }

            input = string.Empty;

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] tokens = input.Split();
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);
                Car car = new Car(tokens[0],tokens[1], int.Parse(tokens[2]),
                    double.Parse(tokens[3]), double.Parse(tokens[4]),
                    engines[engineIndex],tires[tireIndex]);

                cars.Add(car);

            }

            var specialCars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330
            && ((x.Tire.Pressure0 + x.Tire.Pressure1 + x.Tire.Pressure2 + x.Tire.Pressure3)>= 9 &&
            (x.Tire.Pressure0 + x.Tire.Pressure1 + x.Tire.Pressure2 + x.Tire.Pressure3) <= 10)).ToList();

            for (int i = 0; i < specialCars.Count; i++)
            {
                specialCars[i].FuelQuantity -= (20 * specialCars[i].FuelConsumption) / 100;
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
