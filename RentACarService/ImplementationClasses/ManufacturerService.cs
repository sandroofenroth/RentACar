using Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace RentACarService
{
    class ManufacturerService : IManufacturerService
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public void AddNewManufacturer(Manufacturer manufacturer)
        {
            using (sqlConnection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand() { Connection = sqlConnection, CommandType = CommandType.Text };
                    sqlConnection.Open();
                    sqlCommand.CommandText = "SELECT * FROM Manufacturer WHERE Name = @Name";
                    sqlCommand.Parameters.AddWithValue("@Name", manufacturer.Name);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        sqlCommand.CommandText = "Insert into Manufacturer(Name, Logo) values(@Name, @Logo)";
                        if (manufacturer.Logo != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@Logo", manufacturer.Logo);
                        }
                        reader.Close();

                        sqlCommand.ExecuteReader();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public List<Manufacturer> GetManufacturers()
        {
            using (sqlConnection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                List<Manufacturer> manufacturers = new List<Manufacturer>();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Manufacturer";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                Manufacturer manufacturer = new Manufacturer();
                using (reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        manufacturer.Id = (int)reader["Id"];
                        manufacturer.Name = reader["Name"].ToString();
                        if (reader["Logo"] != DBNull.Value)
                        {
                            manufacturer.Logo = (byte[])reader["Logo"];
                        }
                        IModelService modelService = new ModelService(); 
                        manufacturer.Models = modelService.GetModels(manufacturer.Id);
                        manufacturers.Add(manufacturer);
                    }
                }
                return manufacturers;
            }
        }

    }
}
