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
        String product_type;
        String product_name;
        Double product_price;
        String img_path = "";

        public Product()
        {
            product_id = id;
            product_type = "Unknown";
            product_name = "No description";
            product_price = 0.00;
            img_path = "";

            id++;
        }

        public Product(String type, String name, Double price)
        {
            product_id = id;
            product_type = type;
            product_name = name;
            product_price = price;
            img_path = "";

            id++;
        }

        public Product(String type, String name, Double price, String path)
        {
            product_id = id;
            product_type = type;
            product_name = name;
            product_price = price;
            img_path = path;

            id++;
        }

        public void printString()
        {
            String result = 
                $"Product ID: {product_id}\n" +
                $"Product Name: {product_type}\n" +
                $"Product Description: {product_name}\n" +
                $"Product Price: {product_price}";

            Console.WriteLine(result);
        }

        override public String ToString()
        {
            String result =
                $"Product ID: {product_id}\t" +
                String.Format($"Product Type: {product_type, -25}\t") +
                String.Format($"Product Name: {product_name, -60}\t") +
                String.Format($"Product Price: {product_price, -15}");

            return result;
        }
    }
}
