using Microsoft.AspNetCore.Mvc;

namespace Teledoist.Api.Controllers;

[ApiController]
[Route("api/teledoist")]
public class AccessTokenController : ControllerBase
{
    public AccessTokenController()
    {

    }

    [HttpPost("access_token")]
    public IActionResult Post([FromBody] string access_token)
    {
        Console.WriteLine(access_token);

        return Ok();
    }
}
