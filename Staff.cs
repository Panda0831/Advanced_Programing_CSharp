namespace CSharp_Assignment1
{
  class Staff : Person
  {
    //Fields
    string staffID;

    //Properties
    public string StaffID
    {
      get { return staffID; }
      set { staffID = value; }
    }
    public Student Student { get; set; }

    //Constructors
    public Staff()
    {
    }
    public Staff(string staffID, string name, DateTime dateOfBirth, string email, string phone, string address, Student student) : base(name, dateOfBirth, email, phone, address)
        {
            this.staffID = staffID;
            Student = student;
        }

        //Methods
        public void InputInformation()
    {
      bool uniqueID = false;
      while (!uniqueID)
      {
        Console.WriteLine("Enter staff's ID: ");
        staffID = Console.ReadLine();

        // Check if the staff ID already exists
        bool staffIDExists = Program.staffs.Any(s => s.StaffID == staffID);
        if (!staffIDExists)
        {
          uniqueID = true;
        }
        else
        {
          Console.WriteLine("Staff ID already exists. Please re-enter.");
        }
      }
      Console.WriteLine("Enter staff's name: ");
      Name = Console.ReadLine();
      Console.WriteLine("Enter staff's email: ");
      Email = Console.ReadLine();
      bool validDate = false;
      while (!validDate)
      {
        Console.WriteLine("Enter staff's date of birth: ");
        try
        {
          DateOfBirth = DateTime.Parse(Console.ReadLine());
          validDate = true;
        }
        catch (System.FormatException)
        {
          Console.WriteLine("Invalid date. Please re-enter.");
        }
      }
      Console.WriteLine("Enter staff's phone: ");
      Phone = Console.ReadLine();
      Console.WriteLine("Enter staff's address: ");
      Address = Console.ReadLine();

    }
    //Override methods
    public override void DisplayInformation()
    {
      Console.WriteLine("==============STAFF INFORMATION==============");
      Console.WriteLine(" |Staff ID: " + staffID);
      Console.WriteLine(" |Name: " + Name);
      Console.WriteLine(" |Date of birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
      Console.WriteLine(" |Email: " + Email);
      Console.WriteLine(" |Phone: " + Phone);
      Console.WriteLine(" |Address: " + Address);
      Console.WriteLine("=============================================");

    }
    public override void UpdateInformation(string staffID)
    {
      Staff staff = Program.staffs.FirstOrDefault(s => s.StaffID == staffID);
      Presentator presentator = new Presentator();
      if (staff != null)
      {
        Console.WriteLine("Enter staff's name: ");
        staff.Name = Console.ReadLine();
        Console.WriteLine("Enter staff's email: ");
        staff.Email = Console.ReadLine();
                bool validDate = false;
                while (!validDate)
                {
                    Console.WriteLine("Enter staff's date of birth: ");
                    try
                    {
                        staff.DateOfBirth = DateTime.Parse(Console.ReadLine());
                        validDate = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid date. Please re-enter.");
                    }
                }
                Console.WriteLine("Enter staff's phone: ");
        staff.Phone = Console.ReadLine();
        Console.WriteLine("Enter staff's address: ");
        staff.Address = Console.ReadLine();
        presentator.DisplayUpdateSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStaffNotExistMessage();
      }
    }

    public override void DeleteInformation(string staffID)
    {
      Staff staff = Program.staffs.FirstOrDefault(s => s.StaffID == staffID);
      Presentator presentator = new Presentator();
      if (staff != null)
      {
        Program.staffs.Remove(staff);
        presentator.DisplayDeleteSuccessfulMessage();
      }
      else
      {
        presentator.DisplayStaffNotExistMessage();
      }
    }
  }
}
