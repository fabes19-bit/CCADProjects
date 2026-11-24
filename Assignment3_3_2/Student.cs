namespace Assignment3_3_2;

/// <summary>
/// Represents a student with identification, biographical, and enrollment details.
/// Fields per Assignment 3.3 Question 2: studid, firstname, lastname, address, monthofadmission, grade.
/// </summary>
public class Student
{
    /// <summary>
    /// Student Identification number.
    /// </summary>
    public int StudId { get; set; }

    /// <summary>
    /// Alias for StudId for standardized naming conventions.
    /// </summary>
    public int StudentId
    {
        get => StudId;
        set => StudId = value;
    }

    /// <summary>
    /// Student's first name.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Student's last name.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Full name helper property.
    /// </summary>
    public string FullName => $"{FirstName} {LastName}".Trim();

    /// <summary>
    /// Student's residential address.
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Month of admission as an enumeration.
    /// </summary>
    public MonthOfAdmission MonthOfAdmission { get; set; }

    /// <summary>
    /// Student's academic letter grade ('A', 'B', 'C', 'D', 'F').
    /// </summary>
    public char Grade { get; set; }

    public Student() { }

    public Student(int studId, string firstName, string lastName, string address, MonthOfAdmission monthOfAdmission, char grade)
    {
        StudId = studId;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        MonthOfAdmission = monthOfAdmission;
        Grade = char.ToUpperInvariant(grade);
    }

    public override string ToString()
    {
        return $"[{StudId}] {FullName} - Grade: {Grade}, Admitted: {MonthOfAdmission}";
    }
}
