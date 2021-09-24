
namespace ProjetoFinal
{
    partial class MaqGA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaqGA));
            this.NomeDaMaquina = new System.Windows.Forms.Label();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtST = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeDaMaquina
            // 
            this.NomeDaMaquina.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.NomeDaMaquina, "NomeDaMaquina");
            this.NomeDaMaquina.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NomeDaMaquina.Name = "NomeDaMaquina";
            this.NomeDaMaquina.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeM
            // 
            this.txtNomeM.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtNomeM, "txtNomeM");
            this.txtNomeM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomeM.Name = "txtNomeM";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Name = "textBox2";
            // 
            // txtST
            // 
            this.txtST.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtST, "txtST");
            this.txtST.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtST.Name = "txtST";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox3.Name = "textBox3";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtNum, "txtNum");
            this.txtNum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNum.Name = "txtNum";
            this.txtNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ProjetoFinal.Properties.Resources.download;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MaqGA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.NomeDaMaquina);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaqGA";
            this.Tag = "";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeDaMaquina;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtST;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

