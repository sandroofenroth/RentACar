using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public class Car
    {
        private int id;
        private string type;
        private bool available;
        private byte[] image;
        private int totalRentals;
        private int idModels;
        private int cubicCapacity;
        private string fuel;
        private double fuelConsuption;
        private int power;
        private int kilometers;

        public Car()
        {

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public bool Available
        {
            get { return available; }
            set { available = value; }
        }


        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }


        public int TotalRentals
        {
            get { return totalRentals; }
            set { totalRentals = value; }
        }


        public int IdModels
        {
            get { return idModels; }
            set { idModels = value; }
        }


        public int CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }


        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }


        public double FuelConsuption
        {
            get { return fuelConsuption; }
            set { fuelConsuption = value; }
        }


        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }
    }
}
