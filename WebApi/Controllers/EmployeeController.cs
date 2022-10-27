using Domain.Dtos;
using Domain.Entites;
using Domain.Response;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeServices _employeeServices;

    public EmployeeController(IEmployeeServices employeeServices)
    {
        _employeeServices = employeeServices;
    }
    [HttpPost("AddEmployee")]
    public async Task<Response<AddEmployeeDto>> AddEmployee(AddEmployeeDto employee)
    {
        return await _employeeServices.AddEmployee(employee);
    }
    [HttpGet("GetEmployee")]
    public async Task<Response<List<GetEmployeeDto>>> GetEmployee()
    {
        return await _employeeServices.GetEmployee();
    }
    [HttpGet("GetEmployeeByNAmeAndByPhone")]
    public async Task<Response<List<GetEmployeeDto>>> GetEmployeeByNameAndPhone(string name, string phone)
    {
        var Groups = await _employeeServices.GetEmployeeByNameAndPhone(name, phone);
        return Groups;
    }
    [HttpGet("GetEmployeeById")]
    public async Task<Response<GetEmployeeDto>> GetEmployeeById(int id)
    {
        return await _employeeServices.GetEmployeeById(id);
    }
}
