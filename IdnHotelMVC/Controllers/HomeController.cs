using IdnHotelMVC.Models;
using IdnHotelMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdnHotelMVC.Controllers
{
    public class HomeController : Controller
    {
        DB_Hotel_IDNEntities context = new DB_Hotel_IDNEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscaDados(ObjetoJSON objeto)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataReader rdr;

            conn.Open();

            SqlCommand cmd = new SqlCommand("GetHospedagem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@idAgencia", objeto.ddlAgenciaNome));

            cmd.Parameters.Add(new SqlParameter("@andarApto", objeto.ddlAptoAndar));
            cmd.Parameters.Add(new SqlParameter("@numApto", objeto.ddlAptoNumero));
            cmd.Parameters.Add(new SqlParameter("@tipoApto", objeto.ddlAptoTipo));

            cmd.Parameters.Add(new SqlParameter("@clienteProfissao", objeto.ddlClienteProfissao));
            cmd.Parameters.Add(new SqlParameter("@clienteMeioTransporte", objeto.ddlClienteTransporte));
            cmd.Parameters.Add(new SqlParameter("@clienteMotivo", objeto.ddlClienteMotivo));

            cmd.Parameters.Add(new SqlParameter("@idProduto", objeto.ddlProduto));

            cmd.Parameters.Add(new SqlParameter("@idServico", objeto.ddlServico));

            cmd.Parameters.Add(new SqlParameter("@tempoAno", objeto.ddlTempoAno));
            cmd.Parameters.Add(new SqlParameter("@tempoTrimestre", objeto.ddlTempoTrimestre));
            cmd.Parameters.Add(new SqlParameter("@tempoMes", objeto.ddlTempoMes));

            rdr = cmd.ExecuteReader();

            List<DadosRetorno> listaDados = new List<DadosRetorno>();

            while (rdr.Read())
            {
                DadosRetorno dados = new DadosRetorno();

                dados.ValorConsumo = (Int32)rdr[28];
                dados.ConsumoQuantidade = (Int32)rdr[29];
                dados.ConsumoValorFaturado = (Int32)rdr[5];

                dados.ClienteProfissao = rdr[9].ToString();
                dados.ClienteMeioTransporte = rdr[10].ToString();
                dados.ClienteMotivo = rdr[11].ToString();
                dados.AptoAndar = (Int32)rdr[13];
                dados.AptoNumero = (Int32)rdr[14];
                dados.AptoTipo = rdr[15].ToString();
                dados.Agencia = rdr[17].ToString();
                dados.TempoAno = (Int32)rdr[19];
                dados.TempoTrimestre = (Int32)rdr[20];
                dados.TempoMes = rdr[21].ToString();
                dados.ServicoNome = rdr[33].ToString();
                dados.ProdutoDescricao = rdr[31].ToString();

                listaDados.Add(dados);
            }

            return Json(listaDados);

        }

        [HttpPost]
        public ActionResult GetFaturamentoAgenciaTempo(string ano, string nomeAgencia)
        {
            if (ano == "0")
            {
                var query = nomeAgencia == "0" ?

                    context.Hospedagem
                    .GroupBy(h => new { h.Agencia.Nome })
                    .Select(h => new HospedagemDTO
                    {
                        NomeAgencia = h.Key.Nome,
                        ValorFaturado = h.Sum(v => v.ValorFaturado)
                    }).ToList() :

                    context.Hospedagem
                    .GroupBy(h => new { h.Agencia.Nome })
                    .Where(h => h.Key.Nome == nomeAgencia)
                    .Select(h => new HospedagemDTO
                    {
                        NomeAgencia = h.Key.Nome,
                        ValorFaturado = h.Sum(v => v.ValorFaturado)
                    }).ToList();

                return Json(new { result = query }, JsonRequestBehavior.AllowGet);
            }

            int anoInt = int.Parse(ano);

            var query2 = nomeAgencia == "0" ?

                context.Hospedagem
                .GroupBy(h => new { h.Agencia.Nome, h.Tempo.Ano })
                .Where(h => h.Key.Ano == anoInt)
                .Select(h => new HospedagemDTO
                {
                    NomeAgencia = h.Key.Nome,
                    AnoTempo = h.Key.Ano,
                    ValorFaturado = h.Sum(v => v.ValorFaturado)
                }).ToList() :

                context.Hospedagem
                .GroupBy(h => new { h.Agencia.Nome, h.Tempo.Ano })
                .Where(h => h.Key.Ano == anoInt)
                .Where(h => h.Key.Nome == nomeAgencia)
                .Select(h => new HospedagemDTO
                {
                    NomeAgencia = h.Key.Nome,
                    AnoTempo = h.Key.Ano,
                    ValorFaturado = h.Sum(v => v.ValorFaturado)
                }).ToList();

            return Json(new { result = query2 }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetFaturamentoProfissaoTempo(string trimestre, string profissao)
        {
            if (trimestre == "0")
            {
                var query = profissao == "0" ?

                    context.Consumo
                    .GroupBy(c => new { c.Cliente.Profissao })
                    .Select(c => new ConsumoDTO
                    {
                        NomeProfissao = c.Key.Profissao,
                        ValorFaturado = c.Sum(v => v.ValorConsumo)
                    }).ToList() :

                    context.Consumo
                    .GroupBy(c => new { c.Cliente.Profissao })
                    .Where(c => c.Key.Profissao == profissao)
                    .Select(c => new ConsumoDTO
                    {
                        NomeProfissao = c.Key.Profissao,
                        ValorFaturado = c.Sum(v => v.ValorConsumo)
                    }).ToList();

                return Json(new { result = query }, JsonRequestBehavior.AllowGet);
            }

            int trimestreInt = int.Parse(trimestre);

            var query2 = profissao == "0" ?

                context.Consumo
                .GroupBy(c => new { c.Cliente.Profissao, c.Tempo.Trimestre })
                .Where(c => c.Key.Trimestre == trimestreInt)
                .Select(c => new ConsumoDTO
                {
                    NomeProfissao = c.Key.Profissao,
                    TrimestreTempo = c.Key.Trimestre,
                    ValorFaturado = c.Sum(v => v.ValorConsumo)
                }).ToList() :

                context.Consumo
                .GroupBy(c => new { c.Cliente.Profissao, c.Tempo.Trimestre })
                .Where(c => c.Key.Trimestre == trimestreInt)
                .Where(c => c.Key.Profissao == profissao)
                .Select(c => new ConsumoDTO
                {
                    NomeProfissao = c.Key.Profissao,
                    TrimestreTempo = c.Key.Trimestre,
                    ValorFaturado = c.Sum(v => v.ValorConsumo)
                }).ToList();

            return Json(new { result = query2 }, JsonRequestBehavior.AllowGet);
        }
    }
}
