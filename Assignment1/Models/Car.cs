using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Car
    {
        public int Cost { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Car(int cost, int year, string make, string model, string color)
        {
            this.Cost = cost;
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Color = color;
        }
    }
}