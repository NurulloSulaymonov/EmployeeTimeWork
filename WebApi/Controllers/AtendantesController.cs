using Domain.Dtos;
using Domain.Response;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class AtendantesController : ControllerBase
{
    private readonly IAttendanceService _atendaceService;

    public AtendantesController(IAttendanceService atendaceService)
    {
        _atendaceService = atendaceService;
    }
    [HttpPost("AddAttendance")]
    public async Task<Response<string>> AddAttendance(AddAttendanceDto attendance)
    {
        return await _atendaceService.AddAttendance(attendance);
    }
}
