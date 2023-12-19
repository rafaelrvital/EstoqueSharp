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
        }
    }
}
