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
                string strSQL = "Select NomeMaquina from Maquinas where NomeMaquina = " + txtNomeM;
                cm.Connection = cn;
                cm.CommandText = strSQL;
                dt = cm.ExecuteReader();
                var teste = dt.GetValue(0);
                if (dt.HasRows)
                {
                    MessageBox.Show("Máquina Já cadastrada");
                }
                else
                {
                    
                    strSQL = "insert into Maquinas(NomeMaquina,ServiceTag,NumControle,UsuarioAtual)values(@NomeMaquina,@ServiceTag,@NumControle,@UsuarioAtual)";
                    cm.Parameters.Add("@NomeMaquina", SqlDbType.VarChar).Value = txtNomeM;
                    cm.Parameters.Add("@ServiceTag", SqlDbType.VarChar).Value = txtService;
                    cm.Parameters.Add("@NumControle", SqlDbType.VarChar).Value = txtNumControle;
                    cm.Parameters.Add("@UsuarioAtual", SqlDbType.VarChar).Value = txtUserAtual;
                    
                    cm.Connection = cn;
                    cm.CommandText = strSQL;


                    cm.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Concluído Com Sucesso");

                    limparCampos();
                    cm.Parameters.Clear();

                    cn.Close();
                    
                }


            }

            catch (Exception)
            {
                MessageBox.Show(" **** ERRO AO CADASTRAR - TENTE NOVAMENTE **** ");
                cn.Close();
            }

            
        }
    }
}




