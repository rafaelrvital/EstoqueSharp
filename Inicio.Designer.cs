namespace EstoqueSharp
{
    partial class Inicio
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(182, 250);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(620, 60);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Nenhum card foi selecionado para exibir no início!\r\n\r\nAcesse o menu Configurações" +
    " para definir os cards e indicadores a serem exibidos.";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lblInicio);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
    }
}