using Common.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace RentACarService
{
    [ServiceContract]
    public interface IManufacturerService
    {
        [OperationContract]
        List<Manufacturer> GetManufacturers();

        [OperationContract]
        void AddNewManufacturer(Manufacturer manufacturer);
    }
}
