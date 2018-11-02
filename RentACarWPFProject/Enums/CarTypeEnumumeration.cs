using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarWPFProject.Enums
{
    public class CarTypeEnumumeration
    {

        public List<CarTypeEnum> CarTypeEnumList;
        public CarTypeEnumumeration()
        {
           CarTypeEnumList = new List<CarTypeEnum>();
           CarTypeEnumList = Enum.GetValues(typeof(CarTypeEnum)).Cast<CarTypeEnum>().ToList();
        }
        public enum CarTypeEnum
        {
          
            Sedan,
            Hatchback,
            StationWagon,
            Coupe,
            Convertible,
            Minivan,
            SUV,
            Pickup,
            Luxury
        }
         
        //List<CarTypeEnum> CarTypeEnumList = Enum.GetValues(typeof(CarTypeEnum)).Cast<CarTypeEnum>().ToList();
    }
}
