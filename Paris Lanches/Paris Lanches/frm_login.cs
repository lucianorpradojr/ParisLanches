using System.Data.SqlClient;
using System.Collections;
using System.Data;



namespace Paris_Lanches
{
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-MH8BABK\SQLEXPRESS;Initial Catalog=ParisLanches;Integrated Security=True");


        public frm_login()
        {
            InitializeComponent();
            txt_usuario.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            conection.Open();
            string query = "SELECT * FROM usuario WHERE username = '" + txt_usuario.Text + "' AND pass ='" + txt_senha.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, conection);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
         
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }

            else
            {
                MessageBox.Show("Nome de Usuário ou Senha Inválidos");
            }
        }

        private void btn_cadusuario_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM usuario WHERE username = '" + txt_usuario.Text + "' AND pass ='" + txt_senha.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, conection);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                cadfuncionario cadasfuncionario = new cadfuncionario();
                cadasfuncionario.Show();
            }

            else
            {
                MessageBox.Show("É necessário inserior as credenciais de administrador para cadastrar um novo usuário");
            }
        }
    }
}