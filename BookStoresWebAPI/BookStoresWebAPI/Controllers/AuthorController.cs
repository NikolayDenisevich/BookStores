using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDbContext())
            {
                // get all authors
                return context.Authors.ToList();
            }
           
        } 
    }
}
