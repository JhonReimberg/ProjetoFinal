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

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=DBMaquinasGatec;Data Source=GA-DE-DK-TI-03");
            SqlCommand command = new SqlCommand("select * from Maquinas where ServiceTag=@ServiceTag and NumControle=@NumControle", sql);
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


        
    }
}
