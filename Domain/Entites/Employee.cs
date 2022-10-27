using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites;

public class Employee
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    public Gender Gender { get; set; }
    [Required, MaxLength(35)]
    public string Phone { get; set; }

    public List<Attendance> Attendances { get; set; }

}

public enum Gender{
    Male, 
    Female
}
