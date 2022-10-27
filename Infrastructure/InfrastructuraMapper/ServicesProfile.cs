using AutoMapper;
using Domain.Dtos;
using Domain.Entites;

namespace Infrastructure.InfrastructuraMapper;

public class ServicesProfile : Profile
{
    public ServicesProfile()
    {
        CreateMap<Employee, AddEmployeeDto>().ReverseMap();
        CreateMap<Attendance, AddAttendanceDto>().ReverseMap();
        CreateMap<Employee, GetEmployeeDto>().ReverseMap();
    }
}
