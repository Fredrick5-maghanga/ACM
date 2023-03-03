using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        private string postalCode;

        public string State { get;  set; }
        public string City  { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
       public int  AddressType { get; set; } 
       public string  StreetLine1 { get; set; }
       public string  StreetLine2 { get; set; }


        ///<summary>
        ///Retrieve one Adress
        ///</summary>
        public Address Retrieve(int addressId)
        {

            //create the instance of the Address class
            //pass in the requested id

            Address address = new Address(addressId);

            // code that retrieves the defined address
            //temporary hard coded values to return
            // a populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrrieveByCustomerId( int customerId) 
        {

            // code that retrieves the defined address
            // for the customer
            //Temporary hard-coded values to return 
            // a set of address for customer

            var addressList = new List<Address>();
            Address address = new Address(1);

           // if (addressId == 1)
            {
                AddressType = 1;
                StreetLine1 = "Bag End";
                StreetLine2 = "Bagshot Row";
                City = "Hobbiton";
                State = "Shire";
                Country = "Middle Earth";
                PostalCode = "144";
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dregon", 
                City = "Bywater",
                State = "Shire",
                Country ="Middle Eart",
                PostalCode = "146",

            };
            addressList.Add(address);
            return addressList;
        }
        ///<summary>
        ///saves the current address
        ///</summary>
        
        public bool Save(Address adress)
        {
            // code that saves the passed in address
            return true;
        }
        
    }
    
}
                    

       

