using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models
{
    public class DadosRetorno
    {
        public int ConsumoValorFaturado { get; set; }
        public int ConsumoQuantidade { get; set; }
        public int ValorConsumo { get; set; }


        public string ClienteProfissao { get; set; }
        public string ClienteMeioTransporte { get; set; }
        public string ClienteMotivo { get; set; }
        public int AptoAndar { get; set; }
        public int AptoNumero { get; set; }
        public string AptoTipo { get; set; }
        public string Agencia { get; set; }
        public int TempoAno { get; set; }
        public int TempoTrimestre { get; set; }
        public string TempoMes { get; set; }
        public string ServicoNome { get; set; }
        public string ProdutoDescricao { get; set; }
    }
}