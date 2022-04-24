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
    }
}