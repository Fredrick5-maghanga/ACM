using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem 
    { public OrderItem()
        { 
        }
        public OrderItem(int OrderItemId)
        {
            OrderItemId = OrderItemId;
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        ///<summary>
        ///Retrieve one Order item
        ///</summary>
       
        public OrderItem Retrieve(int OrderItemId)
        {
            //code that retrieves the defined order item
        return new OrderItem(OrderItemId);
        }
        ///<summary>
        ///Saves the current order item
        ///</summary>
        /// <returns></returns>
        
        public bool save()
        { 
            //code that saves the defined order item
            return true;
        }
        ///<summary>
        ///validates the current order item
        ///</summary>
        /// <returns></returns>
        
        public bool Validates()
        { 
            var isValid = true;
            if (Quantity<=0) isValid = false;
            if (ProductId<=0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            
            return isValid;

        }

    }
}
