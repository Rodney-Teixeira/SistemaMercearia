using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelo
{
    class ItemPedido
    {
        public int Id_ItemProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Adicional { get; set; }
        public int FkId_Produto { get; set; }
        public int FkCod_Venda { get; set; }

        public ItemPedido(int Quantidade, decimal Adicional, int FkId_Produto)
        {
            this.Quantidade = Quantidade;
            this.Adicional = Adicional;
            this.FkId_Produto = FkId_Produto;
        }
    }
}
