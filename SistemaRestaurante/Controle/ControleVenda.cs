using SistemaRestaurante.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Controle
{
    class ControleVenda
    {
        public string AdicionarVenda(Venda Venda)
        {
            VendaDAO cli = new VendaDAO();
            string mensagem = cli.Adicionar(Venda);
            return mensagem;
        }

        public string DeletarItem(int indice)
        {
            VendaDAO cli = new VendaDAO();
            return cli.DeletarItem(indice);
        }

        public string AdicionarItem(ItemPedido ItemPedido)
        {
            VendaDAO cli = new VendaDAO();
            string mensagem = cli.AdicionarItem(ItemPedido);
            return mensagem;
        }

        internal SqlDataReader RetornarVendas()
        {
            VendaDAO cli = new VendaDAO();
            return cli.RetornarVendas();
        }

        internal SqlDataReader RetornarItens()
        {
            VendaDAO cli = new VendaDAO();
            return cli.RetornarItens();
        }

        internal string AtualizarVenda(Venda Venda)
        {
            VendaDAO cli = new VendaDAO();
            string mensagem = cli.AtualizarVenda(Venda);
            return mensagem;
        }
    }
}
