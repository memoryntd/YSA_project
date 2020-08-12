using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSA
{
    public partial class sortbord3 : Form
    {
        private string a;

        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
        MySqlConnection connection = new MySqlConnection(Conect);

        public sortbord3()
        {
            InitializeComponent();
        }
        

private void sortbord3_Load(object sender, EventArgs e)
        {
            connection.Open();

            string sql1 = $@"SELECT DISTINCT Название_борд FROM склад_борд WHERE Название_борд NOT LIKE '%(3)'";
            MySqlCommand com_1 = new MySqlCommand(sql1, connection);
            MySqlDataReader reader_1 = com_1.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader_1.Read())
            {
                comboBox1.Items.Add(reader_1[0].ToString());
            }
            reader_1.Close();

            //using (MySqlConnection connection = new MySqlConnection(Conect))
            //{
            //    connection.Open();
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_idWare = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBox1.Text}' ";
            MySqlCommand com_idWare = new MySqlCommand(sql_idWare, connection);
            MySqlDataReader reader_idWare = com_idWare.ExecuteReader();
            comboBox4.Items.Clear();
            while (reader_idWare.Read())
            {
                comboBox4.Items.Add(reader_idWare[0].ToString());
            }
            reader_idWare.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT DISTINCT Название_борд FROM склад_борд WHERE Название_борд = '{comboBox1.Text + " (3)"}'" +
                                                                                $@"AND Цвет = '{comboBox4.Text}'";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();

            
            if (reader.Read())
            {
                a = reader[0].ToString();
            }
            reader.Close();
            //string a = reader[0].ToString();
            //string a = sql.ExecuteScalar();
            if (a == comboBox1.Text + " (3)")
            {
                string sql2 = $@"UPDATE склад_борд 
                            SET Количество = Количество + '{количествоTextBox2.Text}',
                                Свободная_продажа = Свободная_продажа + '{количествоTextBox2.Text}'
                            WHERE Название_борд = '{comboBox1.Text + " (3)"}'" +
                            $@"AND Цвет = '{comboBox4.Text}'";
                MySqlCommand command2 = new MySqlCommand(sql2, connection);

                Main main1 = new Main();

                try
                {
                    if (command2.ExecuteNonQuery() > 0)
                    {
                        main1.refWarehouse_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                string sql3 = $@"UPDATE склад_борд 
                            SET Количество = Количество - '{количествоTextBox2.Text}',
                                Свободная_продажа = Свободная_продажа - '{количествоTextBox2.Text}'
                            WHERE Название_борд = '{comboBox1.Text}'" +
                                $@"AND Цвет = '{comboBox4.Text}'";
                MySqlCommand command3 = new MySqlCommand(sql3, connection);

                try
                {
                    if (command3.ExecuteNonQuery() > 0)
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
            else
            {
                string sql1 = $@"INSERT INTO склад_борд (Название_борд , Цвет , Количество , Свободная_продажа, В_заказах)
                            VALUES('{comboBox1.Text + " (3)"}' , '{comboBox4.Text}' , '{количествоTextBox2.Text}' , '{количествоTextBox2.Text}' , 0)";
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                
                try
                {
                    if (command1.ExecuteNonQuery() > 0)
                    {
                        comboBox1.Text = "";
                        comboBox4.Text = "";
                        количествоTextBox2.Text = "";

                        Main main1 = new Main();
                        main1.refList_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Ошибка");
                }
                reader.Close();
            }
            





            //while (reader.Read())
            //{
            //    if (Convert.ToInt32(reader["balance"]) <= 0 && Convert.ToInt32(reader["balance"]) < Convert.ToInt32(numBalance.Value))
            //    {
            //        MessageBox.Show("Недостатовно средств", "Системное сообщение");
            //    }
            //    else
            //    {
            //        MySqlCommand balancecmd = cnt.CreateCommand();
            //        balancecmd.CommandText = "SELECT balance FROM t_user WHERE username='" + textUserName.Text + "' and pass='" + Convert.ToString(textPassword.Text) + "'";
            //        balancecmd.ExecuteNonQuery();

            //        MySqlCommand cmd = cnt.CreateCommand();
            //        cmd.CommandText = "UPDATE t_user SET balance = balance - 50 - '" + numBalance.Value + "' WHERE username='" + textUserName.Text + "' and pass='" + Convert.ToString(textPassword.Text) + "'";
            //        cmd.ExecuteNonQuery();

            //        MessageBox.Show("Сайт добавлен", "Системное сообщение");
            //    }
            //}

            //while (reader.Read())
            //{
            //    if (Convert.ToInt32(reader["balance"]) <= 0 && Convert.ToInt32(reader["balance"]) < Convert.ToInt32(numBalance.Value))
            //    {
            //        MessageBox.Show("Недостатовно средств", "Системное сообщение");
            //    }
            //    else
            //    {
            //        MySqlCommand balancecmd = cnt.CreateCommand();
            //        balancecmd.CommandText = "SELECT balance FROM t_user WHERE username='" + textUserName.Text + "' and pass='" + Convert.ToString(textPassword.Text) + "'";

            //        MySqlCommand cmd = cnt.CreateCommand();
            //        cmd.CommandText = "UPDATE t_user SET balance = balance - 50 - '" + numBalance.Value + "' WHERE username='" + textUserName.Text + "' and pass='" + Convert.ToString(textPassword.Text) + "'";

            //        reader.Close();
            //        cmd.ExecuteNonQuery();
            //        balancecmd.ExecuteNonQuery();
            //        MessageBox.Show("Сайт добавлен", "Системное сообщение");
            //    }
            //}
        }
    }
}
