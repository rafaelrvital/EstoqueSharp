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
    public partial class CadastroMarca : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnect conn = new DBConnect();
        UnidadeMedida marca;
        bool mouseDown;
        int posX;
        int posY;

        public CadastroMarca(UnidadeMedida marca)
        {
            InitializeComponent();
            cn = new SqlConnection(conn.myConnection());
            this.marca = marca;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Deseja confirmar a gravação da marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT tb_Marca (ds_marca) VALUES (@marca)", cn);
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Registro salvo com sucesso!", "");
                    Clear();
                    marca.CarregaMarca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtMarca.Clear();
            btnAtualizar.Enabled = false;
            btnSalvar.Enabled = true;
            txtMarca.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja confirmar a atualização da marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE TB_MARCA SET DS_MARCA = @marca WHERE CD_MARCA = " + lblCdMarca.Text, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Registro salvo com sucesso!", "");
                Clear();
                this.Dispose();
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            posX = e.Location.X;
            posY = e.Location.Y;

            mouseDown = true;

        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) 
            {
                int mousex = MousePosition.X - posX;
                int mousey = MousePosition.Y - posY;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
