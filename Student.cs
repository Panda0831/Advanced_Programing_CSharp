namespace CSharp_Assignment1
{
  class Student : Person
  {
    //Fields
    string studentID;
    private List<Course> courses;

    //Properties
    public string StudentID
    {
      get { return studentID; }
      set { studentID = value; }
    }
    public List<Course> Courses
    {
      get { return courses; }
      set { courses = value; }
    }

    //Constructors
    public Student()
    {
      courses = new List<Course>();
    }
    public Student(string studentID, List<Course> courses, string name, DateTime dateOfBirth, string email, string phone, string address) : base(name, dateOfBirth, email, phone, address)
    {
      this.studentID = studentID;
      this.courses = courses;
    }

    //Override methods
    public void InputInformation(List<Course> courses)
    {
      bool uniqueID = false;
      while (!uniqueID)
      {
        Console.WriteLine("Enter student's ID: ");
        studentID = Console.ReadLine();

        // Check if the student ID already exists
        bool studentIDExists = Program.students.Any(s => s.StudentID == studentID);
        if (!studentIDExists)
        {
          uniqueID = true;
        }
        else
        {
          Console.WriteLine("Student ID already exists. Please re-enter.");
        }
      }
      Console.WriteLine("Enter student's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter student's email: ");
      Email = Console.ReadLine();
      bool validDate = false;
      while (!validDate)
      {
        Console.WriteLine("Enter student's date of birth: ");
        try
        {
          DateOfBirth = DateTime.Parse(Console.ReadLine());
          validDate = true;
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Invalid date format. Please enter a valid date.");
        }
      }
      Console.WriteLine("Enter student's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter student's address: ");
      Address = Console.ReadLine();
      Console.WriteLine("Enter student's course: ");
      string courseName = Console.ReadLine();

      // Find the course with the given name in the list of courses
      Course course = courses.FirstOrDefault(c => c.CourseName == courseName);

      if (course == null)
      {
        // If the course doesn't exist, create a new course object and add it to the list of courses
        course = new Course(courseName, new List<Course>());
        courses.Add(course);
      }

      // Add the course to the list of courses for this student
      Courses.Add(course);
    }

    public override void DisplayInformation()
    {
      Console.WriteLine("=============STUDENT INFORMATION=============");
      Console.WriteLine(" |Student ID: " + StudentID);
      Console.WriteLine(" |Name: " + Name);
      Console.WriteLine(" |Date of birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
      Console.WriteLine(" |Email: " + Email);
      Console.WriteLine(" |Phone: " + Phone);
      Console.WriteLine(" |Address: " + Address);
      Console.WriteLine(" |Courses: " );
      foreach (Course c in Courses)
      {
        Console.WriteLine("   - " + c.CourseName);
      }
      Console.WriteLine("=============================================");
      }

    public override void UpdateInformation(string studentID)
    {
      Student student = Program.students.FirstOrDefault(s => s.StudentID == studentID);
      Presentator presentator = new Presentator();
      if (student != null)
      {
        Console.WriteLine("Enter student's name: ");
        student.Name = Console.ReadLine();
        Console.WriteLine("Enter student's email: ");
        student.Email = Console.ReadLine();
        Console.WriteLine("Enter student's date of birth: ");
        bool validDate = false;
            while (!validDate)
                {
                    Console.WriteLine("Enter student's date of birth: ");
                    try
                    {
                        student.DateOfBirth = DateTime.Parse(Console.ReadLine());
                        validDate = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid date format. Please enter a valid date.");
                    }
                }
        Console.WriteLine("Enter student's phone: ");
        student.Phone = Console.ReadLine();
        Console.WriteLine("Enter student's address: ");
        student.Address = Console.ReadLine();
        Console.WriteLine("Enter student's course: ");
        string courseName = Console.ReadLine();
        //Clear the list of previous courses for this
        student.Courses.Clear();
        //Add new course to the list of courses for this student
        Course course = Program.courses.FirstOrDefault(c => c.CourseName == courseName);

        if (course == null)
        {
          // If the course doesn't exist, create a new course object and add it to the list of courses
          course = new Course(courseName, new List<Course>());
          Program.courses.Add(course);
        }

        // Add the course to the list of courses for this student
        student.Courses.Add(course);
        presentator.DisplayUpdateSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStudentNotExistMessage();
      }
    }
    //DeleteInformation
    public override void DeleteInformation(string studentID)
    {
      Presentator presentator = new Presentator();
      Student student = Program.students.FirstOrDefault(s => s.StudentID == studentID);
      if (student != null)
      {
        Program.students.Remove(student);
        student.Courses.Clear();
        presentator.DisplayDeleteSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStudentNotExistMessage();
      }
    }
  }
}
