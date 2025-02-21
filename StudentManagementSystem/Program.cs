using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    // Abstraction: Abstract class Person
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void DisplayInfo();
    }

    // Encapsulation: Student class with private fields
    class Student : Person
    {
        private string studentID;
        private List<string> courses = new List<string>();

        public Student(string name, int age, string studentID)
        {
            this.Name = name;
            this.Age = age;
            this.studentID = studentID;
        }

        public void EnrollCourse(string course)
        {
            courses.Add(course);
            Console.WriteLine($"{Name} enrolled in {course}.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, ID: {studentID}");
            Console.WriteLine("Courses Enrolled: " + string.Join(", ", courses));
        }
    }

    // Inheritance: Teacher class inheriting from Person
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
        {
            this.Name = name;
            this.Age = age;
            this.Subject = subject;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher: {Name}, Age: {Age}, Teaches: {Subject}");
        }
    }

    // Polymorphism: Using a single method to display both student and teacher info
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Student Object
            Student student1 = new Student("Alice", 20, "S1001");
            student1.EnrollCourse("C# OOP");
            student1.EnrollCourse("SQL Basics");

            // Creating Teacher Object
            Teacher teacher1 = new Teacher("Mr. John", 35, "C# Programming");

            // Displaying Information
            Console.WriteLine("\n=== School System ===");
            student1.DisplayInfo();
            Console.WriteLine();
            teacher1.DisplayInfo();
        }
    }
}
