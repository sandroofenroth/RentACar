using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using Common.Models;

namespace RentACarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        private const string CONNECTION_STRING = @"Data Source=DESKTOP-2O9H0V5\Bogdan;" +
            "Initial Catalog=Rent_A_Car; MultipleActiveResultSets=True;" +
            "Integrated Security=True";

        public Service1()
        {

        }

        public int Login(Person customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                int res = 0;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT COUNT(*) from Customer WHERE " +
                    "Name = @Name AND Surname = @Surname AND Password = @Password";
                sqlCommand.Parameters.AddWithValue("Name", customer.Name);
                sqlCommand.Parameters.AddWithValue("Surname", customer.Surname);
                sqlCommand.Parameters.AddWithValue("Password", customer.Password);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                sqlReader.Read();
                res = sqlReader.GetInt32(0);
                return res;
            }

        }

        public List<Manufacturer> GetManufacturers()
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                List<Manufacturer> manList = new List<Manufacturer>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Manufacturer";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Manufacturer man = new Manufacturer();
                        man.Id = sqlReader.GetInt32(0);
                        man.Name = sqlReader.GetString(1);
                        if (sqlReader["Logo"] != System.DBNull.Value)
                        {
                            man.Logo = (byte[])sqlReader["Logo"];
                        }
                        man.Models = GetCarModels(man.Id);
                        manList.Add(man);
                    }
                }
                return manList;
            }
        }

        public List<CarModel> GetCarModels(int manufacturerId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                List<CarModel> modelList = new List<CarModel>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Model WHERE Id_Manufacturer = @Id";
                sqlCommand.Parameters.AddWithValue("Id", manufacturerId);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    CarModel model = new CarModel();
                    model.Id = sqlReader.GetInt32(0);
                    model.Name = sqlReader.GetString(1);
                    model.Year = sqlReader.GetInt32(2);
                    model.ManufacturerId = sqlReader.GetInt32(3);
                    modelList.Add(model);
                }
                return modelList;
            }
        }

        public void AddNewManufacturer(Manufacturer manufacturer)
        {

            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "Insert into Manufacturer(Name, Logo) values(@Name, @Logo)";
                sqlCommand.Parameters.AddWithValue("@Name", manufacturer.Name);
                if (manufacturer.Logo != null)
                {
                    sqlCommand.Parameters.AddWithValue("@Logo", manufacturer.Logo);
                }

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteReader();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public void AddNewModel(CarModel carModel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "Insert into Model(Name, Year, Id_Manufacturer) values(@Name, @Year, @Id_Manufacturer)";
                sqlCommand.Parameters.AddWithValue("@Name", carModel.Name);
                sqlCommand.Parameters.AddWithValue("@Year", carModel.Year);
                sqlCommand.Parameters.AddWithValue("@Id_Manufacturer", carModel.ManufacturerId);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void AddNewCar(Car car)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "Insert into Car(Type, Available, Image, TotalRentals, Id_Model, CubicCapacity, Fuel," +
                    "FuelConsuption, Power, Kilometers) values(@Type, @Available, @Image, @TotalRentals, @Id_Model, @CubicCapacity, @Fuel, @FuelConsuption, @Power, @Kilometers)";
                sqlCommand.Parameters.AddWithValue("@Type", car.Type);
                sqlCommand.Parameters.AddWithValue("@Available", car.Available);
                sqlCommand.Parameters.Add("@Image", SqlDbType.Image).Value = (car.Image == null) ? (object)DBNull.Value : car.Image;
                sqlCommand.Parameters.AddWithValue("@TotalRentals", car.TotalRentals);
                sqlCommand.Parameters.AddWithValue("@Id_Model", car.IdModels);
                sqlCommand.Parameters.AddWithValue("@CubicCapacity", car.CubicCapacity);
                sqlCommand.Parameters.AddWithValue("@Fuel", car.Fuel);
                sqlCommand.Parameters.AddWithValue("@FuelConsuption", car.FuelConsuption);
                sqlCommand.Parameters.AddWithValue("@Power", car.Power);
                sqlCommand.Parameters.AddWithValue("@Kilometers", car.Kilometers);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }

        public List<Car> GetCar(int carModel_id, int manufacturer_id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING))
            {
                List<Car> carList = new List<Car>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Car C";
                //"JOIN Model M ON M.Id = C.Id_Model" +
                //"JOIN Manufacturer Ma ON Ma.Id = M.Id_Manufacturer";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    Car car = new Car();
                    {
                        try
                        {
                            car.Id = (int)sqlReader["Id"];
                            car.Type = (string)sqlReader["Type"];
                            car.Available = (bool)sqlReader["Available"];
                            if (car.Image != null)
                            {
                                car.Image = (byte[])sqlReader["Image"];
                            }

                            car.TotalRentals = (int)sqlReader["TotalRentals"];
                            car.IdModels = (int)sqlReader["Id_Model"];
                            car.CubicCapacity = (int)sqlReader["CubicCapacity"];
                            car.Fuel = (string)sqlReader["Fuel"];
                            car.FuelConsuption = (double)sqlReader["FuelConsuption"];
                            car.Power = (int)sqlReader["Power"];
                            car.Kilometers = (int)sqlReader["Kilometers"];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    };
                    carList.Add(car);
                }
                return carList;
            }
        }
    }
}
