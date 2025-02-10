namespace FormWithTagHelpers.Models;

public class Student
{
    public string Name { get; set; }
    public string Fathername { get; set; }
    public string Class { get; set; }
    public StdGender Gender { get; set; }
    public string Married { get; set; }
}
public enum StdGender
{
    Male,Female 
}
