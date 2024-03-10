using Microsoft.AspNetCore.Mvc;

namespace Teledoist.Api.Controllers;

[ApiController]
[Route("api/teledoist/[controller]")]
public class WebHookController : ControllerBase
{
    private const string _HELLO_MESSAGE = "Hello World!!!";

    public WebHookController() { }

    [HttpPost("payload")]
    public string Payload()
    {
        return _HELLO_MESSAGE;
    }
}
