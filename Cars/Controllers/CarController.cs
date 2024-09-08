using Domain;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        IDomain _domain;

        public CarController(IDomain domain)
        {
            _domain = domain;
        }

        [HttpGet(Name = "GetCarByName")]
        public async Task<List<CarDTO>> Get(string name) => await _domain.GetCarByName(name);
    }
}
