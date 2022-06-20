using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        private IStadiumRepository stadiumRepository;

        public StadiumController(IStadiumRepository stadiumRepository)
        {
            this.stadiumRepository = stadiumRepository;
        }

        [HttpGet]
        public ActionResult<List<Stadium>> GetAllStadiums()
        {
            return stadiumRepository.GetAllStadiums();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Stadium> GetStadiumsById(int id)
        {
            return stadiumRepository.GetStadiumsById(id);
        }

        [HttpPost]
        public ActionResult AddStadiums(Stadium stadium)
        {
            stadiumRepository.AddStadiums(stadium);
            return Ok(stadium);
        }
    }
}
