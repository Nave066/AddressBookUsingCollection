using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCollection
{
    internal class AddressBook
    {
        List<Address> addresses;
        public AddressBook()
        {
            addresses = new List<Address>();
        }
        public bool add(string Firstname, string Lastname,string Address,string City,string State, int Pincode,long Mobilenumber,string Mailid)
        {
            Address adr = new Address(Firstname, Lastname, Address,City,State,Pincode,Mobilenumber,Mailid);
            Address result = find(Firstname);

            if (result == null)
            {
                addresses.Add(adr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool remove(string name)
        {
            Address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }

        public Address find(string name)
        {
            Address adr = addresses.Find((a) => a.firstname == name);
            return adr;
        }
    }
}
