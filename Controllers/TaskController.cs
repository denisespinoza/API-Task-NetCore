using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Namespace
{
   [Route("api/[controller]")]
   [ApiController]
   public class TaskController : ControllerBase
   {
      private readonly AppDbContext _context;
      public TaskController(AppDbContext context)
      {
         _context = context;
      }

      [HttpGet]
      public ActionResult<IEnumerable<Task>> Get()
      {
         return _context.Tasks.ToList();
      }

      [HttpGet("{id}")]
      public ActionResult<Task> Get(int id)
      {
         return _context.Tasks.Find(id);
      }

      [HttpPost]
      public void Post([FromBody] string value)
      {
      }

      [HttpPut("{id}")]
      public IActionResult Put(int id, [FromBody] Task task)
      {
         if (id != task.Id)
         {
            return BadRequest();
         }

         _context.Entry(task).State = EntityState.Modified;
         int result = _context.SaveChanges();

         if (result == 0)
            return NotFound();

         return NoContent();
      }

      [HttpDelete("{id}")]
      public void Delete(int id)
      {
      }
   }
}