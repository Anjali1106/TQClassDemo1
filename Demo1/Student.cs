using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Student
    {

        //WAP to create a class Student, accept the rollno, name & 3 subjects marks from constructor, create a method to calculate total marks & percentage.Print the details of students.

        private int rollno, sm1, sm2, sm3, total;
        private string name;
        private double percentage;

        public Student(int rn, int m1, int m2, int m3 ) { 
            rollno= rn;
            sm1= m1;
            sm2= m2;    
            sm3= m3;
        }

        // calculate total
        public void calTotal() {
            total = sm1+sm2+ sm3;
        }

        public void calPer() {
            percentage = total / 3;
        }

        public void print() {
            Console.WriteLine($"Total: {total} Percentage:{percentage}");
        }
    }
}
