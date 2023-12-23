namespace EstoqueSharp
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelConfiguracoes = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.panelSaida = new System.Windows.Forms.Panel();
            this.btnSaida = new System.Windows.Forms.Button();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnUnidadeMedida = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timerCadastro = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelConfiguracoes.SuspendLayout();
            this.panelSaida.SuspendLayout();
            this.panelEntrada.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panelMenu.Controls.Add(this.panelConfiguracoes);
            this.panelMenu.Controls.Add(this.panelSaida);
            this.panelMenu.Controls.Add(this.panelEntrada);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.panelCadastro);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panelConfiguracoes
            // 
            this.panelConfiguracoes.Controls.Add(this.btnConfiguracoes);
            this.panelConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguracoes.Location = new System.Drawing.Point(0, 350);
            this.panelConfiguracoes.Name = "panelConfiguracoes";
            this.panelConfiguracoes.Size = new System.Drawing.Size(200, 45);
            this.panelConfiguracoes.TabIndex = 5;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(200, 45);
            this.btnConfiguracoes.TabIndex = 9;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // panelSaida
            // 
            this.panelSaida.Controls.Add(this.btnSaida);
            this.panelSaida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaida.Location = new System.Drawing.Point(0, 305);
            this.panelSaida.Name = "panelSaida";
            this.panelSaida.Size = new System.Drawing.Size(200, 45);
            this.panelSaida.TabIndex = 5;
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.ForeColor = System.Drawing.Color.White;
            this.btnSaida.Location = new System.Drawing.Point(0, 0);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSaida.Size = new System.Drawing.Size(200, 45);
            this.btnSaida.TabIndex = 6;
            this.btnSaida.Text = "Saída";
            this.btnSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // panelEntrada
            // 
            this.panelEntrada.Controls.Add(this.btnEntrada);
            this.panelEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntrada.Location = new System.Drawing.Point(0, 260);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(200, 45);
            this.panelEntrada.TabIndex = 4;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(200, 45);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 616);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(200, 45);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.btnProduto);
            this.panelCadastro.Controls.Add(this.btnUnidadeMedida);
            this.panelCadastro.Controls.Add(this.btnFornecedor);
            this.panelCadastro.Controls.Add(this.btnCadastro);
            this.panelCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastro.Location = new System.Drawing.Point(0, 215);
            this.panelCadastro.MaximumSize = new System.Drawing.Size(200, 180);
            this.panelCadastro.MinimumSize = new System.Drawing.Size(200, 45);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(200, 45);
            this.panelCadastro.TabIndex = 4;
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.Location = new System.Drawing.Point(0, 135);
            this.btnProduto.MaximumSize = new System.Drawing.Size(200, 45);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProduto.Size = new System.Drawing.Size(200, 45);
            this.btnProduto.TabIndex = 6;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnUnidadeMedida
            // 
            this.btnUnidadeMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.btnUnidadeMedida.FlatAppearance.BorderSize = 0;
            this.btnUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadeMedida.ForeColor = System.Drawing.Color.White;
            this.btnUnidadeMedida.Location = new System.Drawing.Point(0, 90);
            this.btnUnidadeMedida.Name = "btnUnidadeMedida";
            this.btnUnidadeMedida.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUnidadeMedida.Size = new System.Drawing.Size(200, 45);
            this.btnUnidadeMedida.TabIndex = 7;
            this.btnUnidadeMedida.Text = "Unidade de medida";
            this.btnUnidadeMedida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidadeMedida.UseVisualStyleBackColor = false;
            this.btnUnidadeMedida.Click += new System.EventHandler(this.btnUnidadeMedida_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Location = new System.Drawing.Point(0, 45);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFornecedor.Size = new System.Drawing.Size(200, 45);
            this.btnFornecedor.TabIndex = 9;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(200, 45);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 170);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(200, 45);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lblUsuario);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "________________________";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(60, 118);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(984, 40);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(253, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(487, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 621);
            this.panelMain.TabIndex = 2;
            // 
            // timerCadastro
            // 
            this.timerCadastro.Enabled = true;
            this.timerCadastro.Interval = 10;
            this.timerCadastro.Tick += new System.EventHandler(this.timerCadastro_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstoqueSharp";
            this.panelMenu.ResumeLayout(false);
            this.panelConfiguracoes.ResumeLayout(false);
            this.panelSaida.ResumeLayout(false);
            this.panelEntrada.ResumeLayout(false);
            this.panelCadastro.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCadastro;
        private System.Windows.Forms.Button btnUnidadeMedida;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Panel panelSaida;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Panel panelConfiguracoes;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Button btnFornecedor;
    }
}

