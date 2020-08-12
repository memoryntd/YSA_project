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
    public partial class DeleteWarehouse : Form
    {
        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
        MySqlConnection connection = new MySqlConnection(Conect);
        public DeleteWarehouse()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string sql = $@"UPDATE склад_борд 
                            SET Количество = Количество - '{количествоTextBox2.Text}',
                                Свободная_продажа = Свободная_продажа - '{количествоTextBox2.Text}'
                            WHERE Название_борд = '{comboBox1.Text}'" +
                                $@"AND Цвет = '{comboBox4.Text}'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            Main main1 = new Main();

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    количествоTextBox2.Text = "";
                    comboBox4.Text = "";
                    main1.refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteWarehouse_Load(object sender, EventArgs e)
        {
            connection.Open();

            string sql1 = $@"SELECT DISTINCT Название_борд FROM склад_борд";
            MySqlCommand com_1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader_1 = com_1.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader_1.Read())
            {
                comboBox1.Items.Add(reader_1[0].ToString());
            }
            reader_1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_idWare = $@"SELECT DISTINCT Цвет FROM склад_борд WHERE Название_борд = '{comboBox1.Text}' ";
            MySqlCommand com_idWare = new MySqlCommand(sql_idWare, connection);
            MySqlDataReader reader_idWare = com_idWare.ExecuteReader();
            comboBox4.Items.Clear();
            while (reader_idWare.Read())
            {
                comboBox4.Items.Add(reader_idWare[0].ToString());
            }
            reader_idWare.Close();
        }
    }
}
