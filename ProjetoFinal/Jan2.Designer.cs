
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
            this.btnADC = new System.Windows.Forms.Button();
            this.txtUserAtual = new System.Windows.Forms.TextBox();
            this.txtNumControle = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtUserAntigo = new System.Windows.Forms.TextBox();
            this.btnCleanFilter = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.Location = new System.Drawing.Point(119, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(173, 48);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "BUSCAR";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnADC
            // 
            this.btnADC.BackColor = System.Drawing.Color.Transparent;
            this.btnADC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADC.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnADC.Location = new System.Drawing.Point(440, 113);
            this.btnADC.Name = "btnADC";
            this.btnADC.Size = new System.Drawing.Size(155, 52);
            this.btnADC.TabIndex = 23;
            this.btnADC.Text = "CONFIRMAR ALTERAÇÃO";
            this.btnADC.UseVisualStyleBackColor = false;
            this.btnADC.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserAtual
            // 
            this.txtUserAtual.AcceptsReturn = true;
            this.txtUserAtual.AcceptsTab = true;
            this.txtUserAtual.BackColor = System.Drawing.Color.Lavender;
            this.txtUserAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAtual.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAtual.ForeColor = System.Drawing.Color.Gray;
            this.txtUserAtual.Location = new System.Drawing.Point(22, 155);
            this.txtUserAtual.Name = "txtUserAtual";
            this.txtUserAtual.Size = new System.Drawing.Size(374, 20);
            this.txtUserAtual.TabIndex = 32;
            this.txtUserAtual.Text = "USUARIO ATUAL";
            this.txtUserAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserAtual.TextChanged += new System.EventHandler(this.txtUserAtual_TextChanged);
            this.txtUserAtual.Enter += new System.EventHandler(this.txtUserAtual_Enter);
            this.txtUserAtual.Leave += new System.EventHandler(this.txtUserAtual_Leave);
            // 
            // txtNumControle
            // 
            this.txtNumControle.AcceptsReturn = true;
            this.txtNumControle.AcceptsTab = true;
            this.txtNumControle.BackColor = System.Drawing.Color.Lavender;
            this.txtNumControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumControle.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumControle.ForeColor = System.Drawing.Color.Gray;
            this.txtNumControle.Location = new System.Drawing.Point(22, 118);
            this.txtNumControle.Name = "txtNumControle";
            this.txtNumControle.Size = new System.Drawing.Size(374, 20);
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
            this.txtService.BackColor = System.Drawing.Color.Lavender;
            this.txtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtService.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.ForeColor = System.Drawing.Color.Gray;
            this.txtService.Location = new System.Drawing.Point(22, 83);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(374, 20);
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
            this.txtNomeM.BackColor = System.Drawing.Color.Lavender;
            this.txtNomeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeM.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeM.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeM.Location = new System.Drawing.Point(22, 46);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(374, 20);
            this.txtNomeM.TabIndex = 26;
            this.txtNomeM.Text = "NOME DA MAQUINA";
            this.txtNomeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeM.TextChanged += new System.EventHandler(this.txtNomeM_TextChanged);
            this.txtNomeM.Enter += new System.EventHandler(this.txtNomeM_Enter);
            this.txtNomeM.Leave += new System.EventHandler(this.txtNomeM_Leave);
            // 
            // txtUserAntigo
            // 
            this.txtUserAntigo.AcceptsReturn = true;
            this.txtUserAntigo.AcceptsTab = true;
            this.txtUserAntigo.BackColor = System.Drawing.Color.Lavender;
            this.txtUserAntigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAntigo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAntigo.ForeColor = System.Drawing.Color.Gray;
            this.txtUserAntigo.Location = new System.Drawing.Point(22, 195);
            this.txtUserAntigo.Name = "txtUserAntigo";
            this.txtUserAntigo.Size = new System.Drawing.Size(374, 20);
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
            this.btnCleanFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFilter.Location = new System.Drawing.Point(298, 250);
            this.btnCleanFilter.Name = "btnCleanFilter";
            this.btnCleanFilter.Size = new System.Drawing.Size(28, 24);
            this.btnCleanFilter.TabIndex = 22;
            this.btnCleanFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCleanFilter.UseVisualStyleBackColor = true;
            this.btnCleanFilter.Click += new System.EventHandler(this.btnCleanFilter_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlterar.Location = new System.Drawing.Point(440, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(155, 54);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "EXCLUIR MÁQUINA";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(440, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 52);
            this.button1.TabIndex = 35;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Jan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::ProjetoFinal.Properties.Resources._90aebf5af7875ac230a8041c067577da;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUserAntigo);
            this.Controls.Add(this.txtUserAtual);
            this.Controls.Add(this.txtNumControle);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtNomeM);
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
        private System.Windows.Forms.Button btnCleanFilter;
        private System.Windows.Forms.Button btnADC;
        private System.Windows.Forms.TextBox txtUserAtual;
        private System.Windows.Forms.TextBox txtNumControle;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.TextBox txtUserAntigo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
    }
}