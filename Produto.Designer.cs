namespace EstoqueSharp
{
    partial class Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlr_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.ColumnHeadersHeight = 30;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cd_produto,
            this.ds_produto,
            this.ds_Categoria,
            this.cd_barra,
            this.vlr_produto,
            this.Editar,
            this.Excluir});
            this.dgvMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarca.EnableHeadersVisualStyles = false;
            this.dgvMarca.Location = new System.Drawing.Point(0, 0);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.Size = new System.Drawing.Size(984, 461);
            this.dgvMarca.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(926, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // cd_produto
            // 
            this.cd_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cd_produto.HeaderText = "Código";
            this.cd_produto.Name = "cd_produto";
            this.cd_produto.ReadOnly = true;
            this.cd_produto.Width = 87;
            // 
            // ds_produto
            // 
            this.ds_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ds_produto.HeaderText = "Descrição";
            this.ds_produto.Name = "ds_produto";
            // 
            // ds_Categoria
            // 
            this.ds_Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ds_Categoria.HeaderText = "Categoria";
            this.ds_Categoria.Name = "ds_Categoria";
            this.ds_Categoria.Width = 107;
            // 
            // cd_barra
            // 
            this.cd_barra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cd_barra.HeaderText = "Código de barras";
            this.cd_barra.Name = "cd_barra";
            this.cd_barra.Width = 161;
            // 
            // vlr_produto
            // 
            this.vlr_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vlr_produto.HeaderText = "Preço";
            this.vlr_produto.Name = "vlr_produto";
            this.vlr_produto.Width = 76;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.Width = 5;
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Excluir.HeaderText = "";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 5;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Produto";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlr_produto;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
    }
}