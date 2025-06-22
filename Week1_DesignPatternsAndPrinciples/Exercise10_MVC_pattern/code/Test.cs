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

            //Creating the controller and injecting the model
            StudentController controller = new StudentController(student);

            //Displaying initial student details using the view
            view.DisplayStudentDetails(student);

            //Updating model data via the controller
            controller.updateName("Ram");
            controller.updateGrade('B');
            controller.updateId(102);

            //Displaying updated student details
            view.DisplayStudentDetails(student);
        }
    }
}
