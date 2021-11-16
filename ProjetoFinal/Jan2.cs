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



namespace ProjetoFinal
{
    public partial class Jan2 : Form
    {
        public Jan2()
        {
            InitializeComponent();
        }

        private void Jan2_Load(object sender, EventArgs e)
        {
            Form2 jan4 = new Form2();
            jan4.Close();
        }      

       
        private void button1_Click(object sender, EventArgs e)
        {
            MaqGA j2 = new MaqGA();
            j2.ShowDialog();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCleanFilter_Click(object sender, EventArgs e)
        {
            txtNumControle.Text = "";
            txtUserAtual.Text = "";
            txtUserAntigo.Text = "";
            txtService.Text = "";
            txtNomeM.Text = "";

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alt_excl aoe = new alt_excl();
            aoe.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=DBMaquinasGatec;Data Source=GA-DE-DK-TI-03");
            SqlCommand command = new SqlCommand("select * from Maquinas where NomeMaquina=@NomeMaquina or UsuarioAtual=@UsuarioAtual or ServiceTag=@ServiceTag or NumControle=@NumControle", sql);
            command.Parameters.Add("@NomeMaquina", SqlDbType.VarChar).Value = txtNomeM.Text;
            command.Parameters.Add("@NumControle", SqlDbType.VarChar).Value = txtNumControle.Text;
            command.Parameters.Add("@UsuarioAtual", SqlDbType.VarChar).Value = txtUserAtual.Text;
            command.Parameters.Add("@ServiceTag", SqlDbType.VarChar).Value = txtService.Text;
            command.Parameters.Add("@UsuarioAntigo", SqlDbType.VarChar).Value = txtUserAntigo.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                 throw new Exception("    Maquina não encontrada");
                }

                drms.Read();
                txtNomeM.Text = Convert.ToString(drms["NomeMaquina"]);
                txtUserAtual.Text = Convert.ToString(drms["UsuarioAtual"]);
                txtUserAntigo.Text = Convert.ToString(drms["UsuarioAntigo"]);
                txtService.Text = Convert.ToString(drms["ServiceTag"]);
                txtNumControle.Text = Convert.ToString(drms["NumControle"]);             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            


        }

        private void btnEXC_Click(object sender, EventArgs e)
        {

        }

        private void txtST_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeM_Enter(object sender, EventArgs e)
        {
            if(txtNomeM.Text == "NOME DA MAQUINA")
            {
                txtNomeM.Text = "";
                txtNomeM.ForeColor = Color.Black;
            }
        }

        private void txtNomeM_Leave(object sender, EventArgs e)
        {
            if (txtNomeM.Text == "")
            {
                txtNomeM.Text = "NOME DA MAQUINA";
                txtNomeM.ForeColor = Color.Gray;

            }
        }

        private void txtService_Enter(object sender, EventArgs e)
        {
            if (txtService.Text == "SERVICE TAG")
            {
                txtService.Text = "";
                txtService.ForeColor = Color.Black;
            }
        }

        private void txtService_Leave(object sender, EventArgs e)
        {
            if (txtService.Text == "")
            {
                txtService.Text = "SERVICE TAG";
                txtService.ForeColor = Color.Gray;

            }
        }

        
        private void txtNumControle_Enter(object sender, EventArgs e)
        {
            if (txtNumControle.Text == "Nº CONTROLE")
            {
                txtNumControle.Text = "";
                txtNumControle.ForeColor = Color.Black;
            }

        }

        private void txtNumControle_Leave(object sender, EventArgs e)
        {
            if (txtNumControle.Text == "")
            {
                txtNumControle.Text = "Nº CONTROLE";
                txtNumControle.ForeColor = Color.Gray;

            }

        }
        
        private void txtUserAtual_Enter(object sender, EventArgs e)
        {
            if (txtUserAtual.Text == "USUARIO ATUAL")
            {
                txtUserAtual.Text = "";
                txtUserAtual.ForeColor = Color.Black;
            }

        }

        private void txtUserAtual_Leave(object sender, EventArgs e)
        {
            if (txtUserAtual.Text == "")
            {
                txtUserAtual.Text = "USUARIO ATUAL";
                txtUserAtual.ForeColor = Color.Gray;

            }
        }

        private void txtUserAntigo_Enter(object sender, EventArgs e)
        {
            if (txtUserAntigo.Text == "USUARIO ANTIGO")
            {
                txtUserAntigo.Text = "";
                txtUserAntigo.ForeColor = Color.Black;
            }

        }

        private void txtUserAntigo_Leave(object sender, EventArgs e)
        {
            if (txtUserAntigo.Text == "")
            {
                txtUserAntigo.Text = "USUARIO ANTIGO";
                txtUserAntigo.ForeColor = Color.Gray;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
