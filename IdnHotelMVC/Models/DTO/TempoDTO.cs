using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models.DTO
{
    public class TempoDTO
    {
        public int Id { get; set; }

        public int Ano { get; set; }

        public int Trimestre { get; set; }

        public string Mes { get; set; }
    }
}