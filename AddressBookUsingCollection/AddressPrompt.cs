using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCollection
{
    internal class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }
        public void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }
        public void PerformAction(string selection)
        {
            string Firstname = "";
            string Lastname = "";
            string Address = "";
            string City = "";
            string State = "";
            int Pincode;
            long Mobilenumber;
            string Emailid = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.WriteLine("Enter FirstName: ");
                    Firstname = Console.ReadLine();
                    Console.WriteLine("Enter Lastname: ");
                    Lastname = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    State = Console.ReadLine();
                    Console.WriteLine("Enter Pincode: ");
                    Pincode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Mobile: ");
                    Mobilenumber =long.Parse( Console.ReadLine());
                    Console.WriteLine("Enter Emailid: ");
                    Emailid = Console.ReadLine();
                    if (book.add(Firstname, Lastname, Address, City, State, Pincode, Mobilenumber,Emailid))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", Firstname);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    Firstname = Console.ReadLine();
                    if (book.remove(Firstname))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", Firstname);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("FirstName: {0} \nLastname: {1} \n " +
                            "Address: {2} \nCity: {3} \nState: {4} \n Pincode: {5} \n" +
                            "Mobile Number: {6} \n Emailid: {7} \n ----------------------- \n"
                            , a.firstname, a.lastname, a.address, a.city, a.state, a.pincode, a.mobilenumber, a.mailid));
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    Firstname = Console.ReadLine();
                    Address addr = book.find(Firstname);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", Firstname);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", Firstname);
                    }
                    break;
            }
        }
    }
}
