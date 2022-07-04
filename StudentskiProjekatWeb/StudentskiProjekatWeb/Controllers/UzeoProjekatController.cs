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
    public class UzeoProjekatController : ControllerBase
    {
        [HttpDelete]
        [Route("IzbrisiOdnos/{idS}/{idP}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiOdnos(int idS, int idP)
        {
            try
            {
                ProjekatView p = DataProvider.VratiProjekat(idP);
                StudentView s = DataProvider.VratiStudenta(idS);
                UzeoProjekatIdView uzeoProjekatIdView = new UzeoProjekatIdView(s, p);
                UzeoProjekatView uzeoProjekatView = new UzeoProjekatView(uzeoProjekatIdView,DateTime.Now, DateTime.Now, DateTime.Now);

                DataProvider.ObrisiOdnos(uzeoProjekatView);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniOdnos/{idS}/{idP}/{Izab}/{Rok}/{Zavr}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniOdnos(int idS, int idP, DateTime Izab, DateTime Rok, DateTime? Zavr)
        {
            try
            {
                ProjekatView p = DataProvider.VratiProjekat(idP);
                StudentView s = DataProvider.VratiStudenta(idS);
                UzeoProjekatIdView uzeoProjekatIdView = new UzeoProjekatIdView(s,p);
                UzeoProjekatView uzeoProjekatView = new UzeoProjekatView(uzeoProjekatIdView,Izab,Rok,Zavr);

                DataProvider.izmeniOdnos(uzeoProjekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOdnos/{idS}/{idP}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOdnos(int idS,int idP)
        {
            try
            {
                return new JsonResult(DataProvider.vratiOdnos(idS,idP));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
