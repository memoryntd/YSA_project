using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSA
{
    public partial class RedWare : Form
    {
        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
        MySqlConnection connection = new MySqlConnection(Conect);
        public RedWare()
        {
            InitializeComponent();
        }

        private void склад_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.склад_бордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void RedWare_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.склад_борд". При необходимости она может быть перемещена или удалена.
            this.склад_бордTableAdapter.Fill(this.ysaDataSet.склад_борд);
            connection.Open();

            string sql1 = $@"SELECT DISTINCT Название_борд FROM склад_борд";
            MySqlCommand com_1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader_1 = com_1.ExecuteReader();
            название_бордComboBox.Items.Clear();
            while (reader_1.Read())
            {
                название_бордComboBox.Items.Add(reader_1[0].ToString());
            }
            reader_1.Close();
        }

        private void название_бордComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = $@"SELECT Цвет FROM склад_борд WHERE Название_борд = '{название_бордComboBox.Text}'";
            MySqlCommand com_1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader_1 = com_1.ExecuteReader();
            цветComboBox.Items.Clear();
            while (reader_1.Read())
            {
                цветComboBox.Items.Add(reader_1[0].ToString());
            }
            reader_1.Close();
        }

        private void цветComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = $@"SELECT DISTINCT Количество, Свободная_продажа, В_заказах FROM склад_борд 
                            WHERE Название_борд = '{название_бордComboBox.Text}'" +
                            $@"AND Цвет = '{цветComboBox.Text}'" ;
            MySqlCommand com_1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader_1 = com_1.ExecuteReader();
            количествоTextBox.Text = "";
            свободная_продажаTextBox.Text = "";
            в_заказахTextBox.Text = "";
            while (reader_1.Read())
            {
                количествоTextBox.Text = reader_1[0].ToString();
                свободная_продажаTextBox.Text = reader_1[1].ToString();
                в_заказахTextBox.Text = reader_1[2].ToString();
            }
            reader_1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $@"UPDATE склад_борд 
                            SET Количество = '{количествоTextBox.Text}',
                                Свободная_продажа = '{свободная_продажаTextBox.Text}',
                                В_заказах = '{в_заказахTextBox.Text}'
                            WHERE Название_борд = '{название_бордComboBox.Text}'" +
                            $@"AND Цвет = '{цветComboBox.Text}'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    Main main = new Main();
                    main.refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
