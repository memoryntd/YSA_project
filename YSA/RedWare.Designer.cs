namespace YSA
{
    partial class RedWare
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
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label свободная_продажаLabel;
            System.Windows.Forms.Label в_заказахLabel;
            System.Windows.Forms.Label название_бордLabel1;
            System.Windows.Forms.Label цветLabel;
            this.ysaDataSet = new YSA.ysaDataSet();
            this.склад_бордBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.склад_бордTableAdapter = new YSA.ysaDataSetTableAdapters.склад_бордTableAdapter();
            this.tableAdapterManager = new YSA.ysaDataSetTableAdapters.TableAdapterManager();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.свободная_продажаTextBox = new System.Windows.Forms.TextBox();
            this.в_заказахTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.название_бордComboBox = new System.Windows.Forms.ComboBox();
            this.цветComboBox = new System.Windows.Forms.ComboBox();
            количествоLabel = new System.Windows.Forms.Label();
            свободная_продажаLabel = new System.Windows.Forms.Label();
            в_заказахLabel = new System.Windows.Forms.Label();
            название_бордLabel1 = new System.Windows.Forms.Label();
            цветLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ysaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.склад_бордBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ysaDataSet
            // 
            this.ysaDataSet.DataSetName = "ysaDataSet";
            this.ysaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // склад_бордBindingSource
            // 
            this.склад_бордBindingSource.DataMember = "склад_борд";
            this.склад_бордBindingSource.DataSource = this.ysaDataSet;
            // 
            // склад_бордTableAdapter
            // 
            this.склад_бордTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = YSA.ysaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.заказ_бордTableAdapter = null;
            this.tableAdapterManager.заказчикиTableAdapter = null;
            this.tableAdapterManager.календарь_поступления_бордTableAdapter = null;
            this.tableAdapterManager.отгрузки_бордTableAdapter = null;
            this.tableAdapterManager.продажа_бордTableAdapter = null;
            this.tableAdapterManager.склад_бордTableAdapter = this.склад_бордTableAdapter;
            this.tableAdapterManager.список_бордTableAdapter = null;
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(18, 114);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 7;
            количествоLabel.Text = "Количество:";
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.Location = new System.Drawing.Point(136, 111);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(170, 20);
            this.количествоTextBox.TabIndex = 8;
            // 
            // свободная_продажаLabel
            // 
            свободная_продажаLabel.AutoSize = true;
            свободная_продажаLabel.Location = new System.Drawing.Point(18, 140);
            свободная_продажаLabel.Name = "свободная_продажаLabel";
            свободная_продажаLabel.Size = new System.Drawing.Size(112, 13);
            свободная_продажаLabel.TabIndex = 9;
            свободная_продажаLabel.Text = "Свободная продажа:";
            // 
            // свободная_продажаTextBox
            // 
            this.свободная_продажаTextBox.Location = new System.Drawing.Point(136, 137);
            this.свободная_продажаTextBox.Name = "свободная_продажаTextBox";
            this.свободная_продажаTextBox.Size = new System.Drawing.Size(170, 20);
            this.свободная_продажаTextBox.TabIndex = 10;
            // 
            // в_заказахLabel
            // 
            в_заказахLabel.AutoSize = true;
            в_заказахLabel.Location = new System.Drawing.Point(18, 166);
            в_заказахLabel.Name = "в_заказахLabel";
            в_заказахLabel.Size = new System.Drawing.Size(61, 13);
            в_заказахLabel.TabIndex = 11;
            в_заказахLabel.Text = "В заказах:";
            // 
            // в_заказахTextBox
            // 
            this.в_заказахTextBox.Location = new System.Drawing.Point(136, 163);
            this.в_заказахTextBox.Name = "в_заказахTextBox";
            this.в_заказахTextBox.Size = new System.Drawing.Size(170, 20);
            this.в_заказахTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // название_бордLabel1
            // 
            название_бордLabel1.AutoSize = true;
            название_бордLabel1.Location = new System.Drawing.Point(18, 45);
            название_бордLabel1.Name = "название_бордLabel1";
            название_бордLabel1.Size = new System.Drawing.Size(87, 13);
            название_бордLabel1.TabIndex = 19;
            название_бордLabel1.Text = "Название борд:";
            // 
            // название_бордComboBox
            // 
            this.название_бордComboBox.FormattingEnabled = true;
            this.название_бордComboBox.Location = new System.Drawing.Point(136, 42);
            this.название_бордComboBox.Name = "название_бордComboBox";
            this.название_бордComboBox.Size = new System.Drawing.Size(170, 21);
            this.название_бордComboBox.TabIndex = 20;
            this.название_бордComboBox.SelectedIndexChanged += new System.EventHandler(this.название_бордComboBox_SelectedIndexChanged);
            // 
            // цветLabel
            // 
            цветLabel.AutoSize = true;
            цветLabel.Location = new System.Drawing.Point(18, 72);
            цветLabel.Name = "цветLabel";
            цветLabel.Size = new System.Drawing.Size(35, 13);
            цветLabel.TabIndex = 20;
            цветLabel.Text = "Цвет:";
            // 
            // цветComboBox
            // 
            this.цветComboBox.FormattingEnabled = true;
            this.цветComboBox.Location = new System.Drawing.Point(136, 69);
            this.цветComboBox.Name = "цветComboBox";
            this.цветComboBox.Size = new System.Drawing.Size(170, 21);
            this.цветComboBox.TabIndex = 21;
            this.цветComboBox.SelectedIndexChanged += new System.EventHandler(this.цветComboBox_SelectedIndexChanged);
            // 
            // RedWare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 255);
            this.Controls.Add(цветLabel);
            this.Controls.Add(this.цветComboBox);
            this.Controls.Add(название_бордLabel1);
            this.Controls.Add(this.название_бордComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(свободная_продажаLabel);
            this.Controls.Add(this.свободная_продажаTextBox);
            this.Controls.Add(в_заказахLabel);
            this.Controls.Add(this.в_заказахTextBox);
            this.Name = "RedWare";
            this.Text = "RedWare";
            this.Load += new System.EventHandler(this.RedWare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ysaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.склад_бордBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ysaDataSet ysaDataSet;
        private System.Windows.Forms.BindingSource склад_бордBindingSource;
        private ysaDataSetTableAdapters.склад_бордTableAdapter склад_бордTableAdapter;
        private ysaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox свободная_продажаTextBox;
        private System.Windows.Forms.TextBox в_заказахTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox название_бордComboBox;
        private System.Windows.Forms.ComboBox цветComboBox;
    }
}