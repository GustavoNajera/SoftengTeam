using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftengTeam.Models
{
    public class Hotel
    {
        private String descripcionHotel;
        private String sobreNosotrosHotel;
        private String contactoHotel;

        public Hotel(String descripcionHotel, String sobreNosotrosHotel, String contactoHotel)
        {
            this.descripcionHotel = descripcionHotel;
            this.sobreNosotrosHotel = sobreNosotrosHotel;
            this.contactoHotel = contactoHotel;
        }
        public string DescripcionHotel
        {
            get
            {
                return descripcionHotel;
            }

            set
            {
                descripcionHotel = value;
            }
        }

        public string SobreNosotrosHotel
        {
            get
            {
                return sobreNosotrosHotel;
            }

            set
            {
                sobreNosotrosHotel = value;
            }
        }

        public string ContactoHotel
        {
            get
            {
                return contactoHotel;
            }

            set
            {
                contactoHotel = value;
            }
        }
    }
}

