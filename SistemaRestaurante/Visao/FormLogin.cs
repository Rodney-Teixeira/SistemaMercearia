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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string senha;
            int idfuncionario; 
            if (txbUsuario.Text != String.Empty & txbSenha.Text != String.Empty)
            {
                idfuncionario = int.Parse(txbUsuario.Text);
                ControleFuncionario cc = new ControleFuncionario();
                SqlDataReader dr = cc.RetornarFuncionario(idfuncionario);

                if (dr != null)
                {
                    while (dr.Read())
                    {

                        senha = dr.GetString(3);
                        if (txbSenha.Text == senha)
                        {
                            FormPrincipal frmPrincipal = new FormPrincipal(idfuncionario);
                            this.Hide();
                            frmPrincipal.ShowDialog();
                            txbUsuario.Text = string.Empty;
                            txbSenha.Text = string.Empty;
                            this.Show();
                        }
                        else
                            MessageBox.Show("Senha Inválida!");
                    }
                }
                else
                    MessageBox.Show("Usuário Inválido!");
            }

            else
            {
                MessageBox.Show("Preencha os dados de Usuário e Senha!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
