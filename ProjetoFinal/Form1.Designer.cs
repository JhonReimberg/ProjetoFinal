
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
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtNumControle = new System.Windows.Forms.TextBox();
            this.txtUserAtual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxUserAntigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomeM
            // 
            this.txtNomeM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNomeM, "txtNomeM");
            this.txtNomeM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomeM.Name = "txtNomeM";
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtService, "txtService");
            this.txtService.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtService.Name = "txtService";
            // 
            // txtNumControle
            // 
            this.txtNumControle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNumControle, "txtNumControle");
            this.txtNumControle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumControle.Name = "txtNumControle";
            // 
            // txtUserAtual
            // 
            this.txtUserAtual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtUserAtual, "txtUserAtual");
            this.txtUserAtual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUserAtual.Name = "txtUserAtual";
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
            // txtBoxUserAntigo
            // 
            this.txtBoxUserAntigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxUserAntigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtBoxUserAntigo, "txtBoxUserAntigo");
            this.txtBoxUserAntigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxUserAntigo.Name = "txtBoxUserAntigo";
            this.txtBoxUserAntigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaqGA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::ProjetoFinal.Properties.Resources.do_agro_2;
            this.Controls.Add(this.txtBoxUserAntigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUserAtual);
            this.Controls.Add(this.txtNumControle);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtNomeM);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaqGA";
            this.Tag = "";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtNumControle;
        private System.Windows.Forms.TextBox txtUserAtual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxUserAntigo;
    }
}

