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
    public class AutorController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAutoreLiterature/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAutore(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiAutoraLiterature(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajAutora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajAutora([FromBody] AutorView p)
        {
            try
            {
                DataProvider.DodajAutora(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiAutora/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiAutora(int id)
        {
            try
            {
                DataProvider.obrisiAutora(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        [HttpPut]
        [Route("IzmeniAutora/{id}/{imePrez}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniAutora(int id, string imePrez)
        {
            try
            {
                AutorView autor = new AutorView(id, imePrez,0) ;

                DataProvider.AzurirajAutora(autor);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAutora/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAutor(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiAutora(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


    }
}
