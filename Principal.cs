using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstoqueSharp
{
    public partial class Principal : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect conn = new DBConnect();

        bool ocultarCadastro = true;

        public Principal()
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
            cn.Open();

            abreFormChild(new Inicio());
        }

        private void ocultaMenu()
        {
            ocultarCadastro = true;
            timerCadastro.Start();
        }

        private Form activeForm = null;
        public void abreFormChild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitulo.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //exibeMenu(panelSubCadastro);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnListaProdutos_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ocultaMenu();
            abreFormChild(new UnidadeMedida());
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abreFormChild(new Inicio());
            ocultaMenu();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            timerCadastro.Start();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerCadastro_Tick(object sender, EventArgs e)
        {
            if (ocultarCadastro)
            {

                panelCadastro.Height -= 10;
                if (panelCadastro.Height == panelCadastro.MinimumSize.Height)
                {
                    ocultarCadastro = false;
                    timerCadastro.Stop();
                }
            }
            else
            {
                panelCadastro.Height += 10;
                if (panelCadastro.Height == panelCadastro.MaximumSize.Height)
                {
                    ocultarCadastro = true;
                    timerCadastro.Stop();
                }
            }
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void btnUnidadeMedida_Click(object sender, EventArgs e)
        {
            abreFormChild(new UnidadeMedida());
            ocultaMenu();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            ocultaMenu();
            abreFormChild(new Produto());
        }
    }
}
