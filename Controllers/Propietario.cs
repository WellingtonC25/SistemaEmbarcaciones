using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gestion_de_Embarcaciones.Models;

namespace Gestion_de_Embarcaciones.Controllers
{
    public class Propietario : Controller
    {
        // GET: PropietarioController
        public ActionResult Index()
        {
            // Create a list of parts.
            List<Gestion_de_Embarcaciones.Models.Propietario> propietarios = new List<Gestion_de_Embarcaciones.Models.Propietario>();

            // Add parts to the list.
            propietarios.Add(new Models.Propietario
            {
                Id = 1,
                Cedula_Pasaporte = "40212777367",
                Nombre = "Wellington",
                Apellidos = "De La Cruz Ortiz",
                Direccion = "Villa Laura",
                Email = "wellingtoncesarortiz@gmail.com",
                Telefono = 8097410702,
                Celular = 8497634578,
                IdPais = 1,
                IdCiudad = 1,
                Zip = 10102
            });
 

            return View(propietarios.ToList());
        }

        // GET: PropietarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropietarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropietarioController/Create
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

        // GET: PropietarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropietarioController/Edit/5
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

        // GET: PropietarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropietarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
