using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {

        // WAP to create a class Student, accept the rollno, name & 3 subjects marks from constructor, create a method to calculate total marks & percentage.Print the details of students.
         
        static void Main(string[] args)
        {

            //Student s1 = new Student(1, 70, 80, 90);
            //s1.calTotal();
            //s1.calPer();
            //s1.print();

            //Bank b1 = new Bank(10000, 200);
            //b1.deposit(300);
            //b1.withdraw(500);
            //b1.display();

            //Product p1 = new Product(101, "Mouse", 5000, 1000);
            //p1.CalDiscount();
            //p1.Display();


            Book b = new Book(1, 300, "Shyamchi Aai", "Sane Guruji");
            b.display();
        }
    }
}
