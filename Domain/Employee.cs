namespace Domain;

public class Employee
{
    public int Id { get; set; }
     public DateTime BirthDate { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Gender { get; set; }
    public DateTime HireDate { get; set; }

}




enum Gender
{
    man,
    woman,
    both
}