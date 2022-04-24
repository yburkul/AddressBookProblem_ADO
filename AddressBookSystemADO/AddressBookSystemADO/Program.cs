using AddressBookSystemADO;
using System;

namespace AddressBookSystemADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Address Book System Ado.Net");
            Details details = new Details();
            int option = 0;
            do
            {
                Console.WriteLine("1: For All Address Book Contact Details");
                Console.WriteLine("0: For Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        details.GetAddressBookDetails();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            while (option != 0);
        }
    }
}