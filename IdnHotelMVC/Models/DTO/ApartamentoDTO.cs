using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models.DTO
{
    public class ApartamentoDTO
    {
        public int Id { get; set; }

        public int Andar { get; set; }

        public int Numero { get; set; }

        public string Tipo { get; set; }
    }
}