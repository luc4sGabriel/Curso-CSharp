using System;

namespace ExtensionsMethod {
    class Program {
        
        public static void Main() {
            DateTime dt = new DateTime(2021, 8, 12, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good Morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }

    }
}
