using IdnHotelMVC.Models.DTO;
using IdnHotelMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IdnHotelMVC.Controllers
{
    public class DataController : ApiController
    {
        DB_Hotel_IDNEntities context = new DB_Hotel_IDNEntities();

        public BancoDTO Get_DB()
        {
            return new BancoDTO
            {
                Agencias = Get_Agencia(),
                Apartamentos = Get_Apartamento(),
                Clientes = Get_Cliente(),
                Produtos = Get_Produto(),
                Servicos = Get_Servico(),
                Tempos = Get_Tempo()
            };
        }

        public List<AgenciaDTO> Get_Agencia()
        {
            return context.Agencia
                .Select(a => new AgenciaDTO
                {
                    Id = a.Id,
                    Nome = a.Nome
                }).ToList();
        }

        public List<ApartamentoDTO> Get_Apartamento()
        {
            return context.Apartamento
                .Select(a => new ApartamentoDTO
                {
                    Id = a.Id,
                    Andar = a.Andar,
                    Numero = a.Numero,
                    Tipo = a.Tipo
                }).ToList();
        }

        public List<ClienteDTO> Get_Cliente()
        {
            return context.Cliente
                .Select(c => new ClienteDTO
                {
                    Id = c.Id,
                    Cpf = c.Cpf,
                    Nome = c.Nome,
                    Profissao = c.Profissao,
                    MeioTransporte = c.MeioTransporte,
                    Motivo = c.Motivo
                }).ToList();
        }

        public List<ProdutoDTO> Get_Produto()
        {
            return context.Produto
                .Select(p => new ProdutoDTO
                {
                    Id = p.Id,
                    Descricao = p.Descricao
                }).ToList();
        }

        public List<ServicoDTO> Get_Servico()
        {
            return context.Servico
                .Select(s => new ServicoDTO
                {
                    Id = s.Id,
                    Nome = s.Nome
                }).ToList();
        }

        public List<TempoDTO> Get_Tempo()
        {
            return context.Tempo
                .Select(t => new TempoDTO
                {
                    Id = t.Id,
                    Ano = t.Ano,
                    Trimestre = t.Trimestre,
                    Mes = t.Mes
                }).ToList();
        }        
    }
}
