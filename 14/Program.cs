using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GradePoint { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Azad", GradePoint = 800 },
            new Student { Id = 2, Name = "Azad1", GradePoint = 700 },
            new Student { Id = 3, Name = "Azad2", GradePoint = 650 },
            new Student { Id = 4, Name = "Azad3", GradePoint = 900 },
            new Student { Id = 5, Name = "Azad4", GradePoint = 750 },
            
        };

       
        Console.Write("Which maximum grade point (1st, 2nd, 3rd, ...) you want to find: ");
        int rank = int.Parse(Console.ReadLine());

        var nthMaxGradePoint = students.OrderByDescending(student => student.GradePoint)
                                      .Distinct()
                                      .Skip(rank - 1)
                                      .FirstOrDefault();

        
        if (nthMaxGradePoint != null)
        {
            Console.WriteLine("Id: " + nthMaxGradePoint.Id +
                              ", Name: " + nthMaxGradePoint.Name +
                              ", Grade Point: " + nthMaxGradePoint.GradePoint);
        }
        else
        {
            Console.WriteLine("No student found for the given rank.");
        }

      
    }
}