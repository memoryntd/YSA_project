namespace YSA
{
    partial class DeleteWarehouse
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label название_бордLabel1;
            System.Windows.Forms.Label количествоLabel2;
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.количествоTextBox2 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            название_бордLabel1 = new System.Windows.Forms.Label();
            количествоLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(16, 52);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(35, 13);
            label10.TabIndex = 27;
            label10.Text = "Цвет:";
            // 
            // название_бордLabel1
            // 
            название_бордLabel1.AutoSize = true;
            название_бордLabel1.Location = new System.Drawing.Point(16, 25);
            название_бордLabel1.Name = "название_бордLabel1";
            название_бордLabel1.Size = new System.Drawing.Size(107, 13);
            название_бордLabel1.TabIndex = 23;
            название_бордLabel1.Text = "Название бордюра:";
            // 
            // количествоLabel2
            // 
            количествоLabel2.AutoSize = true;
            количествоLabel2.Location = new System.Drawing.Point(17, 78);
            количествоLabel2.Name = "количествоLabel2";
            количествоLabel2.Size = new System.Drawing.Size(69, 13);
            количествоLabel2.TabIndex = 24;
            количествоLabel2.Text = "Количество:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Списать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(134, 48);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(156, 21);
            this.comboBox4.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // количествоTextBox2
            // 
            this.количествоTextBox2.Location = new System.Drawing.Point(135, 75);
            this.количествоTextBox2.Name = "количествоTextBox2";
            this.количествоTextBox2.Size = new System.Drawing.Size(156, 20);
            this.количествоTextBox2.TabIndex = 25;
            // 
            // DeleteWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 156);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(название_бордLabel1);
            this.Controls.Add(количествоLabel2);
            this.Controls.Add(this.количествоTextBox2);
            this.Controls.Add(this.button1);
            this.Name = "DeleteWarehouse";
            this.Text = "Списание со склада";
            this.Load += new System.EventHandler(this.DeleteWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox количествоTextBox2;
    }
}