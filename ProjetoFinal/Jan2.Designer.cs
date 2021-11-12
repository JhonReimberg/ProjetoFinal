
namespace ProjetoFinal
{
    partial class Jan2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jan2));
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnADC = new System.Windows.Forms.Button();
            this.btnEXC = new System.Windows.Forms.Button();
            this.txtUserAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumControle = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtST = new System.Windows.Forms.Label();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.NomeDaMaquina = new System.Windows.Forms.Label();
            this.txtUserAntigo = new System.Windows.Forms.TextBox();
            this.UsuarioAntigo = new System.Windows.Forms.Label();
            this.btnCleanFilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(555, 268);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(114, 34);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(44, 197);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(247, 60);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnADC
            // 
            this.btnADC.Location = new System.Drawing.Point(44, 124);
            this.btnADC.Name = "btnADC";
            this.btnADC.Size = new System.Drawing.Size(247, 65);
            this.btnADC.TabIndex = 23;
            this.btnADC.Text = "Adicionar";
            this.btnADC.UseVisualStyleBackColor = true;
            this.btnADC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEXC
            // 
            this.btnEXC.Location = new System.Drawing.Point(44, 263);
            this.btnEXC.Name = "btnEXC";
            this.btnEXC.Size = new System.Drawing.Size(247, 63);
            this.btnEXC.TabIndex = 24;
            this.btnEXC.Text = "Excluir";
            this.btnEXC.UseVisualStyleBackColor = true;
            this.btnEXC.Click += new System.EventHandler(this.btnEXC_Click);
            // 
            // txtUserAtual
            // 
            this.txtUserAtual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAtual.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtUserAtual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUserAtual.Location = new System.Drawing.Point(469, 174);
            this.txtUserAtual.Name = "txtUserAtual";
            this.txtUserAtual.Size = new System.Drawing.Size(315, 22);
            this.txtUserAtual.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(342, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "USUÁRIO ATUAL:";
            // 
            // txtNumControle
            // 
            this.txtNumControle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumControle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNumControle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumControle.Location = new System.Drawing.Point(469, 133);
            this.txtNumControle.Name = "txtNumControle";
            this.txtNumControle.Size = new System.Drawing.Size(315, 22);
            this.txtNumControle.TabIndex = 30;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNum.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.txtNum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNum.Location = new System.Drawing.Point(342, 137);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(101, 25);
            this.txtNum.TabIndex = 29;
            this.txtNum.Text = "Nº CONTROLE:";
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtService.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtService.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtService.Location = new System.Drawing.Point(469, 89);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(315, 22);
            this.txtService.TabIndex = 28;
            // 
            // txtST
            // 
            this.txtST.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtST.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.txtST.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtST.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtST.Location = new System.Drawing.Point(342, 93);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(199, 25);
            this.txtST.TabIndex = 27;
            this.txtST.Text = "SERVICE TAG:\r\n";
            // 
            // txtNomeM
            // 
            this.txtNomeM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeM.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNomeM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomeM.Location = new System.Drawing.Point(469, 51);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(315, 22);
            this.txtNomeM.TabIndex = 26;
            // 
            // NomeDaMaquina
            // 
            this.NomeDaMaquina.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NomeDaMaquina.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.NomeDaMaquina.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NomeDaMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NomeDaMaquina.Location = new System.Drawing.Point(342, 55);
            this.NomeDaMaquina.Name = "NomeDaMaquina";
            this.NomeDaMaquina.Size = new System.Drawing.Size(129, 25);
            this.NomeDaMaquina.TabIndex = 25;
            this.NomeDaMaquina.Text = "NOME DA MÁQUINA:\r\n";
            // 
            // txtUserAntigo
            // 
            this.txtUserAntigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserAntigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAntigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtUserAntigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUserAntigo.Location = new System.Drawing.Point(469, 218);
            this.txtUserAntigo.Name = "txtUserAntigo";
            this.txtUserAntigo.Size = new System.Drawing.Size(315, 22);
            this.txtUserAntigo.TabIndex = 34;
            this.txtUserAntigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsuarioAntigo
            // 
            this.UsuarioAntigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UsuarioAntigo.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.UsuarioAntigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UsuarioAntigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsuarioAntigo.Location = new System.Drawing.Point(342, 218);
            this.UsuarioAntigo.Name = "UsuarioAntigo";
            this.UsuarioAntigo.Size = new System.Drawing.Size(110, 15);
            this.UsuarioAntigo.TabIndex = 33;
            this.UsuarioAntigo.Text = "USUÁRIO ANTIGO:";
            this.UsuarioAntigo.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCleanFilter
            // 
            this.btnCleanFilter.BackgroundImage = global::ProjetoFinal.Properties.Resources.icone_x_;
            this.btnCleanFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCleanFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFilter.Location = new System.Drawing.Point(675, 272);
            this.btnCleanFilter.Name = "btnCleanFilter";
            this.btnCleanFilter.Size = new System.Drawing.Size(28, 24);
            this.btnCleanFilter.TabIndex = 22;
            this.btnCleanFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCleanFilter.UseVisualStyleBackColor = true;
            this.btnCleanFilter.Click += new System.EventHandler(this.btnCleanFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::ProjetoFinal.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Jan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.txtUserAntigo);
            this.Controls.Add(this.UsuarioAntigo);
            this.Controls.Add(this.txtUserAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumControle);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.NomeDaMaquina);
            this.Controls.Add(this.btnEXC);
            this.Controls.Add(this.btnADC);
            this.Controls.Add(this.btnCleanFilter);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jan2";
            this.Text = "Máquinas Gatec v1.0";
            this.Load += new System.EventHandler(this.Jan2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCleanFilter;
        private System.Windows.Forms.Button btnADC;
        private System.Windows.Forms.Button btnEXC;
        private System.Windows.Forms.TextBox txtUserAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumControle;
        private System.Windows.Forms.Label txtNum;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label txtST;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.Label NomeDaMaquina;
        private System.Windows.Forms.TextBox txtUserAntigo;
        private System.Windows.Forms.Label UsuarioAntigo;
    }
}