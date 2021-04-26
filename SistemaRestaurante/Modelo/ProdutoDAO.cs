using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Modelo
{
    class ProdutoDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(Produto Produto)
        {
            Mensagem = String.Empty;

            //Comando SQL
            cmd.CommandText = "insert into Produto values (@Cod_Produto, @Descricao, @Valor, @Tipo, @Ingredientes)";
            cmd.Parameters.AddWithValue("Cod_Produto", Produto.Cod_Produto);
            cmd.Parameters.AddWithValue("Descricao", Produto.Descricao);
            cmd.Parameters.AddWithValue("Valor", Produto.Valor);
            cmd.Parameters.AddWithValue("Tipo", Produto.Tipo);
            cmd.Parameters.AddWithValue("Ingredientes", Produto.Ingredientes);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Produto cadastrado com sucesso!";
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }

        public SqlDataReader BuscarProduto(string txbBusca)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Produto WHERE Descricao LIKE '%" + txbBusca + "%'";
            //Parametros que serão substituídos no CommandText.

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }


        public SqlDataReader RetornarProdutos()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Produto";
            //Parametros que serão substituídos no CommandText.

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }

        public SqlDataReader RetornarProduto(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Produto where Id_Produto = @Id_Produto";
            cmd.Parameters.AddWithValue("Id_Produto", indice);

            try
            {
                cmd.Connection = con.Conectar(); //Tenta estabelecer a conexão com o banco de dados. 
                dr = cmd.ExecuteReader(); //Realiza a execução do SQL e obtém o retorno do banco em forma de objeto SQLDataReader.
                //Verifica se existe algum retorno na consulta do banco.
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                //Não é a mensagem mais apropriada!
                Console.WriteLine(ex.Message);
            }
            con.Desconectar();
            return null;
        }

        public string Deletar(int indice)
        {
            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "DELETE FROM Produto WHERE Id_Produto = @Id_Produto";
                cmd.Parameters.AddWithValue("Id_Produto", indice);
                cmd.ExecuteNonQuery();

                //Exibe mensagem;
                Mensagem = "Produto excluido com sucesso!";

                con.Desconectar();

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Ocorreu um erro: {0}", ex.Message));
            }
            return Mensagem;
        }

        public string Atualizar(int indice, Produto Produto)
        {
            Mensagem = String.Empty;
            try
            {
                //Comando SQL

                if (Mensagem == String.Empty)
                {
                    //dr.Read();
                    cmd.CommandText = "update Produto set Cod_Produto = @Cod_Produto, Descricao = @Descricao, Valor = @Valor, Tipo = @Tipo, Ingredientes = @Ingredientes WHERE Id_Produto = @Id_Produto";
                    cmd.Parameters.AddWithValue("Id_Produto", indice);
                    cmd.Parameters.AddWithValue("Cod_Produto", Produto.Cod_Produto);
                    cmd.Parameters.AddWithValue("Descricao", Produto.Descricao);
                    cmd.Parameters.AddWithValue("Valor", Produto.Valor);
                    cmd.Parameters.AddWithValue("Tipo", Produto.Tipo);
                    cmd.Parameters.AddWithValue("Ingredientes", Produto.Ingredientes);

                    //conectar com banco
                    try
                    {
                        //Receber o endereço de onde vou me conectar.
                        cmd.Connection = con.Conectar();
                        //Executar comando.
                        cmd.ExecuteNonQuery();
                        //Exibe mensagem;
                        Mensagem = "Produto atualizado com sucesso!";
                    }
                    catch (SqlException ex)
                    {
                        //Captura a mensagem de erro gerada.
                        Mensagem = ex.Message;
                    }
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Ocorreu um erro: {0}", ex.Message));
            }
            return Mensagem;
        }
        
    }
}