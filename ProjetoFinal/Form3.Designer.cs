
namespace ProjetoFinal
{
    partial class alt_excl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alt_excl));
            this.txtBoxUserAntigo = new System.Windows.Forms.TextBox();
            this.txtUserAtual = new System.Windows.Forms.TextBox();
            this.txtNumControle = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUserAntigo
            // 
            this.txtBoxUserAntigo.BackColor = System.Drawing.Color.Lavender;
            this.txtBoxUserAntigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxUserAntigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtBoxUserAntigo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxUserAntigo.Location = new System.Drawing.Point(79, 189);
            this.txtBoxUserAntigo.Name = "txtBoxUserAntigo";
            this.txtBoxUserAntigo.Size = new System.Drawing.Size(315, 22);
            this.txtBoxUserAntigo.TabIndex = 22;
            // 
            // txtUserAtual
            // 
            this.txtUserAtual.BackColor = System.Drawing.Color.Lavender;
            this.txtUserAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAtual.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtUserAtual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUserAtual.Location = new System.Drawing.Point(79, 148);
            this.txtUserAtual.Name = "txtUserAtual";
            this.txtUserAtual.Size = new System.Drawing.Size(315, 22);
            this.txtUserAtual.TabIndex = 19;
            // 
            // txtNumControle
            // 
            this.txtNumControle.BackColor = System.Drawing.Color.Lavender;
            this.txtNumControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumControle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNumControle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumControle.Location = new System.Drawing.Point(79, 107);
            this.txtNumControle.Name = "txtNumControle";
            this.txtNumControle.Size = new System.Drawing.Size(315, 22);
            this.txtNumControle.TabIndex = 17;
            // 
            // txtService
            // 
            this.txtService.BackColor = System.Drawing.Color.Lavender;
            this.txtService.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtService.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtService.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtService.Location = new System.Drawing.Point(79, 63);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(315, 22);
            this.txtService.TabIndex = 15;
            // 
            // txtNomeM
            // 
            this.txtNomeM.BackColor = System.Drawing.Color.Lavender;
            this.txtNomeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeM.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtNomeM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomeM.Location = new System.Drawing.Point(79, 25);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(315, 22);
            this.txtNomeM.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "ALTERAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "DELETAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alt_excl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ProjetoFinal.Properties.Resources._2_1;
            this.ClientSize = new System.Drawing.Size(470, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxUserAntigo);
            this.Controls.Add(this.txtUserAtual);
            this.Controls.Add(this.txtNumControle);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtNomeM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "alt_excl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar ou Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUserAntigo;
        private System.Windows.Forms.TextBox txtUserAtual;
        private System.Windows.Forms.TextBox txtNumControle;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}