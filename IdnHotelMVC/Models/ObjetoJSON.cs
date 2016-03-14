using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models
{
    public class ObjetoJSON
    {
        public int? ddlAgenciaNome { get; set; }


        public int? ddlAptoNumero { get; set; }
        public int? ddlAptoAndar { get; set; }
        public string ddlAptoTipo { get; set; }


        public string ddlClienteTransporte { get; set; }
        public string ddlClienteMotivo { get; set; }
        public string ddlClienteProfissao { get; set; }


        public int? ddlProduto { get; set; }


        public int? ddlServico { get; set; }


        public int? ddlTempoAno { get; set; }
        public int? ddlTempoTrimestre { get; set; }
        public string ddlTempoMes { get; set; }
    }
}



