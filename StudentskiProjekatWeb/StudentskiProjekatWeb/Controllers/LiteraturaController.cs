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
    public class LiteraturaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiLiteraturaIzPojedinacnihProjekta/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetLitPoj(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveLiteratureProjektaPoj(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiLiteraturaIzGrupnihProjekta/{ind}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetLitGrup(int ind)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveLiteratureProjektaGrup(ind));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajLiteraturu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajLiteraturu([FromBody] LiteraturaView p)
        {
            try
            {
                DataProvider.DodajLiteraturu(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiLiteraturu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiLit(int id)
        {
            try
            {
                DataProvider.obrisiLiteraturu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        

        [HttpGet]
        [Route("PreuzmiLiteraturu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetLit(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiLiteraturu(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiRadPoImenu/{ime}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadIme(string ime)
        {
            try
            {
                return new JsonResult(DataProvider.VratiRadPoImenu(ime));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiKnjiguPoImenu/{ime}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKnjigaIme(string ime)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKnjigaPoImenu(ime));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiClanakPoImenu/{ime}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetClanakIme(string ime)
        {
            try
            {
                return new JsonResult(DataProvider.VratiClanakPoImenu(ime));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajOdnosLT_Poj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajOdnosLT_Poj([FromBody] KoristiPojView p)
        {
            try
            {
                DataProvider.dodajOdnosLIT_TEOPoj(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajOdnosLT_Grup")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajOdnosLT_Grup([FromBody] KoristiGrupView p)
        {
            try
            {
                DataProvider.dodajOdnosLIT_TEOGrup(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #region Rad
        [HttpPost]
        [Route("DodajRad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajRad([FromBody] RadView p)
        {
            try
            {
                DataProvider.DodajRad(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniRad/{idl}/{idm}/{naziv}/{konferencija}/{adresa}/{format}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniRad(int idl, int idm, string naziv, string konferencija, string adresa, string format)
        {
            try
            {
                RadView rad = new RadView(idl, idm, naziv, konferencija, adresa, format);

                DataProvider.AzurirajRad(rad);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiRad/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRad(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiRad(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Knjiga
        [HttpPost]
        [Route("DodajKnjigu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajKnjiga([FromBody] KnjigaView p)
        {
            try
            {
                DataProvider.DodajKnjigu(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniKnjigu/{idl}/{idm}/{naziv}/{izdavac}/{Isbn}/{GodinaIzdanja}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniKnjiga(int idl, int idm, string naziv, string izdavac, int Isbn, int GodinaIzdanja)
        {
            try
            {
                KnjigaView knjiga = new KnjigaView(idl, idm, naziv,izdavac,Isbn,GodinaIzdanja);

                DataProvider.AzurirajKnjigu(knjiga);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiKnjigu/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKnjiga(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKnigu(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Clanak
        [HttpPost]
        [Route("DodajClanak")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajClanak([FromBody] ClanakView p)
        {
            try
            {
                DataProvider.DodajClanak(p);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniClanak/{idl}/{idm}/{naziv}/{broj}/{godina}/{issn}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IzmeniClanak(int idl, int idm, string naziv, int broj, int godina, int issn)
        {
            try
            {
                ClanakView Clanak = new ClanakView(idl, idm, naziv, broj, godina, issn);

                DataProvider.AzurirajClanak(Clanak);
                return Ok("Proslo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiClanak/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetClanak(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiClanak(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
