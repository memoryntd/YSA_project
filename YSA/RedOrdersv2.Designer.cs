namespace YSA
{
    partial class RedOrdersV2
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
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label заказчикLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label остатокLabel;
            System.Windows.Forms.Label цветLabel;
            this.ysaDataSet = new YSA.ysaDataSet();
            this.заказ_бордBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказ_бордTableAdapter = new YSA.ysaDataSetTableAdapters.заказ_бордTableAdapter();
            this.tableAdapterManager = new YSA.ysaDataSetTableAdapters.TableAdapterManager();
            this.код_заказаTextBox = new System.Windows.Forms.TextBox();
            this.заказчикTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.остатокTextBox = new System.Windows.Forms.TextBox();
            this.цветTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            код_заказаLabel = new System.Windows.Forms.Label();
            заказчикLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            остатокLabel = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ysaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказ_бордBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(37, 36);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(68, 13);
            код_заказаLabel.TabIndex = 0;
            код_заказаLabel.Text = "Код заказа:";
            // 
            // заказчикLabel
            // 
            заказчикLabel.AutoSize = true;
            заказчикLabel.Location = new System.Drawing.Point(37, 62);
            заказчикLabel.Name = "заказчикLabel";
            заказчикLabel.Size = new System.Drawing.Size(58, 13);
            заказчикLabel.TabIndex = 2;
            заказчикLabel.Text = "Заказчик:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(37, 88);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 4;
            названиеLabel.Text = "Название:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(37, 114);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 6;
            количествоLabel.Text = "Количество:";
            // 
            // остатокLabel
            // 
            остатокLabel.AutoSize = true;
            остатокLabel.Location = new System.Drawing.Point(37, 140);
            остатокLabel.Name = "остатокLabel";
            остатокLabel.Size = new System.Drawing.Size(52, 13);
            остатокLabel.TabIndex = 8;
            остатокLabel.Text = "Остаток:";
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.Location = new System.Drawing.Point(37, 166);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(35, 13);
            цветLabel.TabIndex = 10;
            цветLabel.Text = "Цвет:";
            // 
            // ysaDataSet
            // 
            this.ysaDataSet.DataSetName = "ysaDataSet";
            this.ysaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказ_бордBindingSource
            // 
            this.заказ_бордBindingSource.DataMember = "заказ_борд";
            this.заказ_бордBindingSource.DataSource = this.ysaDataSet;
            // 
            // заказ_бордTableAdapter
            // 
            this.заказ_бордTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = YSA.ysaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.заказ_бордTableAdapter = this.заказ_бордTableAdapter;
            this.tableAdapterManager.заказчикиTableAdapter = null;
            this.tableAdapterManager.календарь_поступления_бордTableAdapter = null;
            this.tableAdapterManager.отгрузки_бордTableAdapter = null;
            this.tableAdapterManager.продажа_бордTableAdapter = null;
            this.tableAdapterManager.склад_бордTableAdapter = null;
            this.tableAdapterManager.список_бордTableAdapter = null;
            // 
            // код_заказаTextBox
            // 
            this.код_заказаTextBox.Location = new System.Drawing.Point(174, 33);
            this.код_заказаTextBox.Name = "код_заказаTextBox";
            this.код_заказаTextBox.Size = new System.Drawing.Size(127, 20);
            this.код_заказаTextBox.TabIndex = 1;
            this.код_заказаTextBox.TextChanged += new System.EventHandler(this.код_заказаTextBox_TextChanged);
            // 
            // заказчикTextBox
            // 
            this.заказчикTextBox.Location = new System.Drawing.Point(174, 59);
            this.заказчикTextBox.Name = "заказчикTextBox";
            this.заказчикTextBox.Size = new System.Drawing.Size(127, 20);
            this.заказчикTextBox.TabIndex = 3;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.Location = new System.Drawing.Point(174, 85);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(127, 20);
            this.названиеTextBox.TabIndex = 5;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.Location = new System.Drawing.Point(174, 111);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(127, 20);
            this.количествоTextBox.TabIndex = 7;
            // 
            // остатокTextBox
            // 
            this.остатокTextBox.Location = new System.Drawing.Point(174, 137);
            this.остатокTextBox.Name = "остатокTextBox";
            this.остатокTextBox.Size = new System.Drawing.Size(127, 20);
            this.остатокTextBox.TabIndex = 9;
            // 
            // цветTextBox
            // 
            this.цветTextBox.Location = new System.Drawing.Point(174, 163);
            this.цветTextBox.Name = "цветTextBox";
            this.цветTextBox.Size = new System.Drawing.Size(127, 20);
            this.цветTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RedOrdersV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_заказаLabel);
            this.Controls.Add(this.код_заказаTextBox);
            this.Controls.Add(заказчикLabel);
            this.Controls.Add(this.заказчикTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(остатокLabel);
            this.Controls.Add(this.остатокTextBox);
            this.Controls.Add(цветLabel);
            this.Controls.Add(this.цветTextBox);
            this.Name = "RedOrdersV2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.RedOrdersV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ysaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказ_бордBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ysaDataSet ysaDataSet;
        private System.Windows.Forms.BindingSource заказ_бордBindingSource;
        private ysaDataSetTableAdapters.заказ_бордTableAdapter заказ_бордTableAdapter;
        private ysaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_заказаTextBox;
        private System.Windows.Forms.TextBox заказчикTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox остатокTextBox;
        private System.Windows.Forms.TextBox цветTextBox;
        private System.Windows.Forms.Button button1;
    }
}