using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Mutaf", "UET Lahore", "BS CS", 2024, 2500.0F);
            student.setName("Amaan");

            Console.WriteLine(student.toString());

            Staff staff = new Staff("Ali", "Sialkot", "UET", 2000);
            staff.setName("Farhan");

            Console.WriteLine(staff.toString());

            Console.ReadKey();
        }
    }
}
