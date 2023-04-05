using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission_14_API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//this controller handles the movies

namespace Mission_14_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;

        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }

        // GET: /<controller>/
        public IEnumerable<MovieData> Get()
        {
            var x = context.Movies
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title)
                .ToArray();

            return x;
        }
    }
}

