using Microsoft.AspNetCore.Mvc;
using Jokes.ViewModels;
using Jokes.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        [Route("{id}")]
        public JokeViewModel Get(int id)
        {
            return context.Jokes
                .Where(x => x.JokeId == id)
                .Select(x => new JokeViewModel(x)).FirstOrDefault();

        }

        [HttpPost]
        public IActionResult Post(Joke model)
        {
            var joke = new Joke();
            joke.JokeQuestion = model.JokeQuestion;
            joke.JokeAnswer = model.JokeAnswer;
            context.Jokes.Add(joke);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Joke model)
        {
            var joke = context.Jokes.Where(x => x.JokeId == model.JokeId).FirstOrDefault();
            if (joke == null)
            {
                return NotFound();
            }
            else
            {
                joke.JokeQuestion = model.JokeQuestion;
                joke.JokeAnswer = model.JokeAnswer;
                context.SaveChanges();
                return Ok(joke);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = context.Jokes.Where(x => x.JokeId == id).FirstOrDefault();
            if(entity == null)
            {
                return NotFound();
            }
            context.Jokes.Remove(entity);
            context.SaveChanges();
            return Ok();
        }
    }
}
