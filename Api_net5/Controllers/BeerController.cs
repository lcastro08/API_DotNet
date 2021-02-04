using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_net5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Beer> Get()
        {
            using (var db = new Models.beerDBContext())
            {
                IEnumerable<Models.Beer> beers = db.Beers.ToList();
                return beers;
            }
        }
    }
}
