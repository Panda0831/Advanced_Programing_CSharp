namespace CSharp_Assignment1
{
  class Presentator
  {
    //Method
    public void DisplayMenu()
    {
      Console.WriteLine("=========GREENWICH MANAGEMENT SYSTEM=========");
      Console.WriteLine("1 | Add new course                          |");
      Console.WriteLine("2 | Add new student's information           |");
      Console.WriteLine("3 | Display specific course information     |");
      Console.WriteLine("4 | Display specific student information    |");
      Console.WriteLine("5 | Show all courses in the system          |");
      Console.WriteLine("6 | Show all students in the system         |");
      Console.WriteLine("7 | Update specific student by their ID     |");
      Console.WriteLine("8 | Delete specific student by their ID     |");
      Console.WriteLine("9 | Add new staff's information             |");
      Console.WriteLine("10| Display specific staff information      |");
      Console.WriteLine("11| Show all staffs in the system           |");
      Console.WriteLine("12| Update specific staff by their ID       |");
      Console.WriteLine("13| Delete specific staff by their ID       |");
      Console.WriteLine("14| Delete Course                           |");
      Console.WriteLine("15| Exit the program                        |");
      
      Console.WriteLine("=============================================");
      Console.WriteLine("        Please choose your option:           ");
    }

    public void DisplaySuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("   The information is added successfully");
    }

    public void DisplayUpdateSuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("  The information is updated successfully");
    }

    public void DisplayDeleteSuccessfulMessage()
    {
      Console.WriteLine("=============================================");
      Console.WriteLine("  The information is deleted successfully");
    }

    public void DisplayStudentNotExistMessage()
    {
      Console.WriteLine("==============STUDENT INFORMATION============");
      Console.WriteLine("          The student is not existed      ");
    }

    public void DisplayStaffNotExistMessage()
    {
      Console.WriteLine("===============STAFF INFORMATION=============");
      Console.WriteLine("          The staff is not existed      ");
    }

    public void DisplayCourseNotExistMessage()
    {
      Console.WriteLine("==============COURSE INFORMATION=============");
      Console.WriteLine("          The course is not existed      ");
    }

    public void Exit()
    {
      Console.WriteLine("Thank you for using our system");
    }
  }
}