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
    public class ProjekatController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiProjekte")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProjekte()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveProjekte());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajProjekat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajProjekat([FromBody] ProjekatView p)
        {
            try
            {
                DataProvider.DodajProjekat(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiProjekat(int id)
        {
            try
            {
                DataProvider.obrisiProjekat(id);
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
        public IActionResult DodajOdnosP_S([FromBody] UzeoProjekatView p)
        {
            try
            {
                DataProvider.dodajOdnosP_S(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniProjekat/{i}/{imeProj}/{Pocetak}/{Predmet}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniProjekat(int i,string imeProj,DateTime Pocetak,int Predmet)
        {
            try
            {
                PredmetView Pred = DataProvider.VratiPredmet(Predmet);
                ProjekatView projekatView = new ProjekatView(i, imeProj, Pocetak, Pred);

                DataProvider.AzurirajProjekat(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetProjekat(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiProjekat(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #region TeoPoj

        [HttpPost]
        [Route("DodajTeorijskiPojedinacniProjekat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajTeoPoj([FromBody] TeorijskiPojView p)
        {
            try
            {
                DataProvider.DodajTeorPojProjekat(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniTeorijskiPojedinacniProjekat/{i}/{imeProj}/{Pocetak}/{Predmet}/{max}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniTeoPoj(int i, string imeProj, DateTime Pocetak, int Predmet,int max)
        {
            try
            {
                PredmetView Pred = DataProvider.VratiPredmet(Predmet);
                TeorijskiPojView projekatView = new TeorijskiPojView(i, imeProj, Pocetak,max, Pred);

                DataProvider.AzurirajTeorPojProjekat(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiTeorijskiPojedinacniProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTeoPoj(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiTeorPojProjekat(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #endregion

        #region TeoGrup
        [HttpPost]
        [Route("DodajTeorijskiGrupniProjekat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajTeoGrup([FromBody] TeorijskiGrupView p)
        {
            try
            {
                DataProvider.DodajTeorGrupProjekat(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniTeorijskiGrupniProjekat/{i}/{imeProj}/{Pocetak}/{Predmet}/{max}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniTeoGrup(int i, string imeProj, DateTime Pocetak, int Predmet, int max)
        {
            try
            {
                PredmetView Pred = DataProvider.VratiPredmet(Predmet);
                TeorijskiGrupView projekatView = new TeorijskiGrupView(i, imeProj, Pocetak, max, Pred);

                DataProvider.AzurirajTeorGrupProjekat(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiTeorijskiGrupniProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTeoGrup(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiTeorGrupProjekat(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region PrakPoj
        [HttpPost]
        [Route("DodajPrakPojedinProjekat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPrakPoj([FromBody] PrakticniPojedinacniView p)
        {
            try
            {
                DataProvider.DodajPrakPojProjekat(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPrakPojedinProjekat/{i}/{imeProj}/{Pocetak}/{Predmet}/{kOpis}/{PJezik}/{izv}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniPrakPojedin(int i, string imeProj, DateTime Pocetak, int Predmet, string kOpis,string PJezik,int izv)
        {
            try
            {
                PredmetView Pred = DataProvider.VratiPredmet(Predmet);
                IzvestajiView izvst = DataProvider.VratiIzvestaje(izv);
                PrakticniPojedinacniView projekatView = new PrakticniPojedinacniView(i, imeProj, Pocetak,kOpis,PJezik,izvst, Pred);

                DataProvider.AzurirajPrakPojProjekat(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPrakPojedinProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPrakPoj(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPrakPojProjekat(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPPOdnos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajUzeoPP([FromBody] UzeoPPView p)
        {
            try
            {
                DataProvider.dodajUzeoPP(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPPOdnos/{id}/{idPrakPoj}/{ProgJez}/{Izv}/{datum}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniUzeoPP(int id, int idPrakPoj, string ProgJez, string Izv, DateTime datum)
        {
            try
            {
                PrakticniPojedinacniView prakPoj = DataProvider.VratiPrakPojProjekat(idPrakPoj);
                UzeoPPView projekatView = new UzeoPPView(id, prakPoj, ProgJez, Izv, datum);

                DataProvider.izmeniUzeoPP(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        #endregion

        #region PrakGrup
        [HttpPost]
        [Route("DodajPrakGrupniProjekat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajPrakGrup([FromBody] PrakticniGrupniView p)
        {
            try
            {
                DataProvider.DodajPrakGrupProjekat(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPrakGrupniProjekat/{i}/{imeProj}/{Pocetak}/{Predmet}/{kOpis}/{PJezik}/{izv}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniPrakGrupni(int i, string imeProj, DateTime Pocetak, int Predmet, string kOpis, string PJezik, int izv)
        {
            try
            {
                PredmetView Pred = DataProvider.VratiPredmet(Predmet);
                IzvestajiView izvst = DataProvider.VratiIzvestaje(izv);
                PrakticniGrupniView projekatView = new PrakticniGrupniView(i, imeProj, Pocetak, kOpis, PJezik, izvst, Pred);

                DataProvider.AzurirajPrakGrupProjekat(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPrakGrupniProjekat/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPrakGrupni(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPrakGrupProjekat(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPGOdnos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajUzeoPG([FromBody] UzeoPGView p)
        {
            try
            {
                DataProvider.dodajOdnosUzeoPG(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniPGOdnos/{id}/{idPrakG}/{ProgJez}/{Izv}/{datum}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniUzeoPG(int id, int idPrakG, string ProgJez, string Izv, DateTime datum)
        {
            try
            {
                PrakticniGrupniView prakGrup = DataProvider.VratiPrakGrupProjekat(idPrakG);
                UzeoPGView projekatView = new UzeoPGView(id, prakGrup, ProgJez, Izv, datum);

                DataProvider.izmeniUzeoPG(projekatView);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }





}
