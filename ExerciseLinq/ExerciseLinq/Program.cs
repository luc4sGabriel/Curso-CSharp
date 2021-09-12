using System;
using System.IO;
using ExerciseLinq.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace ExerciseLinq {
    class Program {
        static void Print<T>(string? message, IEnumerable<T> collection) {
            System.Console.WriteLine(message);
            foreach (T obj in collection) {
                System.Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
            static void Main(string[] args) {
                //C:\Users\DMess\Documents\testfolder\products.txt

                List<Product> list = new List<Product>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {

                        string[] products = sr.ReadLine().Split(',');
                        string name = products[0];
                        double price = double.Parse(products[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name,price));
                    }
                        double ave = list.Select(p => p.Price).Average();
                        Console.Write("Average price: " + ave.ToString("F2", CultureInfo.InvariantCulture));
                        

                        var listAllByName = list.Where(p => p.Price < ave).OrderByDescending(p => p.Name).Select(p => p.Name);
                        Print(null,listAllByName);

                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
