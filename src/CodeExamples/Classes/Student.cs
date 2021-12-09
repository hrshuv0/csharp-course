namespace Classes; //CompanyName.ProjectName.ModuleName.FolderName.SubFolderName
public class Student // Classes.Student
{
    public int age;
    public string name;

    public string GenerateNewId()
    {
        return "S-" + DateTime.Now.Ticks;
    }
}
