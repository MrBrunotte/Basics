
namespace TempConversion
{
    partial class Form1
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
            this.lbl_fahrenheight = new System.Windows.Forms.Label();
            this.lbl_celcius = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.txt_fahrenheight = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_fahrenheight = new System.Windows.Forms.Button();
            this.btn_celcius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_fahrenheight
            // 
            this.lbl_fahrenheight.AutoSize = true;
            this.lbl_fahrenheight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fahrenheight.Location = new System.Drawing.Point(23, 26);
            this.lbl_fahrenheight.Name = "lbl_fahrenheight";
            this.lbl_fahrenheight.Size = new System.Drawing.Size(125, 25);
            this.lbl_fahrenheight.TabIndex = 0;
            this.lbl_fahrenheight.Text = "Fahrenheight";
            // 
            // lbl_celcius
            // 
            this.lbl_celcius.AutoSize = true;
            this.lbl_celcius.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celcius.Location = new System.Drawing.Point(73, 62);
            this.lbl_celcius.Name = "lbl_celcius";
            this.lbl_celcius.Size = new System.Drawing.Size(75, 25);
            this.lbl_celcius.TabIndex = 1;
            this.lbl_celcius.Text = "Celcius";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kelvin.Location = new System.Drawing.Point(83, 98);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(65, 25);
            this.lbl_kelvin.TabIndex = 2;
            this.lbl_kelvin.Text = "Kelvin";
            // 
            // txt_fahrenheight
            // 
            this.txt_fahrenheight.Location = new System.Drawing.Point(169, 31);
            this.txt_fahrenheight.Name = "txt_fahrenheight";
            this.txt_fahrenheight.Size = new System.Drawing.Size(100, 20);
            this.txt_fahrenheight.TabIndex = 3;
            this.txt_fahrenheight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(169, 64);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(100, 20);
            this.txt_celsius.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Location = new System.Drawing.Point(169, 97);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(100, 20);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_fahrenheight
            // 
            this.btn_fahrenheight.Location = new System.Drawing.Point(289, 31);
            this.btn_fahrenheight.Name = "btn_fahrenheight";
            this.btn_fahrenheight.Size = new System.Drawing.Size(75, 23);
            this.btn_fahrenheight.TabIndex = 6;
            this.btn_fahrenheight.Text = "Convert";
            this.btn_fahrenheight.UseVisualStyleBackColor = true;
            this.btn_fahrenheight.Click += new System.EventHandler(this.btn_fahrenheight_Click);
            // 
            // btn_celcius
            // 
            this.btn_celcius.Location = new System.Drawing.Point(289, 64);
            this.btn_celcius.Name = "btn_celcius";
            this.btn_celcius.Size = new System.Drawing.Size(75, 23);
            this.btn_celcius.TabIndex = 7;
            this.btn_celcius.Text = "Convert";
            this.btn_celcius.UseVisualStyleBackColor = true;
            this.btn_celcius.Click += new System.EventHandler(this.btn_celcius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Location = new System.Drawing.Point(289, 97);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(75, 23);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(549, 293);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celcius);
            this.Controls.Add(this.btn_fahrenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_fahrenheight);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_celcius);
            this.Controls.Add(this.lbl_fahrenheight);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fahrenheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fahrenheight;
        private System.Windows.Forms.Label lbl_celcius;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.TextBox txt_fahrenheight;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_fahrenheight;
        private System.Windows.Forms.Button btn_celcius;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

