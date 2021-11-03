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
    }
}
