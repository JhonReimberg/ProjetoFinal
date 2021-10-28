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
            txtNomeM.Clear();
            txtService.Clear();
            txtNumControle.Clear();
            txtUserAtual.Clear();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string NomedaMaquina = txNM.Text;
            string ServiceTag = txtST.Text;
            string UsuarioAtual = UserAtual.Text;
            string NumControle = txtNum.Text;

            if (NomedaMaquina=="" || ServiceTag== "" || UsuarioAtual=="" || NumControle == "") 
            {
                MessageBox.Show("Todos os campos devem ser informados");
                 txNM.Focus();
                 return;
            
            }



        }
    }
}




