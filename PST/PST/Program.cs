using PST.Models;
using System;

namespace PST
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Vasif";
            student1.Surname = "Vasifov";
            student1.Age = 20;

            Student student2 = new Student();
            student2.Name = "Asif";
            student2.Surname = "Asifov";

            Group group1 = new Group();

            group1.AddStudent(student1);
            group1.AddStudent(student2);


            //Console.WriteLine(group.students);

            foreach (Student student in group1.students)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age);
            }
        }
    }
}
