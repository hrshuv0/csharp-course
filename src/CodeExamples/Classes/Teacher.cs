namespace Classes;
public class Teacher
{
    private string id; // protected, internal
    public int age;
    public string name;
    protected string address;
    internal string photoUrl;
    private int[] numbers;
    public readonly int codeNumber = 45454;
    public const int code = 333;

    public static int count = 0;

    public string Id
    {
        get { return id; }
        set
        {
            if (value.StartsWith("T-"))
                id = value;
        }
    }

    public DateTime DateOfBirth { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public Teacher()
    {
        numbers = new int[100000];
        age = 10;
        name = string.Empty; // ""
        Id = "T-1000";
        codeNumber = 12131241;
        count++;
    }

    public Teacher(int age, string name, string id)
    {
        numbers = new int[100000];
        this.age = age;
        this.name = name;
        Id = id;
        codeNumber = 12131241;
        count++;
    }

    ~Teacher()
    {
        numbers = new int[0];
    }

    public void GenerateNewId()
    {
        Student student = new Student();
        id = "T-" + DateTime.Now.Ticks;
    }

    public void GenerateNewId(string id)
    {
        this.id = "T-" + id;
    }

    public void GenerateNewId(string prefix, int id = 0)
    {
        this.id = prefix + id;
    }

    public void GenerateNewId(int id, string prefix = "T-")
    {
        this.id = prefix + id;
    }
}

class HeadMaster : Teacher
{
    int x;

    public void SetAddress()
    {
        address = "Dhaka";
    }
}

