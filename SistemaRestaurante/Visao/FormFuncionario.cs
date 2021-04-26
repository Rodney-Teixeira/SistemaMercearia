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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                    ListViewItem lv = new ListViewItem(dr.GetInt32(0).ToString()); //Id
                    lv.SubItems.Add(dr.GetString(1));//Nome
                    lv.SubItems.Add(dr.GetString(2));//CPF
                    lv.SubItems.Add(dr.GetString(3));//Senha
                    lv.SubItems.Add(dr.GetString(6));//Email
                    listView1.Items.Add(lv); //Adiciona a linha criada à listview.
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int indiceFuncionario = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            int indiceEnd = -1;
            ControleFuncionario cc = new ControleFuncionario();
            SqlDataReader dr = cc.RetornarFuncionario(indiceFuncionario);

            if (dr != null)
            {
                while (dr.Read())
                {
                    txbNome.Text = dr.GetString(1);
                    mtxbCpf.Text = dr.GetString(2);
                    txbSenha.Text = dr.GetString(3);
                    mtxbCelular.Text = dr.GetString(4);
                    if (dr.GetString(5) == "Masculino")
                        rdbMasculino.Checked = true;
                    else
                        rdbFeminino.Checked = true;
                    txbEmail.Text = dr.GetString(6);
                    indiceEnd = dr.GetInt32(7);
                }
            }
            

            ControleEndereco ce = new ControleEndereco();
            dr = ce.RetornarEndereco(indiceEnd);
            if (dr != null)
            {
                while (dr.Read())
                {
                    txbLogradouro.Text = dr.GetString(1);
                    txbNumero.Text = dr.GetInt32(2).ToString();
                    txbComplemento.Text = dr.GetString(3);
                    txbBairro.Text = dr.GetString(4);
                    txbCep.Text = dr.GetString(5);
                    txbCidade.Text = dr.GetString(6);
                }
            }
        }

        public void LimparCampos()
        {
            txbNome.Text = String.Empty;
            mtxbCpf.Text = String.Empty;
            txbSenha.Text = String.Empty;
            mtxbCelular.Text = String.Empty;
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            txbEmail.Text = String.Empty;
            txbLogradouro.Text = String.Empty;
            txbNumero.Text = String.Empty;
            txbComplemento.Text = String.Empty;
            txbBairro.Text = String.Empty;
            txbCep.Text = String.Empty;
            txbCidade.Text = String.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            PreencherListView();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Endereco End = new Endereco(txbLogradouro.Text, int.Parse(txbNumero.Text), txbComplemento.Text, txbBairro.Text, txbCep.Text, txbCidade.Text);


            String genero = rdbMasculino.Checked == true ? "Masculino" : "Feminino";

            Funcionario Funcionario = new Funcionario(txbNome.Text, mtxbCpf.Text, txbSenha.Text, mtxbCelular.Text, genero, txbEmail.Text, End);
            ControleFuncionario cc = new ControleFuncionario();
            string mensagem = cc.AdicionarFuncionario(Funcionario); //Chama o método que realiza a inserção no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void BtnAtualizar_Click_1(object sender, EventArgs e)
        {
            Endereco End = new Endereco(txbLogradouro.Text, int.Parse(txbNumero.Text), txbComplemento.Text, txbBairro.Text, txbCep.Text, txbCidade.Text);


            String genero = rdbMasculino.Checked == true ? "Masculino" : "Feminino";

            Funcionario Funcionario = new Funcionario(txbNome.Text, mtxbCpf.Text, txbSenha.Text, mtxbCelular.Text, genero, txbEmail.Text, End);
            ControleFuncionario cc = new ControleFuncionario();
            int indiceFuncionario = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string mensagem = cc.AtualizarFuncionario(indiceFuncionario, Funcionario); //Chama o método que atualiza o cadastro no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void BtnRemover_Click_1(object sender, EventArgs e)
        {
            int indiceFuncionario = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            ControleFuncionario cc = new ControleFuncionario();
            string mensagem = cc.DeletarFuncionario(indiceFuncionario); //Chama o método que exclui cadastro no banco.

            MessageBox.Show(mensagem);
            PreencherListView();
            LimparCampos();
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
