using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person  student1 = new Student("Zakaria","Chittagong",28,"Kamal","Rehana",20,5,"B");
            Student student2 = new Student("Mridul", "Chittagong", 23, "Balal", "Kona", 21, 5, "B");

            Console.WriteLine(student1.Name);  //student1 can't to access Class,Roll,Section because of variable datatype is person and it's can't avalable in base class(Person).
            Console.WriteLine(student2.Class); //student2 can access everything because of datatype is child class(Student).
        }
    }
}


