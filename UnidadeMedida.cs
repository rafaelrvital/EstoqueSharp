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
            CarregaUnidade();
        }

        public void CarregaUnidade()
        {
            int i = 0;
            dgvUnidade.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT CD_UNIDADE, DS_UNIDADE FROM TB_UNIDADE_MEDIDA", cn);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                i++;
                dgvUnidade.Rows.Add(dr["CD_UNIDADE"].ToString(), dr["DS_UNIDADE"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CadastroUnidadeMedida cadastroUnidadeMedida = new CadastroUnidadeMedida(this);
            cadastroUnidadeMedida.lblCdUnidade.Text = "0";
            cadastroUnidadeMedida.ShowDialog();
        }

        private void dgvUnidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string coluna = dgvUnidade.Columns[e.ColumnIndex].Name;
            if (coluna == "Editar")
            {
                CadastroUnidadeMedida cadastroUnidadeMedida = new CadastroUnidadeMedida(this);

                cadastroUnidadeMedida.lblCdUnidade.Text = dgvUnidade[0, e.RowIndex].Value.ToString();
                cadastroUnidadeMedida.txtUnidadeMedida.Text = dgvUnidade[1, e.RowIndex].Value.ToString();

                cadastroUnidadeMedida.ShowDialog(this);
            }
            else if (coluna == "Excluir")
            {
                if ((MessageBox.Show("Deseja confirmar a gravação da marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("DELETE FROM TB_UNIDADE_MEDIDA WHERE CD_UNIDADE = " + dgvUnidade[0, e.RowIndex].Value.ToString(), cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Registro removido com sucesso!", "");
                }
            }

            CarregaUnidade();
        }
    }
}
