using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement_Easy
{
    class Product
    {
        private static int id = 1;

        int product_id;
        String product_name;
        String product_description;
        Double product_price;

        public Product()
        {
            product_id = id;
            product_name = "Unknown";
            product_description = "No description";
            product_price = 0.00;

            id++;
        }

        public Product(String name, String desc, Double price)
        {
            product_id = id;
            product_name = name;
            product_description = desc;
            product_price = price;

            id++;
        }

        public void toString()
        {
            String result = 
                $"Product ID: {product_id}\n" +
                $"Product Name: {product_name}\n" +
                $"Product Description: {product_description}\n" +
                $"Product Price: {product_price}";

            return result;
        }
    }
}
