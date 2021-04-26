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
    public partial class FormItemPedido : Form
    {
        public FormItemPedido()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
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
                }
            }

        }

        private void FormItemProduto_Load(object sender, EventArgs e)
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

        private void ListView1_Click(object sender, EventArgs e)
        {
            int indiceProduto = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ControleProduto cc = new ControleProduto();
            SqlDataReader dr = cc.RetornarProduto(indiceProduto);

            if (dr != null)
            {
                while (dr.Read())
                {
                    textBox4.Text = dr.GetInt32(0).ToString();
                    txbCod_Produto.Text = dr.GetString(1);
                    txbDescricao.Text = dr.GetString(2);
                    txbValor.Text = dr.GetDecimal(3).ToString();
                }
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                listView1.Items.Clear();

                SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
                ControleProduto cc = new ControleProduto();
                dr = cc.BuscarProduto(textBox1.Text); //Chama o método responsável pela realização da consulta. 

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

        private void Button1_Click(object sender, EventArgs e)
        {
            ItemPedido ItemPedido = new ItemPedido(int.Parse(textBox3.Text), decimal.Parse(textBox2.Text), int.Parse(textBox4.Text));
            ControleVenda cc = new ControleVenda();
            string mensagem = cc.AdicionarItem(ItemPedido); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
