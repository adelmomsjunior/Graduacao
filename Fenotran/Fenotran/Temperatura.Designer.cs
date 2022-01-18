namespace Fenotran
{
    partial class Temperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperatura));
            this.BtSair = new System.Windows.Forms.Button();
            this.TxtConverter = new System.Windows.Forms.TextBox();
            this.Kelvin = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.Celcius = new System.Windows.Forms.Label();
            this.RbCelsius = new System.Windows.Forms.RadioButton();
            this.RbFahrenheit = new System.Windows.Forms.RadioButton();
            this.RbKelvin = new System.Windows.Forms.RadioButton();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtSair
            // 
            this.BtSair.BackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatAppearance.BorderSize = 0;
            this.BtSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSair.Location = new System.Drawing.Point(903, 0);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(464, 61);
            this.BtSair.TabIndex = 1;
            this.BtSair.UseVisualStyleBackColor = false;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // TxtConverter
            // 
            this.TxtConverter.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.TxtConverter.Location = new System.Drawing.Point(253, 146);
            this.TxtConverter.Name = "TxtConverter";
            this.TxtConverter.Size = new System.Drawing.Size(100, 46);
            this.TxtConverter.TabIndex = 2;
            this.TxtConverter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConverter_KeyPress);
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.BackColor = System.Drawing.Color.Transparent;
            this.Kelvin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.Kelvin.ForeColor = System.Drawing.Color.DarkRed;
            this.Kelvin.Location = new System.Drawing.Point(911, 380);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(0, 39);
            this.Kelvin.TabIndex = 11;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.Fahrenheit.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.Fahrenheit.ForeColor = System.Drawing.Color.DarkRed;
            this.Fahrenheit.Location = new System.Drawing.Point(911, 240);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(0, 39);
            this.Fahrenheit.TabIndex = 10;
            // 
            // Celcius
            // 
            this.Celcius.AutoSize = true;
            this.Celcius.BackColor = System.Drawing.Color.Transparent;
            this.Celcius.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.Celcius.ForeColor = System.Drawing.Color.DarkRed;
            this.Celcius.Location = new System.Drawing.Point(911, 524);
            this.Celcius.Name = "Celcius";
            this.Celcius.Size = new System.Drawing.Size(0, 39);
            this.Celcius.TabIndex = 9;
            // 
            // RbCelsius
            // 
            this.RbCelsius.AutoSize = true;
            this.RbCelsius.BackColor = System.Drawing.Color.Transparent;
            this.RbCelsius.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCelsius.Location = new System.Drawing.Point(145, 534);
            this.RbCelsius.Name = "RbCelsius";
            this.RbCelsius.Size = new System.Drawing.Size(14, 13);
            this.RbCelsius.TabIndex = 12;
            this.RbCelsius.TabStop = true;
            this.RbCelsius.UseVisualStyleBackColor = false;
            // 
            // RbFahrenheit
            // 
            this.RbFahrenheit.AutoSize = true;
            this.RbFahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.RbFahrenheit.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFahrenheit.Location = new System.Drawing.Point(145, 269);
            this.RbFahrenheit.Name = "RbFahrenheit";
            this.RbFahrenheit.Size = new System.Drawing.Size(14, 13);
            this.RbFahrenheit.TabIndex = 13;
            this.RbFahrenheit.TabStop = true;
            this.RbFahrenheit.UseVisualStyleBackColor = false;
            // 
            // RbKelvin
            // 
            this.RbKelvin.AutoSize = true;
            this.RbKelvin.BackColor = System.Drawing.Color.Transparent;
            this.RbKelvin.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbKelvin.Location = new System.Drawing.Point(145, 403);
            this.RbKelvin.Name = "RbKelvin";
            this.RbKelvin.Size = new System.Drawing.Size(14, 13);
            this.RbKelvin.TabIndex = 14;
            this.RbKelvin.TabStop = true;
            this.RbKelvin.UseVisualStyleBackColor = false;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.Transparent;
            this.Calcular.FlatAppearance.BorderSize = 0;
            this.Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcular.Location = new System.Drawing.Point(169, 629);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(252, 81);
            this.Calcular.TabIndex = 16;
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            this.Calcular.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calcular_MouseMove);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.RbKelvin);
            this.Controls.Add(this.RbFahrenheit);
            this.Controls.Add(this.RbCelsius);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celcius);
            this.Controls.Add(this.TxtConverter);
            this.Controls.Add(this.BtSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temperatura";
            this.Text = "Temperatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.TextBox TxtConverter;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Label Fahrenheit;
        private System.Windows.Forms.Label Celcius;
        private System.Windows.Forms.RadioButton RbCelsius;
        private System.Windows.Forms.RadioButton RbFahrenheit;
        private System.Windows.Forms.RadioButton RbKelvin;
        private System.Windows.Forms.Button Calcular;
    }
}