using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{

    //3. Create Product class, add code, name, price . Accept product details, if price >1000 give 10 % discount on product. & display discounted price.

    internal class Product
    {
        private int code;
        private string name;
        private double price, discount, discprice;

        public Product(int code, string name, double price, double discount)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.discount = discount;   
        }

        public void CalDiscount() {

            if (price > 1000)
            {
                discount = price * 0.1;
                discprice = price - discount;

            }
            else {
                discprice = price - discount;
            }
            
        }

        public void Display() {

            Console.WriteLine($"Code: {code}, Name:{name}, Price:{price}, Discount:{discount}, DiscPrice:{discprice}");
        }
    }
}
