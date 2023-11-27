using CineBack.Datos;
using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    public class PeliculaController : Controller
    {

        Servicio service = new Servicio(); 
        // GET: PeliculaController
        [HttpGet("TraerPeliculas")]
        public ActionResult GetPeliculas()
        {
           
                List<Pelicula> lista = service.ConsultarPeliculas();
                try
                {
                    return Ok(lista);
                }
                catch
                {
                    return BadRequest();
                }
        }
        [HttpGet("TraerPeliculasFiltradas")]
        //[ValidateAntiForgeryToken]
        public ActionResult Get(List<Parametro> lstParametros)
        {
            try
            {
                return Ok(service.ConsultarPeliculasFiltradas(lstParametros));
            }
            catch
            {
                return BadRequest();
            }
        }
        //// GET: PeliculaController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: PeliculaController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: PeliculaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeliculaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculaController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PeliculaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
