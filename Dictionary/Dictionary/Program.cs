using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("Hello World!");

            Dictionary<string, string> cookie = new Dictionary<string, string>();

            cookie["user"] = "maria";
            cookie["email"] = "maria@gmail.com";
            cookie["phone"] = "8768744";
            cookie["phone"] = "6358764";

            Console.WriteLine("Imprime tudo: ");
            foreach (KeyValuePair<string,string> k in cookie) {
                Console.WriteLine(k);
            }
            */
            //C:\Users\DMess\Documents\testfolder\election.txt

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> set = new Dictionary<string, int>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {

                        string[] votingMachine = sr.ReadLine().Split(',');
                        string candidate = votingMachine[0];
                        int votes = int.Parse(votingMachine[1]);
                        
                        if (set.ContainsKey(candidate)) {
                            set[candidate] += votes;
                        }
                        else {
                            set[candidate] = votes;
                        }
                    }

                    foreach (var item in set) {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
