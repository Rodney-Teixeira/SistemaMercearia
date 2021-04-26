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

namespace SistemaRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario Funcionario = new Funcionario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            ControleFuncionario cc = new ControleFuncionario();
            string mensagem = cc.AdicionarFuncionario(Funcionario); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr; //Objeto para armazenar o retorno do banco. 
            ControleFuncionario cc = new ControleFuncionario();
            dr = cc.RetornarFuncionarios(); //Chama o método responsável pela realização da consulta. 

            if(dr != null) //Verifico 
            {
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString());
                    lv.SubItems.Add(dr.GetString(1));//Nome
                    lv.SubItems.Add(dr.GetString(2));//CPF
                    lv.SubItems.Add(dr.GetString(3));//RG
                    lv.SubItems.Add(dr.GetString(4));//Email
                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }
    }
}
