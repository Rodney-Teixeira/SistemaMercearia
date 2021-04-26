using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Modelo
{
    class VendaDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;
        public string Adicionar(Venda Venda)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into Venda values(null, null, null, GETDATE(), @fkid)";
            cmd.Parameters.AddWithValue("fkid", Venda.idfuncionario);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }

        internal SqlDataReader RetornarVendas()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Venda inner join Funcionario on fkid = Id where Valor_Total is not null";
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

        internal SqlDataReader RetornarItens()
        {
                //Comandos SQL para verificar se existe o usuário no banco.
                cmd.CommandText = "select Cod_Item, Descricao, Quantidade, Valor, Adicional, fkCod_Venda  " +
                "from Venda INNER JOIN Item_Pedido ON Cod_Venda = fkCod_Venda INNER JOIN Produto " +
                "ON fkId_Produto = Id_Produto WHERE fkCod_Venda=(SELECT MAX(Cod_Venda) FROM Venda)";
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

        internal string AtualizarVenda(Venda Venda)
        {
            Mensagem = String.Empty;
            int indice = 0;
            cmd.CommandText = "SELECT MAX(Cod_Venda) FROM Venda";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            while (dr.Read())
            {
                indice = dr.GetInt32(0);
            }
            dr.Close();

            try
            {
                //Comando SQL

                if (Mensagem == String.Empty)
                {
                    //dr.Read();
                    cmd.CommandText = "update Venda set Desconto = @Desconto, Valor_Total = @Valor_Total, Valor_Pago = @Valor_Pago WHERE Cod_Venda = @indice";
                    cmd.Parameters.AddWithValue("indice", indice);
                    cmd.Parameters.AddWithValue("Desconto", Venda.Desconto);
                    cmd.Parameters.AddWithValue("Valor_Total", Venda.Valor_Total);
                    cmd.Parameters.AddWithValue("Valor_Pago", Venda.Valor_Pago);


                    //conectar com banco
                    try
                    {
                        //Receber o endereço de onde vou me conectar.
                        cmd.Connection = con.Conectar();
                        //Executar comando.
                        cmd.ExecuteNonQuery();
                        //Exibe mensagem;
                        Mensagem = "Venda realizada com sucesso!";
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

        public string AdicionarItem(ItemPedido ItemPedido)
        {
            Mensagem = String.Empty;
            cmd.CommandText = "SELECT MAX(Cod_Venda) FROM Venda";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }

            //Comando SQL
            cmd.CommandText = "insert into Item_Pedido values (@Quantidade, @Adicional, @fkId_Produto, @FkCod_Venda )";
            cmd.Parameters.AddWithValue("Quantidade", ItemPedido.Quantidade);
            cmd.Parameters.AddWithValue("Adicional", ItemPedido.Adicional);
            cmd.Parameters.AddWithValue("fkid_Produto", ItemPedido.FkId_Produto);
            while (dr.Read())
            {
                cmd.Parameters.AddWithValue("FkCod_Venda", dr.GetInt32(0));
            }
            dr.Close();

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Mensagem = "Item cadastrado com sucesso!";
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }
            return Mensagem;
        }

        public string DeletarItem(int indice)
        {
            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "DELETE FROM Item_Pedido WHERE Cod_Item = @Cod_Item";
                cmd.Parameters.AddWithValue("Cod_Item", indice);
                cmd.ExecuteNonQuery();

                //Exibe mensagem;
                Mensagem = "Item excluido com sucesso!";

                con.Desconectar();

            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Ocorreu um erro: {0}", ex.Message));
            }
            return Mensagem;
        }
    }
}
