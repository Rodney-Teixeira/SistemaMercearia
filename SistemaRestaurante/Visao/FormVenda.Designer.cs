namespace SistemaRestaurante.Visao
{
    partial class FormVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbListarInfo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbNPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.gpbListarInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader5,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 227);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor Un.";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adicional";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor Total";
            this.columnHeader4.Width = 90;
            // 
            // gpbListarInfo
            // 
            this.gpbListarInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbListarInfo.Controls.Add(this.button1);
            this.gpbListarInfo.Controls.Add(this.button2);
            this.gpbListarInfo.Controls.Add(this.btnRemover);
            this.gpbListarInfo.Controls.Add(this.btnAdicionar);
            this.gpbListarInfo.Controls.Add(this.listView1);
            this.gpbListarInfo.Location = new System.Drawing.Point(12, 123);
            this.gpbListarInfo.Name = "gpbListarInfo";
            this.gpbListarInfo.Size = new System.Drawing.Size(676, 315);
            this.gpbListarInfo.TabIndex = 17;
            this.gpbListarInfo.TabStop = false;
            this.gpbListarInfo.Text = "Itens Venda";
            this.gpbListarInfo.Enter += new System.EventHandler(this.GpbListarInfo_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 41;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(489, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemover.BackgroundImage")));
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemover.Location = new System.Drawing.Point(69, 27);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(50, 39);
            this.btnRemover.TabIndex = 23;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(13, 27);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 39);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txbNPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbValorTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 115);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // txbNPedido
            // 
            this.txbNPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNPedido.Location = new System.Drawing.Point(84, 20);
            this.txbNPedido.Name = "txbNPedido";
            this.txbNPedido.ReadOnly = true;
            this.txbNPedido.Size = new System.Drawing.Size(173, 23);
            this.txbNPedido.TabIndex = 42;
            this.txbNPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "N° Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Valor Troco";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(326, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(139, 38);
            this.textBox5.TabIndex = 40;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(4, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 38;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Valor Desconto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Valor Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Valor Total";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorTotal.Location = new System.Drawing.Point(489, 46);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.ReadOnly = true;
            this.txbValorTotal.Size = new System.Drawing.Size(139, 38);
            this.txbValorTotal.TabIndex = 32;
            this.txbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbListarInfo);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.gpbListarInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gpbListarInfo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbNPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
    }
}