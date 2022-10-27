using Domain.Dtos;
using Domain.Entites;
using Domain.Response;

namespace Infrastructure.Services;

public interface IEmployeeServices
{
    Task<Response<AddEmployeeDto>> AddEmployee(AddEmployeeDto model);
    Task<Response<List<GetEmployeeDto>>> GetEmployee();
    Task<Response<List<GetEmployeeDto>>> GetEmployeeByNameAndPhone(string name, string phone);
    Task<Response<GetEmployeeDto>> GetEmployeeById(int id);

}
