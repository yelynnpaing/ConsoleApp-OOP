using System;
using System.Data.SqlTypes;
using System.Xml.Linq;

class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new (){ StudentId = 1, StudentName = "mg mg", Grade = 80 },
            new (){ StudentId = 2, StudentName = "tun tun", Grade = 90 },
            new (){ StudentId = 3, StudentName = "mya mya", Grade = 97 },
            new (){ StudentId = 4, StudentName = "aye aye", Grade = 49 }
        };
                
        Console.WriteLine("Student List - ");
        foreach(var student in students)
        {
            Console.WriteLine($"Id - {student.StudentId} , Name - {student.StudentName}, Grade - {student.Grade}");
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");

        Console.WriteLine("Filter Students with Grade > num");
        var TopGradeStudents = students.Where(student => student.Grade >= 80);
        foreach(var student in TopGradeStudents)
        {
            Console.WriteLine($"Name - {student.StudentName} , Grade = {student.Grade}");
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");

        Console.WriteLine("Transform into Anonymous Types (Project with Select)");
        var newFormStudentList = students.Select(student => new { student.StudentName, student.Grade });
        foreach(var s in newFormStudentList)
        {
            Console.WriteLine($"Name is {s.StudentName} and Grade is {s.Grade}");
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        
        Console.WriteLine("Order Students by Grade (Descending)");
        var orderedStudents = students.OrderByDescending(s => s.Grade);
        foreach(var s in orderedStudents)
        {
            Console.WriteLine($"Name - {s.StudentName} , Grade - {s.Grade}");
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        
        Console.WriteLine("Get Top 2 Students");
        var topStudents = students.OrderByDescending(s => s.Grade).Take(2);
        foreach (var s in topStudents)
        {
            Console.WriteLine($"Name - {s.StudentName} , Grade - {s.Grade}");
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
       
        Console.WriteLine("Check if All Passed");
        bool allPassed = students.All(s => s.Grade >= 50);        
        Console.WriteLine($"All Pass - {allPassed}");       
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        
        Console.WriteLine("Find First Student");
        var topStudent = students.FirstOrDefault(s => s.Grade > 90);
        Console.WriteLine($"Top student => Name - {topStudent.StudentName} , Grade - {topStudent.Grade}");
    }
}


















