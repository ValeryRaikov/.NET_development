using System;
using System.Collections.Generic;

namespace SchoolApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director1 = new Director("Alice Johnson", 50, 'F');
            Director director2 = new Director("Bob Smith", 55, 'M');

            // Create a School with Initial Director
            School school = new School("Greenwood High", director1);
            Console.WriteLine($"School Created: {school}");
            Console.WriteLine($"Initial Director: {school.Director}");

            // Attempt to Change to the Same Director
            school.ChangeDirector(director1);

            // Change Director
            school.ChangeDirector(director2);
            Console.WriteLine($"Updated Director: {school.Director}");

            // Create Teachers
            Teacher teacher1 = new Teacher("John Doe", 40, 'M', 10);
            Teacher teacher2 = new Teacher("Emily Clark", 35, 'F', 25);

            // Hire Teachers
            school.HireNewTeacher(teacher1);
            school.HireNewTeacher(teacher2);

            // Attempt to Hire the Same Teacher Again
            school.HireNewTeacher(teacher1);

            // Display List of Teachers
            school.DisplayStaff();

            // Fire a Teacher
            school.FireTeacher(teacher1);

            // Attempt to Fire the Same Teacher Again
            school.FireTeacher(teacher1);

            // Display Final List of Teachers
            school.DisplayStaff();

            // Hire Teacher
            school.HireNewTeacher(teacher1);

            // Create School Classes
            SchoolClass classA = new SchoolClass(10);
            SchoolClass classB = new SchoolClass(11);

            // Assign Teachers to Classes
            teacher1.TakeClass(classA);
            teacher2.TakeClass(classB);

            // Create Students
            Student student1 = new Student("Michael Brown", 16, 'M', new List<string> { "Mathematics", "English" });
            Student student2 = new Student("Sarah Lee", 15, 'F', new List<string> { "Mathematics", "English", "History" });
            Student student3 = new Student("Bradley Martin", 16, 'M', new List<string> { "Geography", "French", "Biology" });
            Student student4 = new Student("Jennie Smith", 15, 'F', new List<string> { "Physics", "Russian", });

            // Enroll Students in Classes
            teacher1.AddStudent(classA, student1);
            teacher1.AddStudent(classA, student2);
            teacher2.AddStudent(classB, student3);
            teacher2.AddStudent(classB, student4);

            // Add Grades for Students
            Grade mathGrade1 = new Grade("Mathematics", 5.5);
            Grade mathGrade2 = new Grade("Mathematics", 6);
            Grade englishGrade = new Grade("English", 4.25);
            Grade biologyGrade = new Grade("Biology", 3);
            Grade russianGrade1 = new Grade("Russian", 6);
            Grade russianGrade2 = new Grade("Russian", 6);

            teacher1.AddStudentGrade(student1, mathGrade1);
            teacher1.AddStudentGrade(student1, englishGrade);
            teacher1.AddStudentGrade(student2, mathGrade2);
            teacher2.AddStudentGrade(student3, biologyGrade);
            teacher2.AddStudentGrade(student4, russianGrade1);
            teacher2.AddStudentGrade(student4, russianGrade2);

            // Display Student Notebook
            student1.DisplayNoteBook();
            student4.DisplayNoteBook();

            // Display Student Absences
            student2.DisplayAbsences();
            student3.DisplayAbsences();

            Console.WriteLine("\nTesting Completed Successfully!");

            Console.ReadKey();
        }
    }
}
