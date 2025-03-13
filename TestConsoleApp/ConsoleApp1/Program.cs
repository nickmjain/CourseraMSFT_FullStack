using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("Student Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Grade to Student");
            Console.WriteLine("3. View Student Data");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option (1-4):");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent(students);
                    break;
                case "2":
                    AddGradeToStudent(students);
                    break;
                case "3":
                    ViewStudentData(students);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter student ID:");
        string id = Console.ReadLine();

        students.Add(new Student(name, id));
        Console.WriteLine("Student added successfully.");
    }

    static void AddGradeToStudent(List<Student> students)
    {
        Console.WriteLine("Enter student ID:");
        string id = Console.ReadLine();
        Student student = students.Find(s => s.ID == id);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.WriteLine("Enter subject:");
        string subject = Console.ReadLine();
        Console.WriteLine("Enter grade:");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            try
            {
                student.SetGrade(subject, grade);
                Console.WriteLine("Grade added successfully.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid grade input.");
        }
    }

    static void ViewStudentData(List<Student> students)
    {
        Console.WriteLine("Enter student ID:");
        string id = Console.ReadLine();
        Student student = students.Find(s => s.ID == id);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        student.DisplayStudentInfo();
    }
}
