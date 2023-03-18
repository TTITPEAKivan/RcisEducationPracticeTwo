using System;
using Microsoft.VisualBasic;

namespace student
{
    public class Student
    {
        private string Surname;
        private string DateOfBirthday;
        private int NumberOfGroup;
        private int[] grades;

        public Student()
        {
            this.Surname = "Яковлев";
            this.DateOfBirthday = "04.10.2004";
            this.NumberOfGroup = 621;
            this.grades = new int[] { 3, 4, 4, 5, 5 };
        }
        public void Redactor(string surname, string date, int group, int[] grade)
        {
            this.Surname = surname;
            this.DateOfBirthday = date;
            this.NumberOfGroup = group;
            this.grades = grade;
            Info();
        }
        public void Info()
        {
           Console.WriteLine($"Surname: {this.Surname}, Birthday: {DateOfBirthday}, Number of group: {this.NumberOfGroup} ");
           Console.WriteLine("Успеваемость студента: ");
           foreach (int i in grades)
           {
               Console.Write(i + " ");
           }
        }
    }
}
    
