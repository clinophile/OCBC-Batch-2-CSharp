using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data ;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        // [Route("TestRun")]
        // [HttpGet]

        // public ActionResult TestRun() {
        //     return Ok("success");
        // }

        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetItems() {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<ActionResult> CreateItem(ItemData data) {
            if (ModelState.IsValid) {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500} ;
        }

         [HttpGet("{id}")]
        public async Task<ActionResult> GetItem(int id) {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(item == null) {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
         public async Task<ActionResult> UpdateItem(int id, ItemData item) {
            if(id != item.id) {
                return BadRequest();
            }
            
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            existItem.title = item.title;
            existItem.description = item.description;
            existItem.done = item.done;

            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id) {
           var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);
            
            if(existItem == null) {
                return NotFound();
            }

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();
            return Ok(existItem);
        }
        

    }

}