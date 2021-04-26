using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelo
{
    class Venda
    {
        public int Cod_Venda { get; set; }
        public decimal Desconto { get; set; }
        public decimal Valor_Total { get; set; }
        public decimal Valor_Pago { get; set; }
        public int idfuncionario { get; set; }

        public Venda (int idfuncionario)
        {
            this.idfuncionario = idfuncionario;
        }
        public Venda(decimal Desconto, decimal Valor_Total,decimal Valor_Pago)
        {
            this.Desconto = Desconto;
            this.Valor_Total = Valor_Total;
            this.Valor_Pago = Valor_Pago;
        }
    }
}
