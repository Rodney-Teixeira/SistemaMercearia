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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int indiceProduto = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ControleProduto cc = new ControleProduto();
            SqlDataReader dr = cc.RetornarProduto(indiceProduto);

            if (dr != null)
            {
                while (dr.Read())
                {
                    txbCod_Produto.Text = dr.GetString(0);
                    txbDescricao.Text = dr.GetString(1);
                    txbValor.Text = dr.GetDecimal(2).ToString();
                    txbTipo.Text = dr.GetString(3);
                    txbIngredientes.Text = dr.GetString(4);
                }
            }

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Produto Produto = new Produto(txbCod_Produto.Text, txbDescricao.Text, float.Parse(txbValor.Text), txbTipo.Text, txbIngredientes.Text);
            ControleProduto cc = new ControleProduto();
            string mensagem = cc.AdicionarProduto(Produto); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleProduto cc = new ControleProduto();
            dr = cc.RetornarProdutos(); //Chama o método responsável pela realização da consulta. 

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString()); //Id_Produto
                    lv.SubItems.Add(dr.GetString(1));//Cod_Produto
                    lv.SubItems.Add(dr.GetString(2));//Descricao
                    lv.SubItems.Add(dr.GetDecimal(3).ToString());//Valor
                    lv.SubItems.Add(dr.GetString(4));//Tipo
                    lv.SubItems.Add(dr.GetString(5));//Ingredientes
                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }



        public void LimparCampos()
        {
            txbCod_Produto.Text = String.Empty;
            txbDescricao.Text = String.Empty;
            txbTipo.Text = String.Empty;
            txbValor.Text = String.Empty;
            txbIngredientes.Text = String.Empty;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduto_Load_1(object sender, EventArgs e)
        {
            PreencherListView();
            LimparCampos();
        }



        private void ListView1_Click(object sender, EventArgs e)
        {
            int indiceProduto = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ControleProduto cc = new ControleProduto();
            SqlDataReader dr = cc.RetornarProduto(indiceProduto);

            if (dr != null)
            {
                while (dr.Read())
                {
                    txbCod_Produto.Text = dr.GetString(1);
                    txbDescricao.Text = dr.GetString(2);
                    txbValor.Text = dr.GetDecimal(3).ToString();
                    txbTipo.Text = dr.GetString(4);
                    txbIngredientes.Text = dr.GetString(5);
                }
            }

        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int indiceProduto = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ControleProduto cc = new ControleProduto();
            string mensagem = cc.DeletarProduto(indiceProduto); //Chama o método que exclui cadastro no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Produto Produto = new Produto(txbCod_Produto.Text, txbDescricao.Text, float.Parse(txbValor.Text), txbTipo.Text, txbIngredientes.Text);
            ControleProduto cc = new ControleProduto();
            int indiceProduto = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string mensagem = cc.AtualizarProduto(indiceProduto, Produto); //Chama o método que atualiza o cadastro no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxbBusca_TextChanged(object sender, EventArgs e)
        {
            if (txbBusca.Text != string.Empty)
            {
                listView1.Items.Clear();

                SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                ControleProduto cc = new ControleProduto();
                dr = cc.BuscarProduto(txbBusca.Text); //Chama o método responsável pela realização da consulta. 

                if (dr != null) //Verifico 
                {
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString()); //Id_Produto
                        lv.SubItems.Add(dr.GetString(1));//Cod_Produto
                        lv.SubItems.Add(dr.GetString(2));//Descricao
                        lv.SubItems.Add(dr.GetDecimal(3).ToString());//Valor
                        lv.SubItems.Add(dr.GetString(4));//Tipo
                        lv.SubItems.Add(dr.GetString(5));//Ingredientes
                        listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                    }
                }
            }
            else
                PreencherListView();
        }
    }
}
