using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentskiLibary;
using StudentskiLibary.Entiteti;
using StudentskiLibary.DTOs;


namespace StudentskiProjekatWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiStudente")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStudente()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveStudente());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajStudenta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajStudenta([FromBody] StudentView p)
        {
            try
            {
                DataProvider.DodajStudenta(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiStudenta/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiStudenta(int id)
        {
            try
            {
                DataProvider.obrisiStudenta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajOdnos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajOdnosS_P([FromBody] UzeoProjekatView p)
        {
            try
            {
                DataProvider.dodajOdnosS_P(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniStudenta/{index}/{ime}/{imeRod}/{prez}/{smer}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniStudenta(int index,string ime,string imeRod,string prez,string smer)
        {
            try
            {
                StudentView student = new StudentView(index, ime, imeRod, prez, smer);

                DataProvider.AzurirajStudenta(student);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiStudenta/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStudent(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiStudenta(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiStudenteProjekta/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetStudenteProj(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiStudenteProjekta(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
