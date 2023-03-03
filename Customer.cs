using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer 

    {
        private bool isValid;
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList =new List<Address>();   
        }
        public List<Address> AddressList { get; set; }

        public Address WorkAddress { get; set; }    
        public Address HomeAddress { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public int CustomerType { get; set; }
        public string FullName
        {
            get
            {

                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;
        ///<summary>
        ///validates the customer data
        ///</summary>
        ///<returns> </returns>
        public bool Validate()
        {
          
            var invalid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
  

