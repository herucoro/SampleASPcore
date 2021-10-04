using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers.Person;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase {
    [HttpGet]
    public string GetPerson() {
        return "0";
    }
}