using System;
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
    public partial class UnidadeMedida : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect conn = new DBConnect();
        SqlDataReader dr;

        public UnidadeMedida()
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
            CarregaMarca();
        }

        public void CarregaMarca()
        {
            int i = 0;
            dgvMarca.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT CD_MARCA, DS_MARCA FROM TB_MARCA", cn);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                i++;
                dgvMarca.Rows.Add(dr["CD_MARCA"].ToString(), dr["DS_MARCA"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CadastroMarca cadastroMarca = new CadastroMarca(this);
            cadastroMarca.ShowDialog();
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string coluna = dgvMarca.Columns[e.ColumnIndex].Name;
            if (coluna == "Editar")
            {
                CadastroMarca cadastroMarca = new CadastroMarca(this);

                cadastroMarca.lblCdMarca.Text = dgvMarca[0, e.RowIndex].Value.ToString();
                cadastroMarca.txtMarca.Text = dgvMarca[1, e.RowIndex].Value.ToString();

                cadastroMarca.btnSalvar.Enabled = false;
                cadastroMarca.btnAtualizar.Enabled = true;

                cadastroMarca.ShowDialog(this);
            }
            else if (coluna == "Excluir")
            {
                if ((MessageBox.Show("Deseja confirmar a gravação da marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM TB_MARCA WHERE CD_MARCA = " + dgvMarca[0, e.RowIndex].Value.ToString(), cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Registro removido com sucesso!", "");
                }
            }

            CarregaMarca();
        }
    }
}
