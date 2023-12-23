using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueSharp
{
    public partial class CadastroUnidadeMedida : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect conn = new DBConnect();
        UnidadeMedida unidadeMedida;
        bool mouseDown;
        int posX;
        int posY;

        public CadastroUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
            this.unidadeMedida = unidadeMedida;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Deseja confirmar a gravação da unidade de medida?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    cn.Open();

                    if (lblCdUnidade.Text == "0")
                    {
                        cmd = new SqlCommand("INSERT TB_UNIDADE_MEDIDA (DS_UNIDADE) VALUES (@unidade)", cn);
                        cmd.Parameters.AddWithValue("@unidade", txtUnidadeMedida.Text);
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE TB_UNIDADE_MEDIDA SET DS_UNIDADE = @unidade WHERE CD_UNIDADE = " + lblCdUnidade.Text, cn);
                        cmd.Parameters.AddWithValue("@unidade", txtUnidadeMedida.Text);
                    }

                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Registro salvo com sucesso!", "");
                    //Clear();
                    unidadeMedida.CarregaUnidade();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Clear()
        {
            txtUnidadeMedida.Clear();
            txtUnidadeMedida.Focus();
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mousex = MousePosition.X - posX;
                int mousey = MousePosition.Y - posY;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            posX = e.Location.X;
            posY = e.Location.Y;

            mouseDown = true;
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
