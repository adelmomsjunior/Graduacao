namespace Projeto
{
    partial class Estatisticasmapa
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdgeral = new System.Windows.Forms.RadioButton();
            this.rdabort = new System.Windows.Forms.RadioButton();
            this.rdcumperdas = new System.Windows.Forms.RadioButton();
            this.rdcump = new System.Windows.Forms.RadioButton();
            this.rdfalha = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Projeto.Properties.Resources.GrayRoundedButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retornar a Tela de Estatisticas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdgeral
            // 
            this.rdgeral.AutoSize = true;
            this.rdgeral.BackColor = System.Drawing.Color.Transparent;
            this.rdgeral.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgeral.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdgeral.Location = new System.Drawing.Point(247, 722);
            this.rdgeral.Name = "rdgeral";
            this.rdgeral.Size = new System.Drawing.Size(67, 20);
            this.rdgeral.TabIndex = 2;
            this.rdgeral.TabStop = true;
            this.rdgeral.Text = "Gerais";
            this.rdgeral.UseVisualStyleBackColor = false;
            this.rdgeral.CheckedChanged += new System.EventHandler(this.rdgeral_CheckedChanged);
            // 
            // rdabort
            // 
            this.rdabort.AutoSize = true;
            this.rdabort.BackColor = System.Drawing.Color.Transparent;
            this.rdabort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdabort.ForeColor = System.Drawing.Color.Navy;
            this.rdabort.Location = new System.Drawing.Point(625, 722);
            this.rdabort.Name = "rdabort";
            this.rdabort.Size = new System.Drawing.Size(90, 20);
            this.rdabort.TabIndex = 3;
            this.rdabort.TabStop = true;
            this.rdabort.Text = "Abortadas";
            this.rdabort.UseVisualStyleBackColor = false;
            this.rdabort.CheckedChanged += new System.EventHandler(this.rdabort_CheckedChanged);
            // 
            // rdcumperdas
            // 
            this.rdcumperdas.AutoSize = true;
            this.rdcumperdas.BackColor = System.Drawing.Color.Transparent;
            this.rdcumperdas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcumperdas.ForeColor = System.Drawing.Color.Yellow;
            this.rdcumperdas.Location = new System.Drawing.Point(440, 722);
            this.rdcumperdas.Name = "rdcumperdas";
            this.rdcumperdas.Size = new System.Drawing.Size(173, 20);
            this.rdcumperdas.TabIndex = 4;
            this.rdcumperdas.TabStop = true;
            this.rdcumperdas.Text = "Cumpridas com Perdas";
            this.rdcumperdas.UseVisualStyleBackColor = false;
            this.rdcumperdas.CheckedChanged += new System.EventHandler(this.rdcumperdas_CheckedChanged);
            // 
            // rdcump
            // 
            this.rdcump.AutoSize = true;
            this.rdcump.BackColor = System.Drawing.Color.Transparent;
            this.rdcump.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcump.ForeColor = System.Drawing.Color.Lime;
            this.rdcump.Location = new System.Drawing.Point(340, 722);
            this.rdcump.Name = "rdcump";
            this.rdcump.Size = new System.Drawing.Size(94, 20);
            this.rdcump.TabIndex = 5;
            this.rdcump.TabStop = true;
            this.rdcump.Text = "Cumpridas";
            this.rdcump.UseVisualStyleBackColor = false;
            this.rdcump.CheckedChanged += new System.EventHandler(this.rdcump_CheckedChanged);
            // 
            // rdfalha
            // 
            this.rdfalha.AutoSize = true;
            this.rdfalha.BackColor = System.Drawing.Color.Transparent;
            this.rdfalha.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdfalha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdfalha.ForeColor = System.Drawing.Color.Red;
            this.rdfalha.Location = new System.Drawing.Point(736, 722);
            this.rdfalha.Name = "rdfalha";
            this.rdfalha.Size = new System.Drawing.Size(62, 20);
            this.rdfalha.TabIndex = 6;
            this.rdfalha.TabStop = true;
            this.rdfalha.Text = "Falha";
            this.rdfalha.UseVisualStyleBackColor = false;
            this.rdfalha.CheckedChanged += new System.EventHandler(this.rdfalha_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Estatisticasmapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto.Properties.Resources.mapa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.rdfalha);
            this.Controls.Add(this.rdabort);
            this.Controls.Add(this.rdcumperdas);
            this.Controls.Add(this.rdcump);
            this.Controls.Add(this.rdgeral);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estatisticasmapa";
            this.Text = "Estatisticasmapa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estatisticasmapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdgeral;
        private System.Windows.Forms.RadioButton rdabort;
        private System.Windows.Forms.RadioButton rdcumperdas;
        private System.Windows.Forms.RadioButton rdcump;
        private System.Windows.Forms.RadioButton rdfalha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}