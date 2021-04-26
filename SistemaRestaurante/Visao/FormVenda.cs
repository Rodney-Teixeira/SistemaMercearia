using SistemaRestaurante.Controle;
using SistemaRestaurante.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Visao
{
    public partial class FormVenda : Form
    {
        int idfuncionario;
        public FormVenda(int idfuncionario)
        {
            this.idfuncionario = idfuncionario;
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GpbListarInfo_Enter(object sender, EventArgs e)
        {

        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FormItemPedido frmItemPedido = new FormItemPedido();
            frmItemPedido.ShowDialog();
            PreencherListView();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            Venda Venda = new Venda(idfuncionario);
            ControleVenda cc = new ControleVenda();
            string mensagem = cc.AdicionarVenda(Venda);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleVenda cc = new ControleVenda();

            dr = cc.RetornarItens(); //Chama o método responsável pela realização da consulta. 

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString()); //Id
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetInt32(2).ToString());
                    lv.SubItems.Add(dr.GetDecimal(3).ToString());
                    lv.SubItems.Add(dr.GetDecimal(4).ToString());
                    lv.SubItems.Add((dr.GetDecimal(3) * dr.GetInt32(2) + dr.GetDecimal(4)).ToString());
                    txbNPedido.Text = dr.GetInt32(5).ToString();

                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }

                var total = 0m;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    total += decimal.Parse(listView1.Items[i].SubItems[5].Text);
                }
                if (textBox7.Text != String.Empty)
                {
                    txbValorTotal.Text = (total - decimal.Parse(textBox7.Text)).ToString("N2");
                }
                else
                {
                    txbValorTotal.Text = total.ToString("N2");
                }
            }
            else txbValorTotal.Text = String.Empty;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txbValorTotal.Text != String.Empty)
                if (textBox1.Text != String.Empty)
                    textBox5.Text = (decimal.Parse(textBox1.Text) - decimal.Parse(txbValorTotal.Text)).ToString();
                else
                    textBox5.Text = String.Empty;
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
                int indiceItemPedido = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                ControleVenda cc = new ControleVenda();
                string mensagem = cc.DeletarItem(indiceItemPedido); //Chama o método que exclui cadastro no banco.

                PreencherListView();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Venda Venda = new Venda(decimal.Parse(textBox7.Text), decimal.Parse(txbValorTotal.Text), decimal.Parse(textBox1.Text));
            ControleVenda cc = new ControleVenda();
            string mensagem = cc.AtualizarVenda(Venda); //Chama o método que atualiza o cadastro no banco.

            MessageBox.Show(mensagem);
            this.Close();
        }

        private void TextBox7_TextChanged_1(object sender, EventArgs e)
        {
            PreencherListView();
        }
    }
}
