
namespace Domain.Entites;

public class Attendance
{
    public int Id { get; set; }
    public DateTimeOffset Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }

    public Attendance()
    {
        Date = DateTime.UtcNow;
        StartTime = DateTime.Now.TimeOfDay;
    }

}
