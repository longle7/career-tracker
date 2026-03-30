using Microsoft.AspNetCore.Mvc;
using JobTracker.Server.Data;  // ← This using is required

namespace JobTracker.Server.Controllers;

[ApiController]
[Route("api/[controller]")]  // ← Note the "api/" prefix
public class JobApplicationsController : ControllerBase
{
    private static List<JobApplication> _applications = new();

    [HttpGet]
    public ActionResult<List<JobApplication>> Get()
    {
        return Ok(_applications);
    }

    [HttpPost]
    public ActionResult<JobApplication> Post(JobApplication application)
    {
        application.Id = _applications.Count + 1;
        _applications.Add(application);
        return CreatedAtAction(nameof(Get), new { id = application.Id }, application);
    }
}