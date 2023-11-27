using CineBack.Datos.Implementacion;
using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
using Microsoft.AspNetCore.Mvc;
using System.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   

    //INSTALAR NEWTONSOFT.JSON
    public class ClienteController : ControllerBase
    {
        Servicio service = new Servicio();
        ClienteDao clienteDao = new ClienteDao();

        //GET: api/<ClienteController>
        [HttpGet("TraerClientes")]
        public IActionResult Get()
        {
            return Ok(service.ObtenerClientes());
        }

        //// GET api/<ClienteController>/5
        //[HttpGet("TraerClientes")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ClienteController>
        [HttpPost("InsertarClientes")]
        public IActionResult Post(Cliente client)
        {
            if (service.InsertarCliente(client))
            {
                return Ok();
            }
            else { return BadRequest(); }
            
        }
        

        // PUT api/<ClienteController>/5
        [HttpPut("ActualizarClientes")]
        public IActionResult Put(Cliente client)
        {
            if (service.ActualizarCliente(client))
            {
                return Ok();
            }
            else { return BadRequest(); }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("DeleteClient")]
        public IActionResult Delete(int id)
        {
            if (service.BorrarCliente(id))
            {
                return Ok();
            }
            else { return BadRequest(); }
        }
    }
}
