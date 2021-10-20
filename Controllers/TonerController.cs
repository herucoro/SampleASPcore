using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using Sample.Data;

namespace Sample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TonerController : ControllerBase {

    private static List<Toner> items = new List<Toner>() {
        new Toner() { id = 1, black = 1, magenta = 1, yellow = 1, cyan = 1, recovered_toner = 1, drum = 1},
        // new Toner() { id = "2", name = "bbb"},
        // new Toner() { id = "3", name = "ccc"},
    };

    [HttpGet]
    public ActionResult<List<Toner>> GetAll() => items;

    // [HttpGet("{id}", Name="Person")]
    // public ActionResult<Toner> GetById(string id) {
    // }
}