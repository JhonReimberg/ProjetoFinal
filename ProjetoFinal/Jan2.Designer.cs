
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
            this.txtNumControle = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtUserAntigo = new System.Windows.Forms.TextBox();
            this.btnCleanFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.Location = new System.Drawing.Point(40, 224);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(155, 35);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlterar.Location = new System.Drawing.Point(248, 105);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(187, 60);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Confirmar Alteração";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnADC
            // 
            this.btnADC.ForeColor = System.Drawing.Color.Gray;
            this.btnADC.Location = new System.Drawing.Point(248, 39);
            this.btnADC.Name = "btnADC";
            this.btnADC.Size = new System.Drawing.Size(187, 60);
            this.btnADC.TabIndex = 23;
            this.btnADC.Text = "Adicionar";
            this.btnADC.UseVisualStyleBackColor = true;
            this.btnADC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEXC
            // 
            this.btnEXC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEXC.Location = new System.Drawing.Point(248, 171);
            this.btnEXC.Name = "btnEXC";
            this.btnEXC.Size = new System.Drawing.Size(187, 60);
            this.btnEXC.TabIndex = 24;
            this.btnEXC.Text = "Excluir";
            this.btnEXC.UseVisualStyleBackColor = true;
            this.btnEXC.Click += new System.EventHandler(this.btnEXC_Click);
            // 
            // txtUserAtual
            // 
            this.txtUserAtual.AcceptsReturn = true;
            this.txtUserAtual.AcceptsTab = true;
            this.txtUserAtual.BackColor = System.Drawing.Color.OldLace;
            this.txtUserAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAtual.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtUserAtual.ForeColor = System.Drawing.Color.Gray;
            this.txtUserAtual.Location = new System.Drawing.Point(12, 140);
            this.txtUserAtual.Name = "txtUserAtual";
            this.txtUserAtual.Size = new System.Drawing.Size(212, 22);
            this.txtUserAtual.TabIndex = 32;
            this.txtUserAtual.Text = "USUARIO ATUAL";
            this.txtUserAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserAtual.Enter += new System.EventHandler(this.txtUserAtual_Enter);
            this.txtUserAtual.Leave += new System.EventHandler(this.txtUserAtual_Leave);
            // 
            // txtNumControle
            // 
            this.txtNumControle.AcceptsReturn = true;
            this.txtNumControle.AcceptsTab = true;
            this.txtNumControle.BackColor = System.Drawing.Color.OldLace;
            this.txtNumControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumControle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNumControle.ForeColor = System.Drawing.Color.Gray;
            this.txtNumControle.Location = new System.Drawing.Point(12, 103);
            this.txtNumControle.Name = "txtNumControle";
            this.txtNumControle.Size = new System.Drawing.Size(212, 22);
            this.txtNumControle.TabIndex = 30;
            this.txtNumControle.Text = "Nº CONTROLE";
            this.txtNumControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumControle.Enter += new System.EventHandler(this.txtNumControle_Enter);
            this.txtNumControle.Leave += new System.EventHandler(this.txtNumControle_Leave);
            // 
            // txtService
            // 
            this.txtService.AcceptsReturn = true;
            this.txtService.AcceptsTab = true;
            this.txtService.BackColor = System.Drawing.Color.OldLace;
            this.txtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtService.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtService.ForeColor = System.Drawing.Color.Gray;
            this.txtService.Location = new System.Drawing.Point(12, 68);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(212, 22);
            this.txtService.TabIndex = 28;
            this.txtService.Text = "SERVICE TAG";
            this.txtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtService.Enter += new System.EventHandler(this.txtService_Enter);
            this.txtService.Leave += new System.EventHandler(this.txtService_Leave);
            // 
            // txtNomeM
            // 
            this.txtNomeM.AcceptsReturn = true;
            this.txtNomeM.AcceptsTab = true;
            this.txtNomeM.BackColor = System.Drawing.Color.OldLace;
            this.txtNomeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeM.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNomeM.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeM.Location = new System.Drawing.Point(12, 31);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(212, 22);
            this.txtNomeM.TabIndex = 26;
            this.txtNomeM.Text = "NOME DA MAQUINA";
            this.txtNomeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeM.Enter += new System.EventHandler(this.txtNomeM_Enter);
            this.txtNomeM.Leave += new System.EventHandler(this.txtNomeM_Leave);
            // 
            // txtUserAntigo
            // 
            this.txtUserAntigo.AcceptsReturn = true;
            this.txtUserAntigo.AcceptsTab = true;
            this.txtUserAntigo.BackColor = System.Drawing.Color.OldLace;
            this.txtUserAntigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAntigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtUserAntigo.ForeColor = System.Drawing.Color.Gray;
            this.txtUserAntigo.Location = new System.Drawing.Point(12, 180);
            this.txtUserAntigo.Name = "txtUserAntigo";
            this.txtUserAntigo.Size = new System.Drawing.Size(212, 22);
            this.txtUserAntigo.TabIndex = 34;
            this.txtUserAntigo.Text = "USUARIO ANTIGO";
            this.txtUserAntigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserAntigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUserAntigo.Enter += new System.EventHandler(this.txtUserAntigo_Enter);
            this.txtUserAntigo.Leave += new System.EventHandler(this.txtUserAntigo_Leave);
            // 
            // btnCleanFilter
            // 
            this.btnCleanFilter.BackgroundImage = global::ProjetoFinal.Properties.Resources.edit_clear_icon_181105;
            this.btnCleanFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCleanFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFilter.Location = new System.Drawing.Point(201, 232);
            this.btnCleanFilter.Name = "btnCleanFilter";
            this.btnCleanFilter.Size = new System.Drawing.Size(23, 20);
            this.btnCleanFilter.TabIndex = 22;
            this.btnCleanFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCleanFilter.UseVisualStyleBackColor = true;
            this.btnCleanFilter.Click += new System.EventHandler(this.btnCleanFilter_Click);
            // 
            // Jan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::ProjetoFinal.Properties.Resources.do_agro_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 302);
            this.Controls.Add(this.txtUserAntigo);
            this.Controls.Add(this.txtUserAtual);
            this.Controls.Add(this.txtNumControle);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtNomeM);
            this.Controls.Add(this.btnEXC);
            this.Controls.Add(this.btnADC);
            this.Controls.Add(this.btnCleanFilter);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btn1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jan2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Máquinas Gatec v1.0";
            this.Load += new System.EventHandler(this.Jan2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCleanFilter;
        private System.Windows.Forms.Button btnADC;
        private System.Windows.Forms.Button btnEXC;
        private System.Windows.Forms.TextBox txtUserAtual;
        private System.Windows.Forms.TextBox txtNumControle;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.TextBox txtUserAntigo;
    }
}