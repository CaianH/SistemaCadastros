namespace Pettware_poo.View
{
    partial class CadProduto
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
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_AdicionarProduto = new System.Windows.Forms.Button();
            this.bt_ConsularProduto = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_Descrisao = new System.Windows.Forms.Label();
            this.tb_Descrisao = new System.Windows.Forms.TextBox();
            this.lb_PrecoSemDesconto = new System.Windows.Forms.Label();
            this.tb_PrecoSemDesconto = new System.Windows.Forms.TextBox();
            this.tb_PrecoComDesconto = new System.Windows.Forms.TextBox();
            this.lb_PrecoComDesconto = new System.Windows.Forms.Label();
            this.lb_QuantidadeEmEstoque = new System.Windows.Forms.Label();
            this.tb_QuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Perfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.bt_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salvar.ForeColor = System.Drawing.Color.White;
            this.bt_Salvar.Location = new System.Drawing.Point(1045, 586);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(140, 53);
            this.bt_Salvar.TabIndex = 0;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            this.bt_Salvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bt_Salvar_KeyDown);
            this.bt_Salvar.MouseEnter += new System.EventHandler(this.bt_Salvar_MouseEnter);
            this.bt_Salvar.MouseLeave += new System.EventHandler(this.bt_Salvar_MouseLeave);
            // 
            // bt_AdicionarProduto
            // 
            this.bt_AdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.bt_AdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AdicionarProduto.Location = new System.Drawing.Point(25, 602);
            this.bt_AdicionarProduto.Name = "bt_AdicionarProduto";
            this.bt_AdicionarProduto.Size = new System.Drawing.Size(189, 37);
            this.bt_AdicionarProduto.TabIndex = 1;
            this.bt_AdicionarProduto.Text = "Adicionar Produto";
            this.bt_AdicionarProduto.UseVisualStyleBackColor = false;
            this.bt_AdicionarProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ConsularProduto
            // 
            this.bt_ConsularProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.bt_ConsularProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ConsularProduto.Location = new System.Drawing.Point(25, 664);
            this.bt_ConsularProduto.Name = "bt_ConsularProduto";
            this.bt_ConsularProduto.Size = new System.Drawing.Size(224, 37);
            this.bt_ConsularProduto.TabIndex = 2;
            this.bt_ConsularProduto.Text = "Consultar Produto";
            this.bt_ConsularProduto.UseVisualStyleBackColor = false;
            this.bt_ConsularProduto.Click += new System.EventHandler(this.bt_ConsularProduto_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_Cancelar.Location = new System.Drawing.Point(893, 586);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(140, 53);
            this.bt_Cancelar.TabIndex = 3;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            this.bt_Cancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_Cancelar_KeyPress);
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Codigo.Location = new System.Drawing.Point(30, 112);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(90, 26);
            this.lb_Codigo.TabIndex = 4;
            this.lb_Codigo.Text = "Código:";
            this.lb_Codigo.Click += new System.EventHandler(this.lb_Codigo_Click);
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Enabled = false;
            this.tb_Codigo.Location = new System.Drawing.Point(150, 113);
            this.tb_Codigo.Multiline = true;
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(64, 29);
            this.tb_Codigo.TabIndex = 5;
            // 
            // lb_Descrisao
            // 
            this.lb_Descrisao.AutoSize = true;
            this.lb_Descrisao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Descrisao.Location = new System.Drawing.Point(25, 248);
            this.lb_Descrisao.Name = "lb_Descrisao";
            this.lb_Descrisao.Size = new System.Drawing.Size(220, 24);
            this.lb_Descrisao.TabIndex = 6;
            this.lb_Descrisao.Text = "Descrisão do Produto:";
            // 
            // tb_Descrisao
            // 
            this.tb_Descrisao.Enabled = false;
            this.tb_Descrisao.Location = new System.Drawing.Point(255, 248);
            this.tb_Descrisao.Multiline = true;
            this.tb_Descrisao.Name = "tb_Descrisao";
            this.tb_Descrisao.Size = new System.Drawing.Size(420, 29);
            this.tb_Descrisao.TabIndex = 7;
            // 
            // lb_PrecoSemDesconto
            // 
            this.lb_PrecoSemDesconto.AutoSize = true;
            this.lb_PrecoSemDesconto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoSemDesconto.Location = new System.Drawing.Point(25, 326);
            this.lb_PrecoSemDesconto.Name = "lb_PrecoSemDesconto";
            this.lb_PrecoSemDesconto.Size = new System.Drawing.Size(143, 24);
            this.lb_PrecoSemDesconto.TabIndex = 8;
            this.lb_PrecoSemDesconto.Text = "Preço Normal:";
            // 
            // tb_PrecoSemDesconto
            // 
            this.tb_PrecoSemDesconto.Enabled = false;
            this.tb_PrecoSemDesconto.Location = new System.Drawing.Point(179, 326);
            this.tb_PrecoSemDesconto.Multiline = true;
            this.tb_PrecoSemDesconto.Name = "tb_PrecoSemDesconto";
            this.tb_PrecoSemDesconto.Size = new System.Drawing.Size(132, 29);
            this.tb_PrecoSemDesconto.TabIndex = 9;
            // 
            // tb_PrecoComDesconto
            // 
            this.tb_PrecoComDesconto.Enabled = false;
            this.tb_PrecoComDesconto.Location = new System.Drawing.Point(253, 399);
            this.tb_PrecoComDesconto.Multiline = true;
            this.tb_PrecoComDesconto.Name = "tb_PrecoComDesconto";
            this.tb_PrecoComDesconto.Size = new System.Drawing.Size(132, 29);
            this.tb_PrecoComDesconto.TabIndex = 11;
            this.tb_PrecoComDesconto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_PrecoComDesconto
            // 
            this.lb_PrecoComDesconto.AutoSize = true;
            this.lb_PrecoComDesconto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoComDesconto.Location = new System.Drawing.Point(30, 399);
            this.lb_PrecoComDesconto.Name = "lb_PrecoComDesconto";
            this.lb_PrecoComDesconto.Size = new System.Drawing.Size(217, 24);
            this.lb_PrecoComDesconto.TabIndex = 10;
            this.lb_PrecoComDesconto.Text = "Preço Com Desconto:";
            this.lb_PrecoComDesconto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_QuantidadeEmEstoque
            // 
            this.lb_QuantidadeEmEstoque.AutoSize = true;
            this.lb_QuantidadeEmEstoque.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuantidadeEmEstoque.Location = new System.Drawing.Point(30, 469);
            this.lb_QuantidadeEmEstoque.Name = "lb_QuantidadeEmEstoque";
            this.lb_QuantidadeEmEstoque.Size = new System.Drawing.Size(240, 24);
            this.lb_QuantidadeEmEstoque.TabIndex = 12;
            this.lb_QuantidadeEmEstoque.Text = "Quantidade em Estoque:";
            // 
            // tb_QuantidadeEmEstoque
            // 
            this.tb_QuantidadeEmEstoque.Enabled = false;
            this.tb_QuantidadeEmEstoque.Location = new System.Drawing.Point(276, 469);
            this.tb_QuantidadeEmEstoque.Multiline = true;
            this.tb_QuantidadeEmEstoque.Name = "tb_QuantidadeEmEstoque";
            this.tb_QuantidadeEmEstoque.Size = new System.Drawing.Size(132, 29);
            this.tb_QuantidadeEmEstoque.TabIndex = 13;
            this.tb_QuantidadeEmEstoque.TextChanged += new System.EventHandler(this.tb_QuantidadeEmEstoque_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(103)))), ((int)(((byte)(125)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 28);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(147)))), ((int)(((byte)(72)))));
            this.pictureBox6.Image = global::Pettware_poo.Properties.Resources.download;
            this.pictureBox6.Location = new System.Drawing.Point(1065, 605);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox5.Image = global::Pettware_poo.Properties.Resources.cancel;
            this.pictureBox5.Location = new System.Drawing.Point(907, 605);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pictureBox4.Image = global::Pettware_poo.Properties.Resources.consultar;
            this.pictureBox4.Location = new System.Drawing.Point(211, 675);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.pictureBox3.Image = global::Pettware_poo.Properties.Resources.add;
            this.pictureBox3.Location = new System.Drawing.Point(179, 612);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pettware_poo.Properties.Resources.pet1_2;
            this.pictureBox2.Location = new System.Drawing.Point(1202, 655);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Pettware_poo.Properties.Resources.add_file;
            this.pictureBox1.Location = new System.Drawing.Point(1210, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_Perfil
            // 
            this.pb_Perfil.Image = global::Pettware_poo.Properties.Resources.anonimo;
            this.pb_Perfil.Location = new System.Drawing.Point(961, 129);
            this.pb_Perfil.Name = "pb_Perfil";
            this.pb_Perfil.Size = new System.Drawing.Size(243, 226);
            this.pb_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Perfil.TabIndex = 14;
            this.pb_Perfil.TabStop = false;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_Perfil);
            this.Controls.Add(this.tb_QuantidadeEmEstoque);
            this.Controls.Add(this.lb_QuantidadeEmEstoque);
            this.Controls.Add(this.tb_PrecoComDesconto);
            this.Controls.Add(this.lb_PrecoComDesconto);
            this.Controls.Add(this.tb_PrecoSemDesconto);
            this.Controls.Add(this.lb_PrecoSemDesconto);
            this.Controls.Add(this.tb_Descrisao);
            this.Controls.Add(this.lb_Descrisao);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_ConsularProduto);
            this.Controls.Add(this.bt_AdicionarProduto);
            this.Controls.Add(this.bt_Salvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadProduto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "                                                                                 " +
    "                                                                                " +
    "                      Cadastar Produto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_AdicionarProduto;
        private System.Windows.Forms.Button bt_ConsularProduto;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label lb_Descrisao;
        private System.Windows.Forms.TextBox tb_Descrisao;
        private System.Windows.Forms.Label lb_PrecoSemDesconto;
        private System.Windows.Forms.TextBox tb_PrecoSemDesconto;
        private System.Windows.Forms.TextBox tb_PrecoComDesconto;
        private System.Windows.Forms.Label lb_PrecoComDesconto;
        private System.Windows.Forms.Label lb_QuantidadeEmEstoque;
        private System.Windows.Forms.TextBox tb_QuantidadeEmEstoque;
        private System.Windows.Forms.PictureBox pb_Perfil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}