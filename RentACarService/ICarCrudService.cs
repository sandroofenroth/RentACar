using Common.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace RentACarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarCrudService" in both code and config file together.
    [ServiceContract]
    public interface ICarCrudService
    {
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
