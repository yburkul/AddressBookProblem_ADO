using AddressBookSystemADO;
using System;

namespace AddressBookSystemADO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Address Book System Ado.Net");
            Details details = new Details();
            details.EstablishConnection();
            details.CloseConnection();
        }
    }
}