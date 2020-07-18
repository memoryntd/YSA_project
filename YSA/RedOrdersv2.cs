using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Reflection;

namespace YSA
{
    public partial class RedOrdersV2 : Form
    {
        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
        MySqlConnection connection = new MySqlConnection(Conect);
        public RedOrdersV2()
        {
            InitializeComponent();
        }

        private void заказ_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказ_бордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void RedOrdersV2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказ_борд". При необходимости она может быть перемещена или удалена.
            this.заказ_бордTableAdapter.Fill(this.ysaDataSet.заказ_борд);

            connection.Open();

        }

        private void код_заказаTextBox_TextChanged(object sender, EventArgs e)
        {
            string sql = $@"SELECT * FROM заказ_борд WHERE код_заказа = '{код_заказаTextBox.Text}'";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                заказчикTextBox.Text = reader[1].ToString();
                названиеTextBox.Text = reader[2].ToString();
                количествоTextBox.Text = reader[3].ToString();
                остатокTextBox.Text = reader[4].ToString();
                цветTextBox.Text = reader[5].ToString();
                
                //TODO: решить проблему с чеком статуса заказа 


                //var outputParam = reader[7];
                //if (outputParam is 1)
                //{
                //    статус_заказаCheckBox.Checked = true; 
                //}
                    
                

                //if (a = true)
                //{
                //    статус_заказаCheckBox.Checked = true;
                //}
                //else
                //{
                //    статус_заказаCheckBox.Checked = false;
                //}
            }
            reader.Close();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Main main1 = new Main();
            main1.refOrder_Click(sender, e);


            string sql2 = $@"UPDATE заказ_борд 
                                SET Заказчик = '{заказчикTextBox.Text}',
                                    Название = '{названиеTextBox.Text}',
                                    Количество = '{количествоTextBox.Text}',
                                    Остаток = '{остатокTextBox.Text}',
                                    Цвет = '{цветTextBox.Text}'
                            WHERE код_заказа = '{код_заказаTextBox.Text}'";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);


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
        }
    }
}
