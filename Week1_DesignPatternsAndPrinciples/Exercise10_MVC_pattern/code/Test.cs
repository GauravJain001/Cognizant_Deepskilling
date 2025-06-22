using System;

namespace code
{
    class Test
    {
        static void Main(string[] args)
        {
            //Creating the model (Student)
            Student student = new Student("Gaurav", 101, 'A');
            //Creating the view
            StudentView view = new StudentView();
            //Creating the controller and injecting the model and view
            StudentController controller = new StudentController(student,view);
            //Displaying initial student details using the controller
            controller.DisplayStudentDetails();
            //Updating model data via the controller
            controller.updateName("Ram");
            controller.updateGrade('B');
            controller.updateId(102);
            //Displaying updated student details
            controller.DisplayStudentDetails();
        }
    }
}
