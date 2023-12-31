﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueSharp
{
    public partial class Produto : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect conn = new DBConnect();
        SqlDataReader dr;

        public Produto()
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
            DefineCombos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Deseja confirmar a gravação do produto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT tb_Produto (CD_PRODUTO, DS_PRODUTO, CD_CATEGORIA, CD_BARRA, VLR_PRECO, STS_PRODUTO)" +
                                         "VALUES (@CD_PRODUTO, @DS_PRODUTO, @CD_CATEGORIA, @CD_BARRA, @VLR_PRECO, @STS_PRODUTO)", cn);

                    cmd.Parameters.AddWithValue("@CD_PRODUTO", txtCdProduto.Text);
                    cmd.Parameters.AddWithValue("@DS_PRODUTO", txtDsProduto.Text);
                    cmd.Parameters.AddWithValue("@CD_CATEGORIA", cboCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@CD_BARRA", txtCdBarra.Text);
                    cmd.Parameters.AddWithValue("@VLR_PRECO", double.Parse(txtVlrPreco.Text));
                    cmd.Parameters.AddWithValue("@STS_PRODUTO", cboStatus.SelectedValue);

                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Registro salvo com sucesso!", "");
                    Clear();
                    //marca.CarregaMarca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DefineCombos()
        {
            cboUnidadeMedida.Items.Clear();
            cboUnidadeMedida.DataSource = conn.GetTable("SELECT CD_UNIDADE, DS_UNIDADE FROM TB_UNIDADE_MEDIDA");
            cboUnidadeMedida.DisplayMember = "DS_UNIDADE";
            cboUnidadeMedida.ValueMember = "CD_UNIDADE";

            /*cboCategoria.Items.Clear();
            cboCategoria.DataSource = conn.GetTable("SELECT CD_CATEGORIA, DS_CATEGORIA FROM TB_CATEGORIA");
            cboCategoria.DisplayMember = "DS_CATEGORIA";
            cboCategoria.ValueMember = "CD_CATEGORIA";*/

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
        }

        public void Clear()
        {
            txtCdProduto.Clear();
            txtDsProduto.Clear();
            cboCategoria.SelectedIndex = 0;
            txtCdBarra.Clear();
            txtVlrPreco.Clear();
            cboStatus.SelectedIndex = 0;

            txtCdProduto.Focus();
        }
    }
}
