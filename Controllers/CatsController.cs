using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catsalot.Models;
using catsalot.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace catsalot.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly CatRepository _catRepo;
    public CatsController(CatRepository catRepo)
    {
      _catRepo = catRepo;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
      return Ok(_catRepo.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      Cat result = _catRepo.GetCatById(id);
      if (result != null)
      {
        return Ok(result);
      }
      return NotFound();
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Cat> Post([FromBody] Cat value)
    {
      return Created("/api/cats/", _catRepo.AddCat(value));
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Cat> Put(int id, [FromBody] Cat value)
    {
      Cat result = _catRepo.EditCat(id, value);
      if (result != null)
      {
        return result;
      }
      return NotFound();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      if (_catRepo.DeleteCat(id))
      {
        return Ok("success");
      }
      return NotFound("No Cat to delete");
    }
  }
}
