using System;
using Generics.Entities;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Seu Walter","teste@gmail.com");
            Client b = new Client("Seu Alex", "teste2@gmail.com");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
