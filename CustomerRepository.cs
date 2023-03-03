using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository() 
        {
            addressRepository= new AddressRepository();
                
        }

        private AddressRepository addressRepository { get; set; }

        ///<summary>
        ///Retrieve one customer
        ///</summary>
        public Customer Retrieve( int customerId)
        { 
//create the instance of the customer class
// pass in the requested id
Customer customer = new Customer(customerId); 
            if (customerId == 1)
            {
               
                customer.EmailAddress = "ffff@mm.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins"; 
                customer.AddressList = addressRepository.RetrrieveByCustomerId(customerId).
                    ToList();
            }
            return customer;    
        }
        ///<summary>
        ///Saves the current order item
        ///</summary>
        /// <returns></returns>
        public bool Save(Customer customer )  
        { 
            // code that sves the passed in customer
            return true;
        }
        
    }
}
