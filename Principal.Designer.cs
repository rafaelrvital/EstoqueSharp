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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelSubConfiguracoes = new System.Windows.Forms.Panel();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.panelSubRecord = new System.Windows.Forms.Panel();
            this.btnPDV = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.panelSubEstoque = new System.Windows.Forms.Panel();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panelSubProduto = new System.Windows.Forms.Panel();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnListaProdutos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubConfiguracoes.SuspendLayout();
            this.panelSubRecord.SuspendLayout();
            this.panelSubEstoque.SuspendLayout();
            this.panelSubProduto.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.panelSubConfiguracoes);
            this.panelMenu.Controls.Add(this.btnConfiguracoes);
            this.panelMenu.Controls.Add(this.panelSubRecord);
            this.panelMenu.Controls.Add(this.btnRecord);
            this.panelMenu.Controls.Add(this.btnFornecedor);
            this.panelMenu.Controls.Add(this.panelSubEstoque);
            this.panelMenu.Controls.Add(this.btnEstoque);
            this.panelMenu.Controls.Add(this.panelSubProduto);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 845);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(183, 45);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // panelSubConfiguracoes
            // 
            this.panelSubConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.panelSubConfiguracoes.Controls.Add(this.btnLoja);
            this.panelSubConfiguracoes.Controls.Add(this.btnUsuario);
            this.panelSubConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubConfiguracoes.Location = new System.Drawing.Point(0, 755);
            this.panelSubConfiguracoes.Name = "panelSubConfiguracoes";
            this.panelSubConfiguracoes.Size = new System.Drawing.Size(183, 90);
            this.panelSubConfiguracoes.TabIndex = 10;
            // 
            // btnLoja
            // 
            this.btnLoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoja.FlatAppearance.BorderSize = 0;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.ForeColor = System.Drawing.Color.White;
            this.btnLoja.Location = new System.Drawing.Point(0, 45);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLoja.Size = new System.Drawing.Size(183, 45);
            this.btnLoja.TabIndex = 6;
            this.btnLoja.Text = "Loja";
            this.btnLoja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(183, 45);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 710);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(183, 45);
            this.btnConfiguracoes.TabIndex = 9;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // panelSubRecord
            // 
            this.panelSubRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.panelSubRecord.Controls.Add(this.btnPDV);
            this.panelSubRecord.Controls.Add(this.btnVendas);
            this.panelSubRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRecord.Location = new System.Drawing.Point(0, 620);
            this.panelSubRecord.Name = "panelSubRecord";
            this.panelSubRecord.Size = new System.Drawing.Size(183, 90);
            this.panelSubRecord.TabIndex = 8;
            // 
            // btnPDV
            // 
            this.btnPDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPDV.FlatAppearance.BorderSize = 0;
            this.btnPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDV.ForeColor = System.Drawing.Color.White;
            this.btnPDV.Location = new System.Drawing.Point(0, 45);
            this.btnPDV.Name = "btnPDV";
            this.btnPDV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPDV.Size = new System.Drawing.Size(183, 45);
            this.btnPDV.TabIndex = 6;
            this.btnPDV.Text = "PDV";
            this.btnPDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDV.UseVisualStyleBackColor = true;
            this.btnPDV.Click += new System.EventHandler(this.btnPDV_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(0, 0);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVendas.Size = new System.Drawing.Size(183, 45);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(0, 575);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(183, 45);
            this.btnRecord.TabIndex = 7;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Location = new System.Drawing.Point(0, 530);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFornecedor.Size = new System.Drawing.Size(183, 45);
            this.btnFornecedor.TabIndex = 6;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // panelSubEstoque
            // 
            this.panelSubEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.panelSubEstoque.Controls.Add(this.btnAjuste);
            this.panelSubEstoque.Controls.Add(this.btnEntrada);
            this.panelSubEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEstoque.Location = new System.Drawing.Point(0, 440);
            this.panelSubEstoque.Name = "panelSubEstoque";
            this.panelSubEstoque.Size = new System.Drawing.Size(183, 90);
            this.panelSubEstoque.TabIndex = 5;
            // 
            // btnAjuste
            // 
            this.btnAjuste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjuste.FlatAppearance.BorderSize = 0;
            this.btnAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuste.ForeColor = System.Drawing.Color.White;
            this.btnAjuste.Location = new System.Drawing.Point(0, 45);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAjuste.Size = new System.Drawing.Size(183, 45);
            this.btnAjuste.TabIndex = 6;
            this.btnAjuste.Text = "Ajuste";
            this.btnAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuste.UseVisualStyleBackColor = true;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(183, 45);
            this.btnEntrada.TabIndex = 5;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(0, 395);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(183, 45);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panelSubProduto
            // 
            this.panelSubProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.panelSubProduto.Controls.Add(this.btnMarca);
            this.panelSubProduto.Controls.Add(this.btnCategoria);
            this.panelSubProduto.Controls.Add(this.btnListaProdutos);
            this.panelSubProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProduto.Location = new System.Drawing.Point(0, 260);
            this.panelSubProduto.Name = "panelSubProduto";
            this.panelSubProduto.Size = new System.Drawing.Size(183, 135);
            this.panelSubProduto.TabIndex = 3;
            // 
            // btnMarca
            // 
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.Location = new System.Drawing.Point(0, 90);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMarca.Size = new System.Drawing.Size(183, 45);
            this.btnMarca.TabIndex = 5;
            this.btnMarca.Text = "Marca";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Location = new System.Drawing.Point(0, 45);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategoria.Size = new System.Drawing.Size(183, 45);
            this.btnCategoria.TabIndex = 4;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnListaProdutos
            // 
            this.btnListaProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaProdutos.FlatAppearance.BorderSize = 0;
            this.btnListaProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaProdutos.ForeColor = System.Drawing.Color.White;
            this.btnListaProdutos.Location = new System.Drawing.Point(0, 0);
            this.btnListaProdutos.Name = "btnListaProdutos";
            this.btnListaProdutos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaProdutos.Size = new System.Drawing.Size(183, 45);
            this.btnListaProdutos.TabIndex = 3;
            this.btnListaProdutos.Text = "Lista de Produtos";
            this.btnListaProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaProdutos.UseVisualStyleBackColor = true;
            this.btnListaProdutos.Click += new System.EventHandler(this.btnListaProdutos_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Location = new System.Drawing.Point(0, 215);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(183, 45);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 170);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(183, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblNome);
            this.panelLogo.Controls.Add(this.lblUsuario);
            this.panelLogo.Controls.Add(this.lblCargo);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(6, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(53, 118);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(27, 147);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(109, 20);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(984, 40);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(253, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(487, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 621);
            this.panelMain.TabIndex = 2;
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Principal";
            this.Text = "EstoqueSharp";
            this.panelMenu.ResumeLayout(false);
            this.panelSubConfiguracoes.ResumeLayout(false);
            this.panelSubRecord.ResumeLayout(false);
            this.panelSubEstoque.ResumeLayout(false);
            this.panelSubProduto.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelSubProduto;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnListaProdutos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel panelSubEstoque;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Panel panelSubRecord;
        private System.Windows.Forms.Button btnPDV;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelSubConfiguracoes;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}

