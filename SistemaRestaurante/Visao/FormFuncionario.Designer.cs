namespace SistemaRestaurante
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.lblCideade = new System.Windows.Forms.Label();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gpbInfoPessoais = new System.Windows.Forms.GroupBox();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.mtxbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.gpbListarInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.gpbEndereco.SuspendLayout();
            this.gpbInfoPessoais.SuspendLayout();
            this.gpbGenero.SuspendLayout();
            this.gpbListarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(6, 34);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(325, 20);
            this.txbNome.TabIndex = 0;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(3, 60);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(121, 77);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(101, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(118, 60);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(38, 13);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "Senha";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(6, 167);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(325, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(669, 227);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Senha";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 263;
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txbBairro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.txbCidade);
            this.gpbEndereco.Controls.Add(this.lblCideade);
            this.gpbEndereco.Controls.Add(this.txbCep);
            this.gpbEndereco.Controls.Add(this.lblCep);
            this.gpbEndereco.Controls.Add(this.txbComplemento);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.txbNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.txbLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Location = new System.Drawing.Point(373, 12);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(324, 151);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(176, 77);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(142, 20);
            this.txbBairro.TabIndex = 4;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(173, 60);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(114, 121);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(204, 20);
            this.txbCidade.TabIndex = 6;
            // 
            // lblCideade
            // 
            this.lblCideade.AutoSize = true;
            this.lblCideade.Location = new System.Drawing.Point(111, 104);
            this.lblCideade.Name = "lblCideade";
            this.lblCideade.Size = new System.Drawing.Size(40, 13);
            this.lblCideade.TabIndex = 10;
            this.lblCideade.Text = "Cidade";
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(10, 121);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(90, 20);
            this.txbCep.TabIndex = 5;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(7, 104);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 8;
            this.lblCep.Text = "CEP";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(94, 77);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(68, 20);
            this.txbComplemento.TabIndex = 3;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(91, 60);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(10, 77);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(70, 20);
            this.txbNumero.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 60);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número";
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(9, 34);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(309, 20);
            this.txbLogradouro.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 17);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // gpbInfoPessoais
            // 
            this.gpbInfoPessoais.Controls.Add(this.gpbGenero);
            this.gpbInfoPessoais.Controls.Add(this.mtxbCelular);
            this.gpbInfoPessoais.Controls.Add(this.lblCelular);
            this.gpbInfoPessoais.Controls.Add(this.mtxbCpf);
            this.gpbInfoPessoais.Controls.Add(this.lblNome);
            this.gpbInfoPessoais.Controls.Add(this.txbNome);
            this.gpbInfoPessoais.Controls.Add(this.txbEmail);
            this.gpbInfoPessoais.Controls.Add(this.lblCpf);
            this.gpbInfoPessoais.Controls.Add(this.lblEmail);
            this.gpbInfoPessoais.Controls.Add(this.lblRg);
            this.gpbInfoPessoais.Controls.Add(this.txbSenha);
            this.gpbInfoPessoais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbInfoPessoais.Location = new System.Drawing.Point(21, 12);
            this.gpbInfoPessoais.Name = "gpbInfoPessoais";
            this.gpbInfoPessoais.Size = new System.Drawing.Size(337, 193);
            this.gpbInfoPessoais.TabIndex = 0;
            this.gpbInfoPessoais.TabStop = false;
            this.gpbInfoPessoais.Text = "Informações pessoais";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdbFeminino);
            this.gpbGenero.Controls.Add(this.rdbMasculino);
            this.gpbGenero.Location = new System.Drawing.Point(121, 105);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(210, 37);
            this.gpbGenero.TabIndex = 6;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Gênero";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(111, 13);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(32, 13);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // mtxbCelular
            // 
            this.mtxbCelular.Location = new System.Drawing.Point(7, 121);
            this.mtxbCelular.Mask = "(00) 90000-0000";
            this.mtxbCelular.Name = "mtxbCelular";
            this.mtxbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxbCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(4, 104);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 8;
            this.lblCelular.Text = "Celular";
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Location = new System.Drawing.Point(7, 77);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtxbCpf.TabIndex = 1;
            // 
            // gpbListarInfo
            // 
            this.gpbListarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbListarInfo.Controls.Add(this.listView1);
            this.gpbListarInfo.Location = new System.Drawing.Point(21, 211);
            this.gpbListarInfo.Name = "gpbListarInfo";
            this.gpbListarInfo.Size = new System.Drawing.Size(676, 252);
            this.gpbListarInfo.TabIndex = 6;
            this.gpbListarInfo.TabStop = false;
            this.gpbListarInfo.Text = "Listar Cadastros";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(605, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 39);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_3);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(382, 169);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 39);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemover.Location = new System.Drawing.Point(438, 169);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(50, 39);
            this.btnRemover.TabIndex = 23;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Location = new System.Drawing.Point(493, 169);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(50, 39);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(549, 169);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 39);
            this.btnHome.TabIndex = 25;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.gpbListarInfo);
            this.Controls.Add(this.gpbInfoPessoais);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.btnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Funcionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbInfoPessoais.ResumeLayout(false);
            this.gpbInfoPessoais.PerformLayout();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.gpbListarInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label lblCideade;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.GroupBox gpbInfoPessoais;
        private System.Windows.Forms.MaskedTextBox mtxbCpf;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.MaskedTextBox mtxbCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox gpbListarInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnHome;
    }
}

