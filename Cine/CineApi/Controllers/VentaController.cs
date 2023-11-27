using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        //INSTALAR NEWTONSOFT.JSON

        Servicio service = new Servicio();

        // GET: api/<VentaController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<VentaController>/5
        [HttpGet("ConsulFormaPago")]
        public IActionResult GetFP()
        {
            List<FormaPago> lista = service.ConsulFormPago();
            try
            {
                return Ok(lista);
            }
            catch
            {
                return BadRequest();
            }

        }


            [HttpGet("ProximoVenta")]
        public IActionResult Get()
        {
            int id = service.Proximo_Id();
            if (id != 0)
            {
                return Ok(id);
            }
            else { return BadRequest(); }
        }

        // POST api/<VentaController>
        [HttpPost("InsertarVenta")]
        public IActionResult Post(Venta venta)
        {

            if (service.InsertarVenta(venta))
            {
                return Ok();
            }
            else { return BadRequest(); }
        }

        // PUT api/<VentaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<VentaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
