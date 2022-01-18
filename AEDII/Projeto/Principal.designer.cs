namespace Projeto
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarAreasAtingidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terroristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTerroristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarAtaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem,
            this.terroristasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.missõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarRelatóriosToolStripMenuItem,
            this.visualizarAreasAtingidasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // visualizarRelatóriosToolStripMenuItem
            // 
            this.visualizarRelatóriosToolStripMenuItem.Name = "visualizarRelatóriosToolStripMenuItem";
            this.visualizarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.visualizarRelatóriosToolStripMenuItem.Text = "Relatórios";
            this.visualizarRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.visualizarRelatóriosToolStripMenuItem_Click);
            // 
            // visualizarAreasAtingidasToolStripMenuItem
            // 
            this.visualizarAreasAtingidasToolStripMenuItem.Name = "visualizarAreasAtingidasToolStripMenuItem";
            this.visualizarAreasAtingidasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.visualizarAreasAtingidasToolStripMenuItem.Text = "Estatísticas de Ataque";
            this.visualizarAreasAtingidasToolStripMenuItem.Click += new System.EventHandler(this.visualizarAreasAtingidasToolStripMenuItem_Click);
            // 
            // terroristasToolStripMenuItem
            // 
            this.terroristasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarBancoToolStripMenuItem,
            this.editarBancoToolStripMenuItem});
            this.terroristasToolStripMenuItem.Name = "terroristasToolStripMenuItem";
            this.terroristasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.terroristasToolStripMenuItem.Text = "Terroristas";
            // 
            // visualizarBancoToolStripMenuItem
            // 
            this.visualizarBancoToolStripMenuItem.Name = "visualizarBancoToolStripMenuItem";
            this.visualizarBancoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.visualizarBancoToolStripMenuItem.Text = "Visualizar Banco";
            this.visualizarBancoToolStripMenuItem.Click += new System.EventHandler(this.visualizarBancoToolStripMenuItem_Click);
            // 
            // editarBancoToolStripMenuItem
            // 
            this.editarBancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.editarTerroristaToolStripMenuItem});
            this.editarBancoToolStripMenuItem.Name = "editarBancoToolStripMenuItem";
            this.editarBancoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editarBancoToolStripMenuItem.Text = "Editar Banco";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // editarTerroristaToolStripMenuItem
            // 
            this.editarTerroristaToolStripMenuItem.Name = "editarTerroristaToolStripMenuItem";
            this.editarTerroristaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editarTerroristaToolStripMenuItem.Text = "Editar Terrorista";
            this.editarTerroristaToolStripMenuItem.Click += new System.EventHandler(this.editarTerroristaToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem1,
            this.deletarUsuárioToolStripMenuItem,
            this.históricoDeLoginToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            this.cadastrarNovoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click);
            // 
            // deletarUsuárioToolStripMenuItem
            // 
            this.deletarUsuárioToolStripMenuItem.Name = "deletarUsuárioToolStripMenuItem";
            this.deletarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarUsuárioToolStripMenuItem.Text = "Deletar Usuário";
            this.deletarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.deletarUsuárioToolStripMenuItem_Click);
            // 
            // históricoDeLoginToolStripMenuItem
            // 
            this.históricoDeLoginToolStripMenuItem.Name = "históricoDeLoginToolStripMenuItem";
            this.históricoDeLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.históricoDeLoginToolStripMenuItem.Text = "Histórico de acesso";
            this.históricoDeLoginToolStripMenuItem.Click += new System.EventHandler(this.históricoDeLoginToolStripMenuItem_Click);
            // 
            // missõesToolStripMenuItem
            // 
            this.missõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarAtaqueToolStripMenuItem});
            this.missõesToolStripMenuItem.Name = "missõesToolStripMenuItem";
            this.missõesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.missõesToolStripMenuItem.Text = "Missões";
            // 
            // enviarAtaqueToolStripMenuItem
            // 
            this.enviarAtaqueToolStripMenuItem.Name = "enviarAtaqueToolStripMenuItem";
            this.enviarAtaqueToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.enviarAtaqueToolStripMenuItem.Text = "Enviar Ataque";
            this.enviarAtaqueToolStripMenuItem.Click += new System.EventHandler(this.enviarAtaqueToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
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
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(748, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 37);
            this.label4.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Projeto.Properties.Resources.Tela_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarRelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terroristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarTerroristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missõesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem enviarAtaqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarAreasAtingidasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem históricoDeLoginToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}