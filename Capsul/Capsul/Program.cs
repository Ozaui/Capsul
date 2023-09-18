using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.setName("Özay");
            Console.WriteLine(student.getName());

            student.HEIGHT = 50;
            Console.WriteLine(student.HEIGHT);

            Console.ReadLine();
        }
    }
}