using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftengTeam.Models
{
    public class Imagen
    {

        public int idImagen { get; set; }
        public String nombreImagen { get; set; }
        public Boolean publicidadImagen { get; set; }

        public Imagen(int idImagen, String nombreImagen, Boolean publicidadImagen)
        {
            this.idImagen = idImagen;
            this.nombreImagen = nombreImagen;
            this.publicidadImagen = publicidadImagen;
        }
       
    }
}