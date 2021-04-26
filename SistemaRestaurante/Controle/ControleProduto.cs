using SistemaRestaurante.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controle
{
    class ControleProduto
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Produto a ser inserido no banco.
        public string AdicionarProduto(Produto Produto)
        {
            ProdutoDAO cli = new ProdutoDAO();
            string mensagem = cli.Adicionar(Produto);
            return mensagem;
        }

       public string AtualizarProduto(int indice, Produto Produto)
        {
            ProdutoDAO cli = new ProdutoDAO();
            string mensagem = cli.Atualizar(indice, Produto);
            return mensagem;
        }

        public string DeletarProduto(int indice)
        {
            ProdutoDAO cli = new ProdutoDAO();
            return cli.Deletar(indice);
        }

        //Método intermediário utilizado para retornar informações dos Produtos que estão salvos no banco.
        public SqlDataReader RetornarProdutos()
        {
            ProdutoDAO cli = new ProdutoDAO();
            return cli.RetornarProdutos();
        }

        public SqlDataReader RetornarProduto(int indice)
        {
            ProdutoDAO cli = new ProdutoDAO();
            return cli.RetornarProduto(indice);
        }

        public SqlDataReader BuscarProduto(string txbBusca)
        {
            ProdutoDAO cli = new ProdutoDAO();
            return cli.BuscarProduto(txbBusca);
        }

    }
}
