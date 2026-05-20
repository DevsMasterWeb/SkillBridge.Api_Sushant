using Microsoft.AspNetCore.Mvc;
namespace SkillBridge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController: ControllerBase
{
    
    private readonly IJobRespository _jobRepository;
    public JobController(IJobRespository jobRespository)
    {
        _jobRepository = jobRespository;
    }
    [HttpGet]
    public IEnumerable<JobDto> GetJobList()
    {
        
        return _jobRepository.GetJobListAsync().Result;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetJobById(int id)
    {
        var job = await _jobRepository.GetJobByIdAsync(id);
        if (job == null)
        {
            return NotFound();
        }
        return Ok(job);
    }
}