using System;
using System.Collections.Generic;
using System.Linq;
using PracticalExerciseLinq.Entities;
using System.IO;
using System.Globalization;

namespace PracticalExerciseLinq {
    class Program {

        static void Print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach (T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {

            //path = C:\Users\DMess\Documents\testfolder\employees.txt
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using(StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] vect = sr.ReadLine().Split(',');
                    string name = vect[0];
                    string email = vect[1];
                    double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name,email,salary));    
                }

                Console.WriteLine("Email of people whose salary is more than " + sal);

                var listEmails = list.Where(e => e.Salary > sal).OrderBy(e => e.Email).Select(e => e.Email);

                var sumSalarys = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Print(null,listEmails);
                Console.WriteLine("Sum of salary of the people whose name starts with 'M': " + sumSalarys.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
