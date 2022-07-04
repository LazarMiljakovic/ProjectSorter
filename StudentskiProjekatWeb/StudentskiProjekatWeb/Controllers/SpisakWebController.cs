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
    public class SpisakWebController : ControllerBase
    {
        #region Pojedin
        [HttpGet]
        [Route("PreuzmiSpisakWebP/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSpisakWebP(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSpisakWebP(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajWebP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajWeb([FromBody] SpisakWebPojedinView p)
        {
            try
            {
                DataProvider.DodajWebP(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiWebP/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiWebP(int id)
        {
            try
            {
                DataProvider.obrisiWebP(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniWebP/{id}/{iden}/{webstranica}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniWebP(int id,int iden, string webstranica)
        {
            try
            {
                SpisakWebPojedinView sp = new SpisakWebPojedinView(id, iden, webstranica);

                DataProvider.AzurirajWebP(sp);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiWebP/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetWebP(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiWebP(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Grupni
        [HttpGet]
        [Route("PreuzmiSpisakWebG/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSpisakWebG(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSpisakWebG(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajWebG")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajWeG([FromBody] SpisakWebGrupniView p)
        {
            try
            {
                DataProvider.DodajWebG(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiWebG/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiWebG(int id)
        {
            try
            {
                DataProvider.obrisiWebG(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniWebG/{id}/{iden}/{webstranica}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniWebG(int id, int iden, string webstranica)
        {
            try
            {
                SpisakWebGrupniView sp = new SpisakWebGrupniView(id, iden, webstranica);

                DataProvider.AzurirajWebG(sp);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiWebG/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetWebG(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiWebG(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
