namespace SistemaRestaurante.Visao
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gpbListarInfo = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbInfoPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCod_Produto = new System.Windows.Forms.TextBox();
            this.txbIngredientes = new System.Windows.Forms.TextBox();
            this.Ingredientes = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbListarInfo.SuspendLayout();
            this.gpbInfoPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(230, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 39);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(174, 154);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 39);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Location = new System.Drawing.Point(118, 154);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(50, 39);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemover.Location = new System.Drawing.Point(62, 154);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(50, 39);
            this.btnRemover.TabIndex = 18;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 154);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 39);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // gpbListarInfo
            // 
            this.gpbListarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbListarInfo.Controls.Add(this.listView1);
            this.gpbListarInfo.Location = new System.Drawing.Point(32, 199);
            this.gpbListarInfo.Name = "gpbListarInfo";
            this.gpbListarInfo.Size = new System.Drawing.Size(774, 252);
            this.gpbListarInfo.TabIndex = 16;
            this.gpbListarInfo.TabStop = false;
            this.gpbListarInfo.Text = "Listar Cadastros";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 221);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ingredientes";
            this.columnHeader5.Width = 263;
            // 
            // gpbInfoPessoais
            // 
            this.gpbInfoPessoais.Controls.Add(this.lblNome);
            this.gpbInfoPessoais.Controls.Add(this.txbCod_Produto);
            this.gpbInfoPessoais.Controls.Add(this.txbIngredientes);
            this.gpbInfoPessoais.Controls.Add(this.Ingredientes);
            this.gpbInfoPessoais.Controls.Add(this.txbDescricao);
            this.gpbInfoPessoais.Controls.Add(this.lblLogradouro);
            this.gpbInfoPessoais.Controls.Add(this.txbValor);
            this.gpbInfoPessoais.Controls.Add(this.Valor);
            this.gpbInfoPessoais.Controls.Add(this.txbTipo);
            this.gpbInfoPessoais.Controls.Add(this.lblComplemento);
            this.gpbInfoPessoais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbInfoPessoais.Location = new System.Drawing.Point(32, 0);
            this.gpbInfoPessoais.Name = "gpbInfoPessoais";
            this.gpbInfoPessoais.Size = new System.Drawing.Size(337, 193);
            this.gpbInfoPessoais.TabIndex = 14;
            this.gpbInfoPessoais.TabStop = false;
            this.gpbInfoPessoais.Text = "Informações do produto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Código do Produto";
            this.lblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // txbCod_Produto
            // 
            this.txbCod_Produto.Location = new System.Drawing.Point(6, 34);
            this.txbCod_Produto.Name = "txbCod_Produto";
            this.txbCod_Produto.Size = new System.Drawing.Size(220, 20);
            this.txbCod_Produto.TabIndex = 0;
            // 
            // txbIngredientes
            // 
            this.txbIngredientes.Location = new System.Drawing.Point(6, 164);
            this.txbIngredientes.Name = "txbIngredientes";
            this.txbIngredientes.Size = new System.Drawing.Size(325, 20);
            this.txbIngredientes.TabIndex = 5;
            // 
            // Ingredientes
            // 
            this.Ingredientes.AutoSize = true;
            this.Ingredientes.Location = new System.Drawing.Point(3, 147);
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Size = new System.Drawing.Size(65, 13);
            this.Ingredientes.TabIndex = 11;
            this.Ingredientes.Text = "Ingredientes";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(6, 77);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(309, 20);
            this.txbDescricao.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 60);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(55, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Descrição";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(7, 121);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(70, 20);
            this.txbValor.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(4, 104);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 2;
            this.Valor.Text = "Valor";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(97, 121);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(68, 20);
            this.txbTipo.TabIndex = 3;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(94, 104);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(28, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Produto";
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(0, 34);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(309, 20);
            this.txbBusca.TabIndex = 13;
            this.txbBusca.TextChanged += new System.EventHandler(this.TxbBusca_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txbBusca);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(375, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 193);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.gpbListarInfo);
            this.Controls.Add(this.gpbInfoPessoais);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load_1);
            this.gpbListarInfo.ResumeLayout(false);
            this.gpbInfoPessoais.ResumeLayout(false);
            this.gpbInfoPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gpbListarInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gpbInfoPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCod_Produto;
        private System.Windows.Forms.TextBox txbIngredientes;
        private System.Windows.Forms.Label Ingredientes;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}