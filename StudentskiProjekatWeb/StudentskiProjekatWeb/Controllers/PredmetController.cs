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
    public class PredmetController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPredmete")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPredmete()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvePredmete());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajPredmet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPredmet([FromBody] PredmetView p)
        {
            try
            {
                DataProvider.DodajPredmet(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPredmet/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiPredmet(int id)
        {
            try
            {
                DataProvider.obrisiPredmet(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPredmet/{sifra}/{imepred}/{semest}/{katedra}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniPredmet(int sifra, string imepred,int semest,string katedra)
        {
            try
            {
                PredmetView predmetView = new PredmetView(sifra,imepred,semest,katedra);

                DataProvider.AzurirajPredmet(predmetView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPredmet/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPredmet(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPredmet(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #region Profesor

        [HttpGet]
        [Route("PreuzmiProfesore/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProfesore(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvePredmetneProfesore(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajProfesora")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajProfesora([FromBody] PredmetNastavniciView p)
        {
            try
            {
                DataProvider.DodajNastavnikaNapredmet(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiProfesora/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiProfesora(int id)
        {
            try
            {
                DataProvider.obrisiProfesora(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniProfesora/{id}/{sifra}/{nastavnik}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniPredmet(int id,int sifra, string nastavnik)
        {
            try
            {
                PredmetNastavniciView predmetNastavniciView = new PredmetNastavniciView(id,sifra,nastavnik);

                DataProvider.AzurirajProfesora(predmetNastavniciView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiProfesora/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProfesor(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiProfesora(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        #endregion
    }
}
