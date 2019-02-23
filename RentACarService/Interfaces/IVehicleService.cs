using Common.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;

namespace RentACarService
{
    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        void AddNewCar(Car car);

        [OperationContract]
        List<Car> GetCars();

        [OperationContract]
        List<Car> GetCarByManufacturer(Manufacturer manufacturer);

        [OperationContract]
        List<Car> GetCarByModel(CarModel model);

        [OperationContract]
        int DeleteCar(Car car);

        [OperationContract]
        int UpdateCar(Car car);

    }
}
