using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdnHotelMVC.Models.DTO
{
    public class BancoDTO
    {
        public List<AgenciaDTO> Agencias { get; set; }

        public List<ApartamentoDTO> Apartamentos { get; set; }

        public List<ClienteDTO> Clientes { get; set; }

        public List<ProdutoDTO> Produtos { get; set; }

        public List<ServicoDTO> Servicos { get; set; }

        public List<TempoDTO> Tempos { get; set; }
    }
}