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
                Console.WriteLine("1: For Establish Connection");
                Console.WriteLine("2: For Close Connection");
                Console.WriteLine("3: For Get All Address Book Contact Details");
                Console.WriteLine("4: For Add a Contact");
                Console.WriteLine("5: For Edit Contact");
                Console.WriteLine("6: For Delete The Contact");
                Console.WriteLine("7: For Retrieve the data By using City And State");
                Console.WriteLine("8: For Sort Contact By using City");
                Console.WriteLine("0: For Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        details.EstablishConnection();
                        Console.WriteLine("Connection is Open");
                        break;
                     case 2:
                        details.CloseConnection();
                        Console.WriteLine("Connection is closed");
                        break;
                    case 3:
                        details.GetAddressBookDetails();
                        break;
                    case 4:
                        AddressBook addressBook = new AddressBook();
                        Console.WriteLine("Enter First Name");
                        string First_Name = Console.ReadLine();
                        addressBook.First_Name = First_Name;
                        Console.WriteLine("Enter Last Name");
                        string Last_Name = Console.ReadLine();
                        addressBook.Last_Name = Last_Name;
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        addressBook.Address = Address;
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        addressBook.City = City;
                        Console.WriteLine("Enter state");
                        string state = Console.ReadLine();
                        addressBook.State = state;
                        Console.WriteLine("Enter Zip");
                        double zip = Convert.ToInt64(Console.ReadLine());
                        addressBook.Zip = zip;
                        Console.WriteLine("Enter PhoneNumber");
                        double Phone = Convert.ToInt64(Console.ReadLine());
                        addressBook.PhoneNumber = Phone;
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        addressBook.Email = Email;
                        Console.WriteLine("Enter a Address Book Name");
                        string AddressBookName = Console.ReadLine();
                        addressBook.AddressBookName = AddressBookName;
                        Console.WriteLine("Enter type");
                        string type = Console.ReadLine();
                        addressBook.Type = type;                        
                        details.AddContact(addressBook);
                        Console.WriteLine("New Contact is Added");
                        break;
                    case 5:
                        AddressBook addressbook = new AddressBook();    
                        Console.WriteLine("Enter a First Name for Edit Contact");
                        string firstname= Console.ReadLine();   
                        addressbook.First_Name = firstname;
                        Console.WriteLine("Edit Last Name");
                        string lastname= Console.ReadLine();
                        addressbook.Last_Name = lastname;
                        Console.WriteLine("Edit Address");
                        string address = Console.ReadLine();                       
                        addressbook.Address = address;
                        Console.WriteLine("Edit City");
                        string city = Console.ReadLine();
                        addressbook.City = city;
                        Console.WriteLine("Edit State");
                        string State = Console.ReadLine();
                        addressbook.State = State;
                        details.EditContact(addressbook);
                        Console.WriteLine("Contact is Edited");
                        break;
                      case 6:
                        AddressBook delete = new AddressBook();
                        Console.WriteLine("Enter a First Name For Delete The Contact");
                        string first_name = Console.ReadLine();
                        delete.First_Name= first_name;
                        details.RemoveContact(delete);
                        break;
                    case 7:
                        AddressBook getData = new AddressBook();
                        Console.Write("Enter the City Name:-");
                        string cityname = Console.ReadLine();
                        getData.City= cityname;
                        Console.Write("Enter the State Name:-");
                        string statename = Console.ReadLine();
                        getData.State= statename;
                        details.GetDataFromCityAndState(getData);
                        break;
                    case 8:
                        AddressBook sort = new AddressBook();
                        Console.WriteLine("Enter a City For Sort Contact");
                        string City_name = Console.ReadLine();
                        sort.City = City_name;
                        details.SortContactByUsingCity(sort);
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