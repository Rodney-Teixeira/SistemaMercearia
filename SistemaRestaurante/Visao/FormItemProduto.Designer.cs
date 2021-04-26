namespace SistemaRestaurante.Visao
{
    partial class FormItemPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCod_Produto = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Buscar Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Quantidade";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(400, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 26);
            this.textBox3.TabIndex = 34;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Código do Produto";
            // 
            // txbCod_Produto
            // 
            this.txbCod_Produto.Location = new System.Drawing.Point(79, 36);
            this.txbCod_Produto.Name = "txbCod_Produto";
            this.txbCod_Produto.ReadOnly = true;
            this.txbCod_Produto.Size = new System.Drawing.Size(130, 20);
            this.txbCod_Produto.TabIndex = 40;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(12, 80);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.ReadOnly = true;
            this.txbDescricao.Size = new System.Drawing.Size(274, 20);
            this.txbDescricao.TabIndex = 42;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(12, 63);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(55, 13);
            this.lblLogradouro.TabIndex = 41;
            this.lblLogradouro.Text = "Descrição";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(215, 36);
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(70, 20);
            this.txbValor.TabIndex = 43;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(212, 18);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 44;
            this.Valor.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listView1
            // 
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
            this.listView1.Location = new System.Drawing.Point(12, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 227);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 36;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 184;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ingredientes";
            this.columnHeader5.Width = 263;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Adicional";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(387, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 26);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(61, 20);
            this.textBox4.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Id";
            // 
            // FormItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbCod_Produto);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "FormItemPedido";
            this.Text = "FormItemPedido";
            this.Load += new System.EventHandler(this.FormItemProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCod_Produto;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}