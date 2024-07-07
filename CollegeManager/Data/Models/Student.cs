// Student (Name, Address, Email, Dob, Gender)
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? Email { get; set; }
    public DateTime? Dob { get; set; }

    public int CollegeProgramId { get; set; }
    public CollegeProgram? CollegeProgram { get; set; }
}