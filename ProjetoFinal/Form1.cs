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


        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=DBMaquinasGatec;Data Source=GA-DE-DK-TI-03");
            SqlCommand command = new SqlCommand("insert into Maquinas(NomeMaquina, NumControle, UsuarioAtual, UsuarioAntigo, ServiceTag) values(@NomeMaquina, @NumControle, @UsuarioAtual, @UsuarioAntigo, @ServiceTag)", sql);
            command.Parameters.Add("@NomeMaquina", SqlDbType.VarChar).Value = txtNomeM.Text;
            command.Parameters.Add("@NumControle", SqlDbType.VarChar).Value = txtNumControle.Text;
            command.Parameters.Add("@UsuarioAtual", SqlDbType.VarChar).Value = txtUserAtual.Text;
            command.Parameters.Add("@ServiceTag", SqlDbType.VarChar).Value = txtService.Text;
            command.Parameters.Add("@UsuarioAntigo", SqlDbType.VarChar).Value = txtBoxUserAntigo.Text;


            if (txtNomeM.Text !="" & txtNumControle.Text !="" & txtUserAtual.Text !="" & txtService.Text !="" & txtService.Text != "")
            {

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro concluído com sucesso", "Máquinas Gatec v1.0", MessageBoxButtons.OK);
                    txtNomeM.Text = "";
                    txtNumControle.Text = "";
                    txtUserAtual.Text = "";
                    txtService.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }

            }

            else
            {
                MessageBox.Show("         PREENCHA OS CAMPOS CORRETAMENTE ! ! !", "Máquinas Gatec v1.0", MessageBoxButtons.OK);

            }


             



            

            






        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




