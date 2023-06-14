namespace CSharp_Assignment1
{
  public abstract class Person
  {
    //Fields
    private string name;
    private DateTime dateOfBirth;
    private string email;
    private string phone;
    private string address;

    //Properties
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public string Address
    {
      get { return address; }
      set { address = value; }
    }
    public string Phone
    {
      get { return phone; }
      set { phone = value; }
    }
    public string Email
    {
      get { return email; }
      set { email = value; }
    }
    public DateTime DateOfBirth
    {
      get { return dateOfBirth; }
      set { dateOfBirth = value; }
    }

    //Constructors
    public Person()
    {
    }

    public Person(string name, DateTime dateOfBirth, string email, string phone, string address)
    {
      this.name = name;
      this.dateOfBirth = dateOfBirth;
      this.email = email;
      this.phone = phone;
      this.address = address;
    }

    //Methods
    public abstract void DisplayInformation();

    public abstract void UpdateInformation(string studentID);

    public abstract void DeleteInformation(string studentID);
  }
}
