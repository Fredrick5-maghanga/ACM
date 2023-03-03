using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        ///<summary>
        ///Retrieve one order
        ///</summary>
        public Order Retrieve(int orderId)
        {
            //create the instance of the order class
            // pass in the request id

            Order order = new Order(orderId);

            // code that retrieves the defined order
            // Temporary hard-coded values to return
            //a populated order
            if (orderId == 10)
            {
                // use current year in hard - coded data

                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;   
        }
        ///<summary>
        ///saves the current order
        ///</summary>
        
       public bool save(Order order)
        {
            //code that saves the passed orer
            return true;
        }
    }
}
