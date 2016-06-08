namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(numberOfStudents);
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = studentArgs[0];
                List<double> grades = studentArgs
                    .Skip(1)
                    .Select(double.Parse)
                    .ToList();
                Student newStudent = new Student(name, grades);
                students.Add(newStudent);
            }

            List<Student> highGradeStudents = students
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();
            Console.WriteLine(string.Join("\n", highGradeStudents));
        }
    }

    public class Student
    {
        public Student(string name, IList<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            this.AverageGrade = this.CalculateAverageGrades();
        }

        public string Name { get; set; }

        public IList<double> Grades { get; set; }

        public double AverageGrade { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} -> {1:F2}", this.Name, this.AverageGrade);
        }

        private double CalculateAverageGrades()
        {
            return this.Grades.Average();
        }
    }
}