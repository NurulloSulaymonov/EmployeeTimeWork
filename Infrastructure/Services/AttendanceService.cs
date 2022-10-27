using AutoMapper;
using Domain.Dtos;
using Domain.Entites;
using Domain.Response;
using Infrastructure.Context;

namespace Infrastructure.Services;

public class AttendanceService : IAttendanceService
{


    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public AttendanceService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<Response<string>> AddAttendance(AddAttendanceDto model)
    {
        try
        {
            var mapped = _mapper.Map<Attendance>(model);
            await _context.Attendances.AddAsync(mapped);
            await _context.SaveChangesAsync();
            return new Response<string>(_mapper.Map<string>("Attendance Added Successfully"));
        }
        catch (Exception ex)
        {
            return new Response<string>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
        }
    }
}
