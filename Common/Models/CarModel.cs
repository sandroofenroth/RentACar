using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public class CarModel
    {
        private int id;
        private string name;
        private int year;
        private int manufacturerId;

        public CarModel()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int ManufacturerId
        {
            get { return manufacturerId; }
            set { manufacturerId = value; }
        }
    }
}
