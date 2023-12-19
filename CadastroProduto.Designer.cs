namespace EstoqueSharp
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCdMarca = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCdBarra = new System.Windows.Forms.TextBox();
            this.txtVlrPreco = new System.Windows.Forms.TextBox();
            this.txtDsProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.picFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 41);
            this.panel1.TabIndex = 7;
            // 
            // picFechar
            // 
            this.picFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(709, 3);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(30, 30);
            this.picFechar.TabIndex = 1;
            this.picFechar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // lblCdMarca
            // 
            this.lblCdMarca.AutoSize = true;
            this.lblCdMarca.Location = new System.Drawing.Point(15, 216);
            this.lblCdMarca.Name = "lblCdMarca";
            this.lblCdMarca.Size = new System.Drawing.Size(87, 20);
            this.lblCdMarca.TabIndex = 13;
            this.lblCdMarca.Text = "cd_Marca";
            this.lblCdMarca.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(634, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(80)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(538, 212);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 29);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(442, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.Location = new System.Drawing.Point(163, 57);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(87, 26);
            this.txtCdProduto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código de barras:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preço:";
            // 
            // txtCdBarra
            // 
            this.txtCdBarra.Location = new System.Drawing.Point(163, 131);
            this.txtCdBarra.Name = "txtCdBarra";
            this.txtCdBarra.Size = new System.Drawing.Size(561, 26);
            this.txtCdBarra.TabIndex = 8;
            // 
            // txtVlrPreco
            // 
            this.txtVlrPreco.Location = new System.Drawing.Point(163, 168);
            this.txtVlrPreco.Name = "txtVlrPreco";
            this.txtVlrPreco.Size = new System.Drawing.Size(87, 26);
            this.txtVlrPreco.TabIndex = 8;
            // 
            // txtDsProduto
            // 
            this.txtDsProduto.Location = new System.Drawing.Point(256, 57);
            this.txtDsProduto.Name = "txtDsProduto";
            this.txtDsProduto.Size = new System.Drawing.Size(468, 26);
            this.txtDsProduto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(163, 94);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(561, 28);
            this.cboCategoria.TabIndex = 16;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(603, 166);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 28);
            this.cboStatus.TabIndex = 17;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 253);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCdMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtVlrPreco);
            this.Controls.Add(this.txtCdBarra);
            this.Controls.Add(this.txtDsProduto);
            this.Controls.Add(this.txtCdProduto);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCdMarca;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtCdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCdBarra;
        public System.Windows.Forms.TextBox txtVlrPreco;
        public System.Windows.Forms.TextBox txtDsProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}