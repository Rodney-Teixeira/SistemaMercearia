using SistemaRestaurante.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controle
{
    //Esta classe é responsável por verificações e validações de dados referentes ao Funcionario.
    class ControleFuncionario
    {
        //Método onde podem ser realizadas validações acerca das informações informadas para o Funcionario a ser inserido no banco.
        public string AdicionarFuncionario(Funcionario Funcionario)
        {
            FuncionarioDAO cli = new FuncionarioDAO();
            string mensagem = cli.Adicionar(Funcionario);
            return mensagem;
        }

        public string AtualizarFuncionario(int indice, Funcionario Funcionario)
        {
            FuncionarioDAO cli = new FuncionarioDAO();
            string mensagem = cli.Atualizar(indice, Funcionario);
            return mensagem;
        }

        public string DeletarFuncionario(int indice)
        {
            FuncionarioDAO cli = new FuncionarioDAO();
            return cli.Deletar(indice);
        }

        //Método intermediário utilizado para retornar informações dos Funcionarios que estão salvos no banco.
        public SqlDataReader RetornarFuncionarios()
        {
            FuncionarioDAO cli = new FuncionarioDAO();
            return cli.RetornarFuncionarios();
        }

        public SqlDataReader RetornarFuncionario(int indice)
        {
            FuncionarioDAO cli = new FuncionarioDAO();
            return cli.RetornarFuncionario(indice);
        }
    }
}
