using System.ComponentModel.DataAnnotations;
using Domain.Entites;

namespace Domain.Dtos;

public class AddEmployeeDto
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    public int Gender { get; set; }
    [Required, MaxLength(35)]
    public string Phone { get; set; }

}
