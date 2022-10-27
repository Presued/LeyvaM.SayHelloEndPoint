//Manuel L.
//10-25-22
//Say Hello EndPoint
// The user will be able to input there name and the code will output the users name
// Peer Review: Ulises Ortega, The code works as expected taking my input and outputing it in screen, 
//tested in website and postman, good job!

using Microsoft.AspNetCore.Mvc;

namespace LeyvaM.SayHelloEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh1/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }  
}