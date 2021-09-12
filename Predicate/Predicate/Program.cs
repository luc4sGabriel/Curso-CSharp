using System.Collections.Generic;
using System;
using Predicate.Entities;
using System.Linq;

namespace Predicate {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*list.ForEach(p => p.Price += p.Price * 0.1);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            */

            /*list.RemoveAll(p => p.Price >= 100);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            */

            List<string> res = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string item in res) {
                Console.WriteLine(item);
            }

            //------------- Sem o Linq (Select)  | -----------
            //                                  \ /
            //                                   v

            List<string> result = new List<string>();

            foreach (var item in list) {
                result.Add(item.Name.ToUpper());
            }

            foreach (var item in result) {
                Console.WriteLine(item);
            }

        }
    }
}
