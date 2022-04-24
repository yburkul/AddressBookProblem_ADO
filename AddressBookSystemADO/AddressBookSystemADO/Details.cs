using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemADO
{
    public class Details
    {
        static string connectionString = @"Data Source=DESKTOP-DNLCRQ5\SQLEXPRESS;Initial Catalog=AddressBook_Service;Integrated Security=True;";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void EstablishConnection()
        {
            if (sqlConnection != null && sqlConnection.State.Equals(ConnectionState.Closed))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");

                }
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");
                }
            }
        }
        public void GetAddressBookDetails()
        {
            try
            {
                AddressBook address = new AddressBook();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                using (sqlConnection)
                {
                    string Sqlquery = @"select * from AddressBook ";
                    SqlCommand cmd = new SqlCommand(Sqlquery, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            address.ID = reader.GetInt32(0);
                            address.First_Name = reader.GetString(1);
                            address.Last_Name = reader.GetString(2);
                            address.Address = reader.GetString(3);
                            address.City = reader.GetString(4);
                            address.State = reader.GetString(5);
                            address.Zip = reader.GetInt64(6);
                            address.PhoneNumber = reader.GetInt64(7);
                            address.Email = reader.GetString(8);
                            address.Type = reader.GetString(9);
                            address.Name = reader.GetString(10);
                            Console.WriteLine(address.ID + "," + address.First_Name + "," + address.Last_Name + "," + address.Address + "," + address.City + ","
                                + address.State + "," + address.Zip + "," + address.PhoneNumber + "," + address.Email + "," + address.Type + "," + address.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}