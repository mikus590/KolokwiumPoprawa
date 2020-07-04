using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumPoprawa.DTOs.Response;
using KolokwiumPoprawa.Exceptions;
using KolokwiumPoprawa.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumPoprawa.Controllers
{
    [Route("api")]
    [ApiController]
    public class FireFightersController : ControllerBase
    {

        private readonly IFireFighterDbService _service;
        public FireFightersController(IFireFighterDbService service)
        {
            _service = service;
        }
        [HttpGet("/firefighters/{id:int}/actions")]
        public IActionResult GetActions(int id)
        {
            Console.Write(id);
            try
            {
                var result = _service.GetActions(id);
                return Ok(result);
            }
            catch (NoSuchFireFighterException ex)
            {
                return BadRequest("Such FireMan does not exists!");
            }
        }

        [HttpPut("/actions/fire-trucks")]
        public IActionResult AssighFireTruck(AssignTruckRequest request)
        {
            try
            {
                _service.AssignTruck(request);
            }
            catch (NoSuchActionEx ex)
            {
                return BadRequest("No Action");
            }
            catch (NoSuchTruckEx ex)
            {
                return BadRequest("No Truck");
            }
            return Ok("ok!");
        }
    }
}