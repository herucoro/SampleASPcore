using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using Sample.Data;

namespace Sample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase {

    // private static List<Person> items = new List<Person>() {
    //     new Person() { id = "1", name = "aaa"},
    //     new Person() { id = "2", name = "bbb"},
    //     new Person() { id = "3", name = "ccc"},
    // };

    // [HttpGet]
    // public ActionResult<List<Person>> GetAll() => items;

    [HttpGet("{id}", Name="Person")]
    public ActionResult<Person> GetById(string id) {
        // using (var db = new PersonContext()) {
        //     var items = new List<Person> {
        //         new Person { id = "0", name = "asd"},
        //         new Person { id = "1", name = "qwe"},
        //     };
        //     db.Persons.AddRange(items);
        //     db.SaveChanges();
        // }


        var item = items.Find(i => i.id == id);
        if (item == null)
            return NotFound();
        return item;
    }
}