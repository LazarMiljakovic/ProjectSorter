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
    public class IzvestajiController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIzvestaje/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIzvestaje(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiIzvestaje(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiIzvestajeIzProj/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIzvestajeizProj(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiIzvestajeIzProj(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajIzvestaj([FromBody] IzvestajView p)
        {
            try
            {
                DataProvider.DodajIzvestaj(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiIzvestaj/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiIzvestaj(int id)
        {
            try
            {
                DataProvider.obrisiIzvestaj(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniIzvestaj/{id}/{grupa}/{sadrzaj}/{odnos}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniStudenta(int id,int grupa,string sadrzaj, string odnos)
        {
            try
            {
                IzvestajView izvestaj = new IzvestajView(id,grupa,sadrzaj,odnos);

                DataProvider.AzurirajIzvestaj(izvestaj);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiIzvestaj/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIzvestaj(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiIzvestaj(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGrupuI/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGrupuI(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiGrupuI(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIzvestajGrupu/{iden}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajIzvestajGrupu(int iden)
        {
            try
            {
                DataProvider.DodajIzvestajGrupu(iden);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIzvestajGrupuNaProj/{iden}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajIzvestajGrupuNaProj(int iden)
        {
            try
            {
                DataProvider.DodajIzvestajGrupuNaProj(iden);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
