using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Visao
{
    public partial class FormPrincipal : Form
    {
        int idfuncionario;
        public FormPrincipal(int idfuncionario)
        {
            this.idfuncionario = idfuncionario;
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario frmFuncionario = new FormFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto frmProduto = new FormProduto();
            frmProduto.ShowDialog();
        }

        private void VenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda frmVenda = new FormVenda(idfuncionario);
            frmVenda.ShowDialog();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatório_de_Venda frmRelatorio = new Relatório_de_Venda();
            frmRelatorio.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }

}
