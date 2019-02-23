using Common.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace RentACarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Login(Person person);

        //[OperationContract]
        //List<Manufacturer> GetManufacturers();

        [OperationContract]
        List<CarModel> GetCarModels(int manufacturerId);

        //[OperationContract]
        //void AddNewManufacturer(Manufacturer manufacturer);

        [OperationContract]
        void AddNewModel(CarModel carModel);

        [OperationContract]
        void AddNewCar(Car car);

        [OperationContract]
        List<Car> GetCar();

        [OperationContract]
        List<Car> GetCarByModel(int idModel);

        // TODO: Add your service operations here
    }

    //[DataContract]
    //public class ServiceManufacturer
    //{
    //    private int id;
    //    private string name;
    //    private byte[] logo;
    //    private List<ServiceCarModel> models;

    //    public ServiceManufacturer()
    //    {

    //    }

    //    [DataMember]
    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }

    //    [DataMember]
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    [DataMember]
    //    public byte[] Logo
    //    {
    //        get { return logo; }
    //        set { logo = value; }
    //    }

    //    [DataMember]
    //    public List<ServiceCarModel> Models
    //    {
    //        get { return models; }
    //        set { models = value; }
    //    }

    //}

    //[DataContract]
    //public class ServiceCarModel
    //{
    //    private int id;
    //    private string name;
    //    private int year;
    //    private int manufacturerId;

    //    public ServiceCarModel()
    //    {

    //    }

    //    [DataMember]
    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }

    //    [DataMember]
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    [DataMember]
    //    public int Year
    //    {
    //        get { return year; }
    //        set { year = value; }
    //    }

    //    [DataMember]
    //    public int ManufacturerId
    //    {
    //        get { return manufacturerId; }
    //        set { manufacturerId = value; }
    //    }
    //}

    //[DataContract]
    //public class ServicePerson
    //{
    //    private int id;
    //    private string name;
    //    private string surname;
    //    private string password;

    //    public ServicePerson()
    //    {

    //    }

    //    [DataMember]
    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }

    //    [DataMember]
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    [DataMember]
    //    public string Surname
    //    {
    //        get { return surname; }
    //        set { surname = value; }
    //    }

    //    [DataMember]
    //    public string Password
    //    {
    //        get { return password; }
    //        set { password = value; }
    //    }

    //}

    //[DataContract]
    //public class ServiceCar
    //{
    //    private int id;
    //    private string type;
    //    private bool available;
    //    private byte[] image;
    //    private int totalRentals;
    //    private int idModels;
    //    private int cubicCapacity;
    //    private string fuel;
    //    private double fuelConsuption;
    //    private int power;
    //    private int kilometers;


    //    [DataMember]
    //    public int Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }

    //    [DataMember]
    //    public string Type
    //    {
    //        get { return type; }
    //        set { type = value; }
    //    }

    //    [DataMember]
    //    public bool Available
    //    {
    //        get { return available; }
    //        set { available = value; }
    //    }

    //    [DataMember]
    //    public byte[] Image
    //    {
    //        get { return image; }
    //        set { image = value; }
    //    }

    //    [DataMember]
    //    public int TotalRentals
    //    {
    //        get { return totalRentals; }
    //        set { totalRentals = value; }
    //    }

    //    [DataMember]
    //    public int IdModel
    //    {
    //        get { return idModels; }
    //        set { idModels = value; }
    //    }

    //    [DataMember]
    //    public int CubicCapacity
    //    {
    //        get { return cubicCapacity; }
    //        set { cubicCapacity = value; }
    //    }

    //    [DataMember]
    //    public string Fuel
    //    {
    //        get { return fuel; }
    //        set { fuel = value; }
    //    }

    //    [DataMember]
    //    public double FuelConsuption
    //    {
    //        get { return fuelConsuption; }
    //        set { fuelConsuption = value; }
    //    }

    //    [DataMember]
    //    public int Power
    //    {
    //        get { return power; }
    //        set { power = value; }
    //    }

    //    [DataMember]
    //    public int Kilometers
    //    {
    //        get { return kilometers; }
    //        set { kilometers = value; }
    //    }
    //}

}
