using Microsoft.AspNetCore.Mvc;

namespace route_issue.Controllers;

public class HomeController : ControllerBase
{
    [HttpGet(@"{platform:alpha}/{locale:regex([[a-z]]+(-[[a-z]]+)?)}")]
    public IActionResult Index(string platform, string locale)
    {
        return Ok(new { platform, locale });
    }
}
