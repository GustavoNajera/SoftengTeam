using SoftengTeam.Data;
using SoftengTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftengTeam.Business
{
    public class ImagenBusiness
    {

        private ImagenData imagenData;

        public ImagenBusiness()
        {
            this.imagenData = new ImagenData("Data Source = ucr.database.windows.net; Initial Catalog = HighGardenResort; Integrated Security = False; User ID = adm; Password = saucr.092; Connect Timeout = 15; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        public List<Imagen> obtenerImagenes()
        {
            List<Imagen> list = this.imagenData.obtenerImagenes();
            return list;
        }

    }
}