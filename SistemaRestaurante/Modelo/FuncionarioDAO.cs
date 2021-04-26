using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Modelo
{
    class FuncionarioDAO
    {
        public string Mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand(); //Cria objeto para definição e execução de comando SQL.
        Conexao con = new Conexao(); //Cria objeto que estabelecerá a conexão com o banco.
        //Armazena o retorno de uma consulta feita no banco.
        SqlDataReader dr;

        public string Adicionar(Funcionario Funcionario)
        {
            Mensagem = String.Empty;
            //Comando SQL
            cmd.CommandText = "insert into Endereco values (@logradouro, @numero, @complemento, @bairro, @cep, @cidade)";
            cmd.Parameters.AddWithValue("logradouro", Funcionario.End.Logradouro);
            cmd.Parameters.AddWithValue("numero", Funcionario.End.Numero);
            cmd.Parameters.AddWithValue("complemento", Funcionario.End.Complemento);
            cmd.Parameters.AddWithValue("bairro", Funcionario.End.Bairro);
            cmd.Parameters.AddWithValue("cep", Funcionario.End.Cep);
            cmd.Parameters.AddWithValue("cidade", Funcionario.End.Cidade);

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
            //Seleciona o maior Id de endereço, ou seja, o último adicionado.
            cmd.CommandText = "SELECT MAX(Id) FROM Endereco";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Mensagem = ex.Message;
            }

            if (Mensagem == String.Empty) {
                //dr.Read();
                cmd.CommandText = "insert into Funcionario values (@nome, @cpf, @Senha, @celular, @genero, @email, @endereco)";
                cmd.Parameters.AddWithValue("nome", Funcionario.Nome);
                cmd.Parameters.AddWithValue("cpf", Funcionario.Cpf);
                cmd.Parameters.AddWithValue("Senha", Funcionario.Senha);
                cmd.Parameters.AddWithValue("celular", Funcionario.Celular);
                cmd.Parameters.AddWithValue("genero", Funcionario.Genero);
                cmd.Parameters.AddWithValue("email", Funcionario.Email);
                while (dr.Read())
                {
                    cmd.Parameters.AddWithValue("endereco", dr.GetInt32(0));
                }
                dr.Close();
                //conectar com banco
                try
                {
                    //Receber o endereço de onde vou me conectar.
                    cmd.Connection = con.Conectar();
                    //Executar comando.
                    cmd.ExecuteNonQuery();
                    //Exibe mensagem;
                    Mensagem = "Funcionario cadastrado com sucesso!!!";
                }
                catch (SqlException ex)
                {
                    //Captura a mensagem de erro gerada.
                    Mensagem = ex.Message;
                }
            }
            return Mensagem;
        }

        public SqlDataReader RetornarFuncionarios()
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Funcionario";
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

        public SqlDataReader RetornarFuncionario(int indice)
        {
            //Comandos SQL para verificar se existe o usuário no banco.
            cmd.CommandText = "select * from Funcionario where Id = @id";
            cmd.Parameters.AddWithValue("id", indice);

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
                cmd.CommandText = "DELETE FROM Funcionario WHERE Id = @Id";
                cmd.Parameters.AddWithValue("Id", indice);
                cmd.ExecuteNonQuery();
                
                //Exibe mensagem;
                Mensagem = "Funcionario excluido com sucesso!";

                con.Desconectar();
            
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Ocorreu um erro: {0}", ex.Message));
            }
            return Mensagem;
        }

        public string Atualizar(int indice, Funcionario Funcionario)
        {
            Mensagem = String.Empty;
            try
            {
                //Comando SQL
                
                cmd.CommandText = "insert into Endereco values (@logradouro, @numero, @complemento, @bairro, @cep, @cidade)";
                cmd.Parameters.AddWithValue("logradouro", Funcionario.End.Logradouro);
                cmd.Parameters.AddWithValue("numero", Funcionario.End.Numero);
                cmd.Parameters.AddWithValue("complemento", Funcionario.End.Complemento);
                cmd.Parameters.AddWithValue("bairro", Funcionario.End.Bairro);
                cmd.Parameters.AddWithValue("cep", Funcionario.End.Cep);
                cmd.Parameters.AddWithValue("cidade", Funcionario.End.Cidade);
               
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
                //Seleciona o maior Id de endereço, ou seja, o último adicionado.
                cmd.CommandText = "SELECT MAX(Id) FROM Endereco";
                try
                {
                    cmd.Connection = con.Conectar();
                    dr = cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    Mensagem = ex.Message;
                }
                if (Mensagem == String.Empty)
                {
                    //dr.Read();
                    cmd.CommandText = "update Funcionario set nome = @nome, cpf = @cpf, Senha = @Senha, celular = @celular, genero = @genero, email = @email, FkIdEndereco = @endereco WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", indice);
                    cmd.Parameters.AddWithValue("nome", Funcionario.Nome);
                    cmd.Parameters.AddWithValue("cpf", Funcionario.Cpf);
                    cmd.Parameters.AddWithValue("Senha", Funcionario.Senha);
                    cmd.Parameters.AddWithValue("celular", Funcionario.Celular);
                    cmd.Parameters.AddWithValue("genero", Funcionario.Genero);
                    cmd.Parameters.AddWithValue("email", Funcionario.Email);
                    while (dr.Read())
                    {
                        cmd.Parameters.AddWithValue("endereco", dr.GetInt32(0));
                    }
                    dr.Close();
                    //conectar com banco
                    try
                    {
                        //Receber o endereço de onde vou me conectar.
                        cmd.Connection = con.Conectar();
                        //Executar comando.
                        cmd.ExecuteNonQuery();
                        //Exibe mensagem;
                        Mensagem = "Funcionario atualizado com sucesso!!!";
                        cmd.CommandText = "DELETE E FROM Endereco E LEFT JOIN Funcionario F ON E.Id = FkIdEndereco WHERE FkIdEndereco is null";
                        cmd.ExecuteNonQuery();
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
