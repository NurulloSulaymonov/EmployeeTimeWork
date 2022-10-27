using Domain.Entites;

namespace Domain.Dtos;

public class GetEmployeeDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public string Phone { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int AtendancesId { get; set; }
    public DateTimeOffset StartWork { get; set; }
    public DateTimeOffset EndWork { get; set; }


}
