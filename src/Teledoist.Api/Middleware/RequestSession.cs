using System.Text;

namespace Teledoist.Api.Middleware;

public class RequestSession {
  private readonly RequestDelegate _next;

  public RequestSession(RequestDelegate next) {
    _next = next;
  }

    public async Task Invoke(HttpContext httpContext)
    {
      Console.WriteLine("REQUEST:");
        using var reader = new StreamReader(httpContext.Request.Body, Encoding.UTF8);
        Console.WriteLine(await reader.ReadToEndAsync());

      

      await _next(httpContext);
    }
}
