using SoftengTeam.Business;
using SoftengTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftengTeam.Controllers
{
    public class ContactenosController : Controller
    {
        // GET: Contactenos
        public ActionResult Contactenos()
        {

            HotelBusiness hotelBusiness = new HotelBusiness();
            List<Hotel> hoteles = hotelBusiness.obtenerHotelesBusiness();

            foreach(Hotel hotel in hoteles)
            {
                ViewData["descripcion"] = hotel.SobreNosotrosHotel+"";
            }
            

            ImagenBusiness imagenBusiness = new ImagenBusiness();
            List<Imagen> imagenes = imagenBusiness.obtenerImagenes();
            return View(imagenes);
            /*
          
            return View(hoteles);
            
         
        
            */

        }
    }
}