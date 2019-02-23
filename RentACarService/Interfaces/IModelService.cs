using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RentACarService
{
    [ServiceContract]
    public interface IModelService
    {
        [OperationContract]
        List<CarModel> GetModels(int manufacturerId);

        [OperationContract]
        void AddNewModel(CarModel model);


    }
}
