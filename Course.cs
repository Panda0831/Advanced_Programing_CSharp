namespace CSharp_Assignment1
{
  class Course
  {
    //Fields
    private string courseName;
    private List<Course> courses;

    //Properties
    public string CourseName
    {
      get { return courseName; }
      set { courseName = value; }
    }
    public List<Course> Courses
    {
      get { return courses; }
      set { courses = value; }
    }

    //Constructors
    public Course()
    {
    }

    public Course(string courseName, List<Course> courses)
    {
      this.courseName = courseName;
      this.courses = courses;
    }

    //Methods
    public void InputInformation()
    {
      Console.WriteLine("Enter course's name: ");
      CourseName = Console.ReadLine();
    }

    public void DisplayInformation()
    {
      Console.WriteLine("==============COURSE INFORMATION=============");
      Console.WriteLine(" Course name: " + CourseName);
    }
    public void DeleteCourse(string courseName)
        {

            Course course = Program.courses.Find(c => c.courseName == courseName);
            if (course != null)
            {
                Program.courses.Remove(course);
                Console.WriteLine("  The information is deleted successfully");
            }
            else
            {
                Console.WriteLine("  The information is NOT deleted successfully");
            }
        }
    }
}