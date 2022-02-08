using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCollection
{
    internal class Address
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public int pincode;
        public long mobilenumber;
        public string mailid;

        public Address(string firstname, string lastname, string address,string city, string state,int pincode,long mobile,string mailid)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.mobilenumber = mobile;
            this.mailid = mailid;
        }
    }
}
