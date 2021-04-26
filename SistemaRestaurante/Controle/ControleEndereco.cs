using SistemaRestaurante.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controle
{
    class ControleEndereco
    {
        public SqlDataReader RetornarEnderecos()
        {
            EnderecoDAO end = new EnderecoDAO();
            return end.RetornarEnderecos();
        }
        public SqlDataReader RetornarEndereco(int indice)
        {
            EnderecoDAO end = new EnderecoDAO();
            return end.RetornarEndereco(indice);
        }
    }
}
