using SistemaRestaurante.Controle;
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
    public partial class Relatório_de_Venda : Form
    {
        public Relatório_de_Venda()
        {
            InitializeComponent();
        }

        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleVenda cc = new ControleVenda();

            dr = cc.RetornarVendas(); //Chama o método responsável pela realização da consulta. 

            if (dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString()); //Id Venda
                    lv.SubItems.Add(dr.GetDecimal(1).ToString()); //Desconto
                    lv.SubItems.Add(dr.GetDecimal(2).ToString()); //Valor Total
                    lv.SubItems.Add(dr.GetDecimal(3).ToString()); //Valor Pago
                    lv.SubItems.Add(dr.GetDateTime(4).ToString()); //Data
                    lv.SubItems.Add(dr.GetString(7)); //Nome funcionario
                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Relatório_de_Venda_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }
    }
}
