using Microsoft.AspNetCore.Mvc;
using Jokes.ViewModels;
using Jokes.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jokes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private JokesContext context;
        public JokeController(JokesContext dbContext)
        {
            context = dbContext;
        }
        // GET: api/<JokeController>
        [HttpGet]
        public List<JokeViewModel> Get()
        {
            return context.Jokes.Select(x => new JokeViewModel(x)).ToList();
        }        
    }
}
