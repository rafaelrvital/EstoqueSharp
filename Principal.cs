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

        public Principal()
        {
            InitializeComponent();
            defineMenu();
            cn = new SqlConnection(conn.myConnection());
            cn.Open();
        }

        #region panelMenu
        private void defineMenu()
        {
            panelSubProduto.Visible = false;
            panelSubEstoque.Visible = false;
            panelSubConsulta.Visible = false;
            panelSubConfiguracoes.Visible = false;
        }

        private void ocultaMenu()
        { 
            if (panelSubProduto.Visible)
            {
                panelSubProduto.Visible = false;
            }

            if (panelSubEstoque.Visible)
            {
                panelSubEstoque.Visible = false;
            }

            if (panelSubConsulta.Visible)
            {
                panelSubConsulta.Visible = false;
            }

            if (panelSubConfiguracoes.Visible)
            {
                panelSubConfiguracoes.Visible = false;
            }
        }

        private void exibeMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultaMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion panelMenu

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            exibeMenu(panelSubProduto);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            exibeMenu(panelSubEstoque);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            exibeMenu(panelSubConsulta);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            exibeMenu(panelSubConfiguracoes);
        }

        private void btnListaProdutos_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnPDV_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            ocultaMenu();
        }
    }
}
