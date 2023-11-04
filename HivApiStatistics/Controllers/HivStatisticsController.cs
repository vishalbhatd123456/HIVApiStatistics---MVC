
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class HivStatisticsController : ControllerBase
{
    private readonly IHivStatisticsService _service;

    public HivStatisticsController(IHivStatisticsService service)
    {
        _service = service;
    }

    [HttpGet("{date}")]
    public async Task<IActionResult> Get(DateTime date)
    {
        var result = await _service.GetHivStatisticAsync(date);
        if(result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
}