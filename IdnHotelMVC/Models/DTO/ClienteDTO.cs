using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Profissao { get; set; }

        public string MeioTransporte { get; set; }

        public string Motivo { get; set; }
    }
}