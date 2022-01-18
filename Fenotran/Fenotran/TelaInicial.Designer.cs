namespace Fenotran
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.BtSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umaParedePlanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duasParedesPlanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trêsParedesPlanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umaParedeCilíndricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Data = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtSair
            // 
            this.BtSair.BackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatAppearance.BorderSize = 0;
            this.BtSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSair.Location = new System.Drawing.Point(1217, 0);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(133, 47);
            this.BtSair.TabIndex = 0;
            this.BtSair.UseVisualStyleBackColor = false;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.conversõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.umaParedePlanaToolStripMenuItem,
            this.duasParedesPlanasToolStripMenuItem,
            this.trêsParedesPlanasToolStripMenuItem,
            this.umaParedeCilíndricaToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // umaParedePlanaToolStripMenuItem
            // 
            this.umaParedePlanaToolStripMenuItem.Name = "umaParedePlanaToolStripMenuItem";
            this.umaParedePlanaToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.umaParedePlanaToolStripMenuItem.Text = "Uma Parede Plana";
            this.umaParedePlanaToolStripMenuItem.Click += new System.EventHandler(this.umaParedePlanaToolStripMenuItem_Click);
            // 
            // duasParedesPlanasToolStripMenuItem
            // 
            this.duasParedesPlanasToolStripMenuItem.Name = "duasParedesPlanasToolStripMenuItem";
            this.duasParedesPlanasToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.duasParedesPlanasToolStripMenuItem.Text = "Duas Paredes Planas";
            this.duasParedesPlanasToolStripMenuItem.Click += new System.EventHandler(this.duasParedesPlanasToolStripMenuItem_Click);
            // 
            // trêsParedesPlanasToolStripMenuItem
            // 
            this.trêsParedesPlanasToolStripMenuItem.Name = "trêsParedesPlanasToolStripMenuItem";
            this.trêsParedesPlanasToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.trêsParedesPlanasToolStripMenuItem.Text = "Três Paredes Planas";
            this.trêsParedesPlanasToolStripMenuItem.Click += new System.EventHandler(this.trêsParedesPlanasToolStripMenuItem_Click);
            // 
            // umaParedeCilíndricaToolStripMenuItem
            // 
            this.umaParedeCilíndricaToolStripMenuItem.Name = "umaParedeCilíndricaToolStripMenuItem";
            this.umaParedeCilíndricaToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.umaParedeCilíndricaToolStripMenuItem.Text = "Uma Parede Cilíndrica";
            this.umaParedeCilíndricaToolStripMenuItem.Click += new System.EventHandler(this.umaParedeCilíndricaToolStripMenuItem_Click);
            // 
            // conversõesToolStripMenuItem
            // 
            this.conversõesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.conversõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaturaToolStripMenuItem,
            this.dimensõesToolStripMenuItem});
            this.conversõesToolStripMenuItem.Name = "conversõesToolStripMenuItem";
            this.conversõesToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.conversõesToolStripMenuItem.Text = "Conversões";
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // dimensõesToolStripMenuItem
            // 
            this.dimensõesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dimensõesToolStripMenuItem.Name = "dimensõesToolStripMenuItem";
            this.dimensõesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.dimensõesToolStripMenuItem.Text = "Dimensões";
            this.dimensõesToolStripMenuItem.Click += new System.EventHandler(this.dimensõesToolStripMenuItem_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.Black;
            this.Data.Location = new System.Drawing.Point(12, 735);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 24);
            this.Data.TabIndex = 2;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(397, 735);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(0, 24);
            this.Hora.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 247);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(985, 110);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utilize as abas acima para navegar pelo programa";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.BtSair);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umaParedePlanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duasParedesPlanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trêsParedesPlanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensõesToolStripMenuItem;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem umaParedeCilíndricaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}