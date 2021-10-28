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
    }
}
