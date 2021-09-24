
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCleanFilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnADC = new System.Windows.Forms.Button();
            this.btnEXC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(92, 260);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(114, 34);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Buscar";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(326, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 271);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(510, 289);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 34);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCleanFilter
            // 
            this.btnCleanFilter.BackgroundImage = global::ProjetoFinal.Properties.Resources.icone_x_;
            this.btnCleanFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCleanFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFilter.Location = new System.Drawing.Point(212, 264);
            this.btnCleanFilter.Name = "btnCleanFilter";
            this.btnCleanFilter.Size = new System.Drawing.Size(28, 24);
            this.btnCleanFilter.TabIndex = 22;
            this.btnCleanFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCleanFilter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::ProjetoFinal.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 143);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnADC
            // 
            this.btnADC.Location = new System.Drawing.Point(326, 289);
            this.btnADC.Name = "btnADC";
            this.btnADC.Size = new System.Drawing.Size(114, 34);
            this.btnADC.TabIndex = 23;
            this.btnADC.Text = "Adicionar";
            this.btnADC.UseVisualStyleBackColor = true;
            this.btnADC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEXC
            // 
            this.btnEXC.Location = new System.Drawing.Point(689, 289);
            this.btnEXC.Name = "btnEXC";
            this.btnEXC.Size = new System.Drawing.Size(114, 34);
            this.btnEXC.TabIndex = 24;
            this.btnEXC.Text = "Excluir";
            this.btnEXC.UseVisualStyleBackColor = true;
            this.btnEXC.UseWaitCursor = true;
            // 
            // Jan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.btnEXC);
            this.Controls.Add(this.btnADC);
            this.Controls.Add(this.btnCleanFilter);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jan2";
            this.Text = "A";
            this.Load += new System.EventHandler(this.Jan2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCleanFilter;
        private System.Windows.Forms.Button btnADC;
        private System.Windows.Forms.Button btnEXC;
    }
}