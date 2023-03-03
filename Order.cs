using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
       
        public Order():this(0)
        {

        }
        public Order(int orerId)
        {
            OrderId = OrderId;
            OrderItems = new List<OrderItem>();
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int   ShippingAddressId { get; set; } 
        public override string ToString() => $"OrderDate.Value.Date ({OrderId})";
       

       


        ///<summary>
        ///validates the order data
        ///</summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }




    }
}

