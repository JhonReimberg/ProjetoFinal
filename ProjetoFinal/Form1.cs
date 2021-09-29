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
    public partial class MaqGA : Form
    {
        public MaqGA()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=GA-DE-DK-TI-03;integrated security=SSPI; initial catalog=DBMaquinasGatec");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
       
        private void limparCampos()
        {
            txtNomeM.Clear();
            txtService.Clear();
            txtNumControle.Clear();
            txtUserAtual.Clear();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string strSQL = "Select NomeMaquina from tbl_Maquinas where NomeMaquina = " + txtNomeM;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                dt = cm.ExecuteReader();
                if (dt.HasRows)
                {
                    MessageBox.Show("Máquina Já cadastrada" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                }
                else
                {
                    if (!dt.IsClosed) { dt.Close(); }
                    strSQL = "insert into tbl_Maquinas(ServiceTag,NumControle,UsuarioAtual,UsuarioAntigo)values(@ServiceTag,@NumControle,@UsuarioAtual,@UsuarioAntigo)";
                    cm.Parameters.Add("@ServiceTag", SqlDbType.VarChar).Value = txtNomeM;
                    cm.Parameters.Add("@NumControle", SqlDbType.VarChar).Value = txtService;
                    cm.Parameters.Add("@UsuarioAtual", SqlDbType.VarChar).Value = txtNumControle;
                    cm.Parameters.Add("@UsuarioAntigo", SqlDbType.VarChar).Value = txtUserAtual;
                    cm.Connection = cn;
                    cm.CommandText = strSQL;


                    cm.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Concluído Com Sucesso" + MessageBoxButtons.OK + MessageBoxIcon.Information);

                    limparCampos();
                    cm.Parameters.Clear();
                    cn.Close();
                    
                }


            }

            catch (Exception erro)
            {

            }
        }
    }
}




