using AutoMapper;
using Domain.Dtos;
using Domain.Entites;
using Domain.Response;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Services;
public class EmployeeServices : IEmployeeServices
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public EmployeeServices(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<Response<AddEmployeeDto>> AddEmployee(AddEmployeeDto model)
    {
        try
        {
            Employee mapped = _mapper.Map<Employee>(model);
            await _context.Employees.AddAsync(mapped);
            await _context.SaveChangesAsync();
            model.Id = mapped.Id;
            return new Response<AddEmployeeDto>(_mapper.Map<AddEmployeeDto>(mapped));
        }
        catch (Exception ex)
        {
            return new Response<AddEmployeeDto>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
        }
    }
    public async Task<Response<List<GetEmployeeDto>>> GetEmployee()
    {
        var employee = await (from at in _context.Employees
                              select new GetEmployeeDto()
                              {
                                  Id = at.Id,
                                  FirstName = at.FirstName,
                                  LastName = at.LastName,
                                  Gender = at.Gender,
                                  Phone = at.Phone
                              }).ToListAsync();
        return new Response<List<GetEmployeeDto>>(employee);
    }
    public async Task<Response<List<GetEmployeeDto>>> GetEmployeeByNameAndPhone(string name, string phone)
    {
        var find = await _context.Employees.
            Where(e=>e.FirstName.ToLower().Contains(name.ToLower()) || e.Phone.Contains(phone)).ToListAsync();
        var mapped = _mapper.Map<List<GetEmployeeDto>>(find);
        return new Response<List<GetEmployeeDto>>(mapped);
    }
    public async Task<Response<GetEmployeeDto>> GetEmployeeById(int id)
    {
            var result = _mapper.Map<GetEmployeeDto>(await _context.Employees.FindAsync(id));
            return new Response<GetEmployeeDto>(result);
    }
    
}