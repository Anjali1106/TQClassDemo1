using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    //4. Create Book class, add bid, name, price, author. Accept the details & display using constructor

   
    internal class Book
    {

        private int bid, price;
        private string name, author;

        public Book(int bid, int price, string name, string author)
        {
            this.bid = bid;
            this.price = price;
            this.name = name;
            this.author = author;
        }

        public void display() {
            Console.WriteLine($"Bid: {bid}, Price:{price}, Name:{name}, Author:{author}");
        }
    }
}
