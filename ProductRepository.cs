using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<summary>
        ///Retrieve one product
        ///</summary>
        public Product Retrieve(int productId)
        {
            //create the instance of the  class
            // pass in the requested id
            Product product = new Product(productId);

            //code that retrieves the defined product
            // a populated product
            if (productId == 2)
            {

                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size of 4 Bright yellow mini sunflowers";
                product.CurrentPrice = 15.98M;   
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }
        ///<summary>
        ///Saves the current product
        ///</summary>
        /// <returns></returns>
       

        /// -- EntityBase Save code

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid) 
                { 
                if (product.IsNew) 
                    {
                        //call an Insert Stored Procedure
                    }
                else 
                    {
                        //call an update stored procedure
                    }
                        
                }
                else
                { 
                    success = false;
                }
            }
            // code that sves the passed in product
            return success;
        }

    }
}

