using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var takirasCar = new Car();
            takirasCar.Make = "Audi";
            takirasCar.Make = "Audi";
            takirasCar.Model = "Q8";
            takirasCar.Year = 2022;
            takirasCar.EngineNoise = "vroom";
            takirasCar.HonkNoise = "beep";

            var breahsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDriveable = false
            };

        }
    }
}

