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
using System.Data;

namespace Paris_Lanches
{
    public partial class cadfuncionario : MetroFramework.Forms.MetroForm
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-MH8BABK\SQLEXPRESS;Initial Catalog=ParisLanches;Integrated Security=True");
        public cadfuncionario()
        {
            InitializeComponent();
        }

        private void cadfuncionario_Load(object sender, EventArgs e)
        {

            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            string usuario = txt_usuario.Text;
            string senha = txtsenha.Text;
            SqlParameter.ReferenceEquals(usuario, senha);
            string query = "INSERT INTO usuario (username, pass) VALUES (" + txt_usuario.Text +","+ txtsenha.Text+")";
            
            SqlDataAdapter adapt = new SqlDataAdapter(query, conection);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            



        }
    }
}
