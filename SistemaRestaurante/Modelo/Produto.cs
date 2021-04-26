using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelo
{
    class Produto
    {
        public int Id_Produto { get; set; }
        public string Cod_Produto { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public string Tipo { get; set; }
        public string Ingredientes { get; set; }

        public Produto(string Cod_Produto, string Descricao, float Valor, string Tipo, string Ingredientes)
        {
            this.Cod_Produto = Cod_Produto;
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.Tipo = Tipo;
            this.Ingredientes = Ingredientes;
        }
    }
}
