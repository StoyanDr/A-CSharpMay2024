using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;
public class StartUp
{
    static void Main()
    {
        string input = String.Empty;
        List<Tire[]> tires = new();
        while ((input = Console.ReadLine()) != "No more tires")
        {
            string[] tokens = input.Split();
            Tire[] t = new Tire[4];
            Tire t1 = new(int.Parse(tokens[0]), double.Parse(tokens[1]));
            Tire t2 = new(int.Parse(tokens[2]), double.Parse(tokens[3]));
            Tire t3 = new(int.Parse(tokens[4]), double.Parse(tokens[5]));
            Tire t4 = new(int.Parse(tokens[6]), double.Parse(tokens[7]));
            t[0] = t1;
            t[1] = t2;
            t[2] = t3;
            t[3] = t4;
            tires.Add(t);
        }
        List<Engine> engines = new();
        while((input =  Console.ReadLine()) != "Engines done")
        {
            string[] tokens = input.Split();
            int horsePower = int.Parse(tokens[0]);
            double cubicCapacity = double.Parse(tokens[1]);

            Engine engine = new(horsePower, cubicCapacity);
            engines.Add(engine);
        }
        List<Car> specialCars = new();
        while((input = Console.ReadLine()) != "Show special")
        {
            string[] tokens = input.Split();
            string name = tokens[0];
            string model = tokens[1];
            int year = int.Parse(tokens[2]);
            double fuelQuantity = double.Parse(tokens[3]);
            double fuelConsumption = double.Parse(tokens[4]);
            int engineIndex = int.Parse(tokens[5]);
            int tiresIndex = int.Parse(tokens[6]);
            Car car = new(name, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
            specialCars.Add(car);
        }
        specialCars = specialCars.Where(c => c.Year >= 2017 && c.Engine.HorsePower > 330 && c.SumOfPressure() >= 9 && c.SumOfPressure() <= 10).ToList();
        for (int i = 0; i < specialCars.Count; i++)
        {
            specialCars[i].Drive(20);
            Console.WriteLine(specialCars[i]);
        }

        
    }
}

