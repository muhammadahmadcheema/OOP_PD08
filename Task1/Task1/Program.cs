using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ahmad", "Wapda Town");
            Console.WriteLine(p1.getName());
            Console.WriteLine(p1.getAddress());

            p1.setAddress("Gulberg");
            Console.WriteLine(p1.getAddress());
            Console.WriteLine(p1.toString());

            Console.WriteLine(" ");

            Student student1 = new Student("Ali", "Model Town", "BSCS", 2, 50000);
            Console.WriteLine(student1.getName());
            Console.WriteLine(student1.getAddress());
            Console.WriteLine(student1.getProgram());
            Console.WriteLine(student1.getFee());
            Console.WriteLine(student1.getYear());
            Console.WriteLine("  ");




            student1.setFee(25999);
            student1.setAddress("Faisal Town");
            student1.setYear(3);
            student1.setProgram("Gender Studies");
            Console.WriteLine(student1.toString());
            



        }
    }
}
