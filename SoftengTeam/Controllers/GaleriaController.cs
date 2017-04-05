using SoftengTeam.Business;
using SoftengTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftengTeam.Controllers
{
    public class GaleriaController : Controller
    {
        // GET: Galeria
        public ActionResult Galeria()
        {
            ImagenBusiness imagenBusiness = new ImagenBusiness();
            List<Imagen> imagenes = imagenBusiness.obtenerImagenes();
            return View(imagenes);
        }
    }
}