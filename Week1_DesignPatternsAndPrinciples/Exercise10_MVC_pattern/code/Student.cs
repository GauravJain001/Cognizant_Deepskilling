using System;
namespace code
{
    class Student
    {
        public string Name;
        public int Id;
        public char Grade;

        public Student(string Name, int Id, char Grade)
        {
            this.Name = Name;
            this.Grade = Grade;
            this.Id = Id;
        }

    }
}