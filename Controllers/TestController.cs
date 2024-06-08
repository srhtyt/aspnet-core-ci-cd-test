using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_ci_cd.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Mild", "Warm", "Balmy"
    };

    [HttpGet]
    public string Get()
    {
        return "test-1"; 
    }
}