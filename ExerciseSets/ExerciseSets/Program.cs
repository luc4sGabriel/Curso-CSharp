using System.Collections.Generic;
using System;
using ExerciseSets.Entities;

namespace ExerciseSets {
    class Program {
        static void Main(string[] args) {

            HashSet<Student> set = new HashSet<Student>();
            
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for(int i=0; i < a; i++) {
                string registration = Console.ReadLine();
                set.Add(new Student(registration));
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++) {
                string registration = Console.ReadLine();
                set.Add(new Student(registration));
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++) {
                string registration = Console.ReadLine();
                set.Add(new Student(registration));
            }

            Console.WriteLine("Total Students: " + set.Count);
        }
    }
}
