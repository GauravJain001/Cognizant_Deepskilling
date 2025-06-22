using System;
namespace code
{
    class StudentController
    {
        Student model;
        StudentView view;
        //dependency Injection
        public StudentController(Student student, StudentView view)
        {
            this.model = student;
            this.view = view;
        }
        public void updateName(string Name)
        {
            model.Name = Name;
            // Console.WriteLine("Name Updated");
        }
        public void updateGrade(char Grade)
        {
            model.Grade = Grade;
        }
        public void updateId(int Id)
        {
            model.Id = Id;
        }
        public String getName()
        {
            return model.Name;
        }
        public int getId()
        {
            return model.Id;

        }
        public char getGrade()
        {
            return model.Grade;
        }
        public void DisplayStudentDetails()
        {
            view.DisplayStudentDetails(model);
        }
    }
}