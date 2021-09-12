using System;
using System.Linq;

namespace Linq {
    class Program {
        static void Main(string[] args) {
            
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers.
                Where(n => n % 2 == 0).
                Select(n => n * 10);
            
            // Execute the query
            foreach (var num in result) {
                Console.WriteLine(num);
            }
        }
    }
}
