using CarSalesman;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        
        public Car(string model, string engineModel, string weight, string color)
        {
            Model = model;
            EngineModel = engineModel;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public string EngineModel { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}
