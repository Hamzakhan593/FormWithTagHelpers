namespace FormWithTagHelpers.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
        public string Married { get; set; }
        public string Descripstion { get; set; }
    }

    public enum Gender
    {
        MALE,Female
    }
}
