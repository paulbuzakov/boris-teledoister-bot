using Microsoft.AspNetCore.Mvc;

namespace Teledoist.Api.Controllers;

[ApiController]
[Route("api/teledoist/access_token")]
public class AccessTokenController : ControllerBase
{
    public AccessTokenController() {

    }

    [HttpPost]
    public Task<IActionResult> Post([FromBody] string access_token, [FromBody] string )
    {
Console.WriteLine(Request.Content.R);
 return Ok();
    }
}
