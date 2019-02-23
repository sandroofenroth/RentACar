using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    [DataContract]
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
        private string town;

        public Car()
        {

        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DataMember]
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        [DataMember]
        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        [DataMember]
        public int TotalRentals
        {
            get { return totalRentals; }
            set { totalRentals = value; }
        }

        [DataMember]
        public int IdModel
        {
            get { return idModels; }
            set { idModels = value; }
        }

        [DataMember]
        public int CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }

        [DataMember]
        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        [DataMember]
        public double FuelConsuption
        {
            get { return fuelConsuption; }
            set { fuelConsuption = value; }
        }

        [DataMember]
        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        [DataMember]
        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        [DataMember]
        public string Town
        {
            get { return town; }
            set { town = value; }
        }
    }
}
