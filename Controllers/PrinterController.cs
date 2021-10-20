using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using Sample.Data;

namespace Sample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PrinterController : ControllerBase {

    private static List<Printer> items = new List<Printer>() {
        new Printer() { id = 1, name = "aaa", floor = "1", checked_at = DateTime.Now},
        // new Toner() { id = "2", name = "bbb"},
        // new Toner() { id = "3", name = "ccc"},
    };

    [HttpGet]
    public ActionResult<List<Printer>> GetAll() => items;

    // [HttpGet("{id}", Name="Person")]
    // public ActionResult<Toner> GetById(string id) {
    // }
}