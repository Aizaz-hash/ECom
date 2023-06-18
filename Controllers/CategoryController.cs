using Microsoft.AspNetCore.Mvc;
using RESTful_API.Data;
using RESTful_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTful_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly EcomeraceDbContext _context;

        public CategoryController(EcomeraceDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.categories;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _context.categories.FirstOrDefault(opt=>opt.Id==id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _context.categories.Add(category);
            _context.SaveChanges();

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            var categoryFromDb = _context.categories.Find(id);
            _context.categories.Update(categoryFromDb);
            _context.SaveChanges();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var categoryFromDb = _context.categories.Find(id);
            _context.categories.Remove(categoryFromDb);
            _context.SaveChanges();

        }
    }
}
