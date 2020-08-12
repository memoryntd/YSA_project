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
using System.Linq.Expressions;

namespace YSA
{
    public partial class Main : Form
    {
        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
        MySqlConnection connection = new MySqlConnection(Conect);
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказ_борд". При необходимости она может быть перемещена или удалена.
            this.заказ_бордTableAdapter.Fill(this.ysaDataSet.заказ_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.продажа_борд". При необходимости она может быть перемещена или удалена.
            this.продажа_бордTableAdapter.Fill(this.ysaDataSet.продажа_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.склад_борд". При необходимости она может быть перемещена или удалена.
            this.склад_бордTableAdapter.Fill(this.ysaDataSet.склад_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.ysaDataSet.заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.список_борд". При необходимости она может быть перемещена или удалена.
            this.список_бордTableAdapter.Fill(this.ysaDataSet.список_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.календарь_поступления_борд". При необходимости она может быть перемещена или удалена.
            this.календарь_поступления_бордTableAdapter.Fill(this.ysaDataSet.календарь_поступления_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.склад_борд". При необходимости она может быть перемещена или удалена.
            this.склад_бордTableAdapter.Fill(this.ysaDataSet.склад_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.календарь_поступления_борд". При необходимости она может быть перемещена или удалена.
            this.календарь_поступления_бордTableAdapter.Fill(this.ysaDataSet.календарь_поступления_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.список_борд". При необходимости она может быть перемещена или удалена.
            this.список_бордTableAdapter.Fill(this.ysaDataSet.список_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.ysaDataSet.заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказ_борд". При необходимости она может быть перемещена или удалена.
            this.заказ_бордTableAdapter.Fill(this.ysaDataSet.заказ_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.ysaDataSet.заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.список_борд". При необходимости она может быть перемещена или удалена.
            this.список_бордTableAdapter.Fill(this.ysaDataSet.список_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.календарь_поступления_борд". При необходимости она может быть перемещена или удалена.
            this.календарь_поступления_бордTableAdapter.Fill(this.ysaDataSet.календарь_поступления_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.склад_борд". При необходимости она может быть перемещена или удалена.
            this.склад_бордTableAdapter.Fill(this.ysaDataSet.склад_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказ_борд". При необходимости она может быть перемещена или удалена.
            this.заказ_бордTableAdapter.Fill(this.ysaDataSet.заказ_борд);

            sortmode();

            connection.Open();
            ComboIns();

            дата_заключенияDateTimePicker.Value = DateTime.Now;
            ДатаdateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            датаDateTimePicker.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
        }

        private void календарь_поступления_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void список_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_бордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void addList_Click(object sender, EventArgs e)
        {
            string sql = $@"INSERT INTO список_борд (Название_борд , Цвет)
                            VALUES('{название_бордTextBox.Text}' , '{цветTextBox.Text}')";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    label1.Visible = true;
                    label1.Text = "Успешно";
                    название_бордTextBox.Text = "";
                    цветTextBox.Text = "";
                    refList_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label1.Visible = true;
                label1.Text = ex.ToString() + "Ошибка";
            }
            addComboInsListBord();
        }
        public void refList_Click(object sender, EventArgs e)
        {
            Clear(список_бордDataGridView);
            string reff = $@"SELECT * FROM список_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "список_борд");
            список_бордDataGridView.DataSource = ysaDataSet.Tables["список_борд"];
        }
        public void refOrder_Click(object sender, EventArgs e)
        {
            Clear(заказ_бордDataGridView);
            string reff = $@"SELECT * FROM заказ_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "заказ_борд");
            заказ_бордDataGridView.DataSource = ysaDataSet.Tables["заказ_борд"];
        }
        public void refWarehouse_Click(object sender, EventArgs e)
        {
            Clear(склад_бордDataGridView);
            string reff = $@"SELECT * FROM склад_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "склад_борд");
            склад_бордDataGridView.DataSource = ysaDataSet.Tables["склад_борд"];
        }
        public void refCell_Click(object sender, EventArgs e)
        {
            Clear(продажа_бордDataGridView);
            string reff = $@"SELECT * FROM продажа_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "продажа_борд");
            продажа_бордDataGridView.DataSource = ysaDataSet.Tables["продажа_борд"];
        }
        public void refCal_Click(object sender, EventArgs e)
        {
            Clear(календарь_поступления_бордDataGridView);
            string reff = $@"SELECT * FROM календарь_поступления_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "календарь_поступления_борд");
            календарь_поступления_бордDataGridView.DataSource = ysaDataSet.Tables["календарь_поступления_борд"];
        }
        public void refOrd_Click(object sender, EventArgs e)
        {
            Clear(заказчикиDataGridView);
            string reff = $@"SELECT * FROM заказчики";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "заказчики");
            заказчикиDataGridView.DataSource = ysaDataSet.Tables["заказчики"];
        }
        public void refOTZB_Click(object sender, EventArgs e)
        {
            Clear(отгрузки_бордDataGridView);
            string reff = $@"SELECT * FROM отгрузки_борд";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(reff, connection);
            dataAdapter.Fill(ysaDataSet, "отгрузки_борд");
            отгрузки_бордDataGridView.DataSource = ysaDataSet.Tables["отгрузки_борд"];
        }



        public void Clear(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 1)
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear(список_бордDataGridView);
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            string theDate = дата_заключенияDateTimePicker.Value.ToShortDateString();
            string sql = $@"INSERT INTO заказ_борд (Заказчик , Название , Количество , Остаток , Цвет , Дата_заключения)
                            VALUES('{заказчикComboBox.Text}' , '{названиеComboBox.Text}' 
                                    , '{количествоTextBox1.Text}' , '{количествоTextBox1.Text}' , '{цветComboBox1.Text}' , 
                                    '" + дата_заключенияDateTimePicker.Value.ToString("yyyy-MM-dd") + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);

            string sql1 = $@"UPDATE склад_борд 
                                SET В_заказах = В_заказах + '{Convert.ToInt32(количествоTextBox1.Text)}'
                                WHERE Название_борд = '{названиеComboBox.Text}'" +
                                    $@"AND Цвет = '{цветComboBox1.Text}'";
            MySqlCommand command1 = new MySqlCommand(sql1, connection);

            string sql2 = $@"UPDATE склад_борд 
                                SET Свободная_продажа = Количество - В_заказах
                                WHERE Название_борд = '{названиеComboBox.Text}'" +
                                    $@"AND Цвет = '{цветComboBox1.Text}'";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);


            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    label2.Visible = true;
                    label2.Text = "Успешно";
                    заказчикComboBox.Text = "";
                    названиеComboBox.Text = "";
                    количествоTextBox1.Text = "";
                    цветComboBox1.Text = "";
                    refOrder_Click(sender, e);

                    try
                    {
                        if (command1.ExecuteNonQuery() > 0)
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            заказчикComboBox.Text = "";
                            названиеComboBox.Text = "";
                            количествоTextBox1.Text = "";
                            цветComboBox1.Text = "";
                            refWarehouse_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Visible = true;
                        label2.Text = ex.ToString() + "Ошибка";
                        MessageBox.Show(ex.ToString());
                    }

                    try
                    {
                        if (command2.ExecuteNonQuery() > 0)
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            заказчикComboBox.Text = "";
                            названиеComboBox.Text = "";
                            количествоTextBox1.Text = "";
                            цветComboBox1.Text = "";
                            refWarehouse_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Visible = true;
                        label2.Text = ex.ToString() + "Ошибка";
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {
                label2.Visible = true;
                label2.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }

            

            sortmode();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void заказ_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить заказ?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    заказ_бордDataGridView.Columns[6].DefaultCellStyle.Format = "yyyy/MM/dd";
                    int n = e.RowIndex;
                    string query = $@"DELETE FROM заказ_борд WHERE код_заказа = '{заказ_бордDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Заказчик = '{заказ_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                   $@"AND Название = '{заказ_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                   $@"AND Количество = '{заказ_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'" +
                                   $@"AND Остаток = '{заказ_бордDataGridView.Rows[n].Cells[4].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{заказ_бордDataGridView.Rows[n].Cells[5].FormattedValue.ToString()}'" +
                                   $@"AND Дата_заключения = '{заказ_бордDataGridView.Rows[n].Cells[6].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);


                    string sql = $@"UPDATE склад_борд
                                SET В_заказах = В_заказах - '{заказ_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}',
                                    Свободная_продажа = Количество - В_заказах
                                WHERE Название_борд = '{заказ_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                            $@"AND Цвет = '{заказ_бордDataGridView.Rows[n].Cells[5].FormattedValue.ToString()}'";
                    MySqlCommand com_sql = new MySqlCommand(sql, connection);



                    if (com_sql.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            Clear(заказ_бордDataGridView);
                            refOrder_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }

                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            Clear(заказ_бордDataGridView);
                            refOrder_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                    заказ_бордDataGridView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                    sortmode();
                }
                    
                else if (dialogResult == DialogResult.No)
                {

                }

            else
                {
                    //Form f2 = new RedOrdersV2();
                    //f2.Show();
                    //MessageBox.Show("Возможность временно выключена");
                }

            заказ_бордDataGridView.Sort(заказ_бордDataGridView.Columns[0], ListSortDirection.Descending);
            }
            


        }
        //todo
        private void addDateinBord_Click(object sender, EventArgs e)
        {
            string theDate = ДатаdateTimePicker1.Value.ToShortDateString();
            string sql = $@"INSERT INTO календарь_поступления_борд (Название , Цвет , Количество, Date)
                            VALUES('{comboBox2.Text}' , '{comboBox3.Text}' , '{количествоTextBox.Text}','" + ДатаdateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";

            //Обновление в складе

            string sql1 = $@"SELECT Количество FROM склад_борд WHERE '{comboBox2.Text}'";
            string sql2 = $@"SELECT Свободная_продажа FROM склад_борд WHERE '{comboBox2.Text}'";
            string sql3 = $@"UPDATE склад_борд 
                                SET Количество = Количество + '{Convert.ToInt32(количествоTextBox.Text)}',
                                Свободная_продажа = Свободная_продажа + '{Convert.ToInt32(количествоTextBox.Text)}'
                                WHERE Название_борд = '{comboBox2.Text}'" +
                                      $@"AND Цвет = '{comboBox3.Text}'";
            MySqlCommand com_sql1 = new MySqlCommand(sql1, connection);
            MySqlCommand com_sql2 = new MySqlCommand(sql2, connection);
            MySqlCommand com_sql3 = new MySqlCommand(sql3, connection);
            try
            {
                if (com_sql2.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                    label4.Text = "Успешно";
                    refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label4.Visible = true;
                label4.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
            try
            {
                if (com_sql3.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                    label4.Text = "Успешно";
                    refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label4.Visible = true;
                label4.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
            MySqlCommand command = new MySqlCommand(sql, connection);

            //Добавление записи в Производство
            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    label5.Visible = true;
                    label5.Text = "Успешно";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    количествоTextBox.Text = "";
                    refCal_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label5.Visible = true;
                label5.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
            sortmode();

        }
        private void заказ_бордBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.заказбордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void заказ_бордBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.заказбордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void календарь_поступления_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись производства?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int n = e.RowIndex;
                    календарь_поступления_бордDataGridView.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd";
                    string sql1 = $@"UPDATE склад_борд 
                                SET Количество = Количество - '{календарь_поступления_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}',
                                Свободная_продажа = Свободная_продажа - '{календарь_поступления_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'
                                WHERE Название_борд = '{календарь_поступления_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                              $@"AND Цвет = '{календарь_поступления_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'";
                    MySqlCommand com_sql1 = new MySqlCommand(sql1, connection);
                    if (com_sql1.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(склад_бордDataGridView);
                            refWarehouse_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }




                    string query = $@"DELETE FROM календарь_поступления_борд WHERE Date = '{календарь_поступления_бордDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Название = '{календарь_поступления_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{календарь_поступления_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                   $@"AND Количество = '{календарь_поступления_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(календарь_поступления_бордDataGridView);
                            refCal_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            календарь_поступления_бордDataGridView.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            sortmode();

        }

        private void addORDBORD_Click(object sender, EventArgs e)
        {
            string sql = $@"INSERT INTO заказчики ( Имя , Контактные_данные)
                            VALUES('{имяTextBox.Text}' , '{контактные_данныеTextBox.Text}')";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    label3.Visible = true;
                    label3.Text = "Успешно";
                    имяTextBox.Text = "";
                    контактные_данныеTextBox.Text = "";
                    refOrd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label3.Visible = true;
                label3.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
            ComobInsORDERGB();
        }

        private void заказчикиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить заказчика?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int n = e.RowIndex;
                    string query = $@"DELETE FROM заказчики WHERE Имя = '{заказчикиDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Контактные_данные = '{заказчикиDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(заказчикиDataGridView);
                            refOrd_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }

        private void заказ_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void addWarebord_Click(object sender, EventArgs e)
        {
            string sql = $@"INSERT INTO склад_борд ( Название_борд, Цвет , Количество , Свободная_продажа , В_заказах)
                            VALUES('{comboBox1.Text}' , '{comboBox4.Text}' , '{количествоTextBox2.Text}', '{свободная_продажаTextBox.Text}' 
                                    , '{в_заказахTextBox.Text}')";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    label4.Visible = true;
                    label4.Text = "Успешно";
                    количествоTextBox2.Text = "";
                    comboBox4.Text = "";
                    свободная_продажаTextBox.Text = "";
                    в_заказахTextBox.Text = "";
                    refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label4.Visible = true;
                label4.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
        }

        private void склад_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить бордюр со склада?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    int n = e.RowIndex;
                    string query = $@"DELETE FROM склад_борд WHERE Название_борд = '{склад_бордDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{склад_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                   $@"AND Количество = '{склад_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                   $@"AND Свободная_продажа = '{склад_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'" +
                                   $@"AND В_заказах = '{склад_бордDataGridView.Rows[n].Cells[4].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label4.Visible = true;
                            label4.Text = "Успешное удаление";
                            Clear(склад_бордDataGridView);
                            refWarehouse_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label4.Visible = true;
                            label4.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        //Вывод цвета в комбо
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboInsOrd();
        }
        private void список_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить бордюр из списка?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int n = e.RowIndex;
                    string query = $@"DELETE FROM список_борд WHERE Название_борд = '{список_бордDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{список_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label1.Visible = true;
                            label1.Text = "Успешное удаление";
                            Clear(список_бордDataGridView);
                            refList_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label1.Visible = true;
                            label1.Text = ex.ToString() + "Error!";
                        }
                    }
                }

                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Int32 newProdID = 0;
            string sql1 = $@"SELECT Количество FROM склад_борд WHERE Название_борд = '{comboBuy.Text}'";
            MySqlCommand com_idSql1 = new MySqlCommand(sql1, connection);
            newProdID = (Int32)com_idSql1.ExecuteScalar();
            if (newProdID >= Convert.ToInt32(КоличествоBuy.Text))
            {
                string sql2 = $@"UPDATE склад_борд 
                                SET Количество = Количество - '{Convert.ToInt32(КоличествоBuy.Text)}',
                                Свободная_продажа = Свободная_продажа - '{Convert.ToInt32(КоличествоBuy.Text)}'
                                WHERE Название_борд = '{comboBuy.Text}'" +
                                      $@"AND Цвет = '{comboBox5.Text}'";
                MySqlCommand com_idSql2 = new MySqlCommand(sql2, connection);

                string sql3 = $@"INSERT INTO продажа_борд (Название_борд, Цвет, Количество, Дата)
                            VALUES('{comboBuy.Text}','{comboBox5.Text}','{КоличествоBuy.Text}', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";
                MySqlCommand com_idSql3 = new MySqlCommand(sql3, connection);

                try
                {
                    if (com_idSql1.ExecuteNonQuery() > 0)
                    {
                        label4.Visible = true;
                        label4.Text = "Успешно";
                        refWarehouse_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    label4.Visible = true;
                    label4.Text = ex.ToString() + "Ошибка";
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    if (com_idSql2.ExecuteNonQuery() > 0)
                    {
                        label4.Visible = true;
                        label4.Text = "Успешно";
                        refWarehouse_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    label4.Visible = true;
                    label4.Text = ex.ToString() + "Ошибка";
                    MessageBox.Show(ex.ToString());
                }
                Clear(склад_бордDataGridView);
                refWarehouse_Click(sender, e);

                try
                {
                    if (com_idSql3.ExecuteNonQuery() > 0)
                    {
                        label4.Visible = true;
                        label4.Text = "Успешно";
                        refCell_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    label4.Visible = true;
                    label4.Text = ex.ToString() + "Ошибка";
                    MessageBox.Show(ex.ToString());
                }
                Clear(продажа_бордDataGridView);
                refCell_Click(sender, e);
            }
            else
            {
                MessageBox.Show("На складе нет такого количества");
            }
            sortmode();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboInsWare();
        }

        private void comboBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboInsWareBuy();
        }

        private void продажа_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись продажи?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    продажа_бордDataGridView.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd";
                    int n = e.RowIndex;
                    string query = $@"DELETE FROM продажа_борд WHERE Дата = '{продажа_бордDataGridView.Rows[n].Cells[0].FormattedValue.ToString()}'" +
                                   $@"AND Название_борд = '{продажа_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{продажа_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                   $@"AND Количество = '{продажа_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    string sql = $@"UPDATE склад_борд 
                                SET Количество = Количество + '{продажа_бордDataGridView.Rows[n].Cells[3].FormattedValue}',
                                Свободная_продажа = Свободная_продажа + '{продажа_бордDataGridView.Rows[n].Cells[3].FormattedValue}'
                                WHERE Название_борд = '{продажа_бордDataGridView.Rows[n].Cells[1].FormattedValue}'" +
                                          $@"AND Цвет = '{продажа_бордDataGridView.Rows[n].Cells[2].FormattedValue}'";
                    MySqlCommand com_idSql = new MySqlCommand(sql, connection);


                    if (command.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(продажа_бордDataGridView);
                            refCell_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                    if (com_idSql.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(склад_бордDataGridView);
                            refWarehouse_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            продажа_бордDataGridView.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            sortmode();
        }

        private void applyOTZB_Click(object sender, EventArgs e)
        {
            ////////////////Решение проблемы с датой в базу
            string sql = $@"INSERT INTO отгрузки_борд (Код_Заказа, Заказчик, Название_борд, Цвет, Количество, Дата)
                            VALUES('{код_заказаTextBox.Text}','{заказчикTextBox.Text}','{название_бордTextBox1.Text}'
                                    ,'{цветTextBox1.Text}', '{количествоTextBox3.Text}', ' " + датаDateTimePicker.Value.ToString("yyyy-MM-dd") + "')";
            MySqlCommand com_idSql = new MySqlCommand(sql, connection);

            string sql2 = $@"UPDATE заказ_борд
                                SET Остаток = Остаток - '{Convert.ToInt32(количествоTextBox3.Text)}'
                                WHERE Заказчик = '{заказчикTextBox.Text}'" +
                                    $@"AND Название = '{название_бордTextBox1.Text}'" +
                                    $@"AND Цвет = '{цветTextBox1.Text}'" +
                                    $@"AND (Остаток - '{Convert.ToInt32(количествоTextBox3.Text)}') >= 0";
            MySqlCommand com_idSql2 = new MySqlCommand(sql2, connection);

            string sql3 = $@"UPDATE склад_борд
                                SET Количество = Количество - '{Convert.ToInt32(количествоTextBox3.Text)}',
                                    В_заказах = В_заказах - '{Convert.ToInt32(количествоTextBox3.Text)}'
                                WHERE Название_борд = '{название_бордTextBox1.Text}'" +
                                    $@"AND Цвет = '{цветTextBox1.Text}'";
            MySqlCommand com_idSql3 = new MySqlCommand(sql3, connection);


           
            
            if (com_idSql2.ExecuteNonQuery() > 0)
            {
                try
                {
                    label12.Visible = true;
                    label12.Text = "Успешно!";
                    Clear(заказ_бордDataGridView);
                    refOrder_Click(sender, e);

                    if (com_idSql3.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label12.Visible = true;
                            label12.Text = "Успешно!";
                            Clear(склад_бордDataGridView);
                            refWarehouse_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label12.Visible = true;
                            label12.Text = ex.ToString() + "Error!";
                        }
                    }

                    if (com_idSql.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label12.Visible = true;
                            label12.Text = "Успешно!";

                            refOTZB_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label12.Visible = true;
                            label12.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    label12.Visible = true;
                    label12.Text = ex.ToString() + "Error!";
                }
            }
            else
            {
                MessageBox.Show("Отгрузка превышает остаток заказа");
            }

            
            sortmode();
        }

        public void отгрузки_бордDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись отгрузки заказа?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int n = e.RowIndex;
                    string sql = $@"UPDATE заказ_борд 
                                SET Остаток = Остаток + '{Convert.ToInt32(отгрузки_бордDataGridView.Rows[n].Cells[4].FormattedValue)}'
                                WHERE код_заказа = '{отгрузки_бордDataGridView.Rows[n].Cells[0].FormattedValue}'";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            заказчикComboBox.Text = "";
                            названиеComboBox.Text = "";
                            количествоTextBox1.Text = "";
                            цветComboBox1.Text = "";
                            Clear(заказ_бордDataGridView);
                            refOrder_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Visible = true;
                        label2.Text = ex.ToString() + "Ошибка";
                        MessageBox.Show(ex.ToString());
                    }


                    string sql1 = $@"UPDATE склад_борд 
                                SET В_заказах = В_заказах + '{Convert.ToInt32(отгрузки_бордDataGridView.Rows[n].Cells[4].FormattedValue)}', 
                                    Количество = Количество + '{Convert.ToInt32(отгрузки_бордDataGridView.Rows[n].Cells[4].FormattedValue)}'
                                WHERE Название_борд = '{отгрузки_бордDataGridView.Rows[n].Cells[2].FormattedValue}'" +
                                    $@"AND Цвет = '{отгрузки_бордDataGridView.Rows[n].Cells[3].FormattedValue}'";
                    MySqlCommand command1 = new MySqlCommand(sql1, connection);

                    try
                    {
                        if (command1.ExecuteNonQuery() > 0)
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно";
                            Clear(заказ_бордDataGridView);
                            Clear(склад_бордDataGridView);
                            refOrder_Click(sender, e);
                            refWarehouse_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Visible = true;
                        label2.Text = ex.ToString() + "Ошибка";
                        MessageBox.Show(ex.ToString());
                    }

                    отгрузки_бордDataGridView.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";

                    string query = $@"DELETE FROM отгрузки_борд WHERE Код_заказа = '{отгрузки_бордDataGridView.Rows[n].Cells[0].FormattedValue}'" +
                                   $@"AND Заказчик = '{отгрузки_бордDataGridView.Rows[n].Cells[1].FormattedValue.ToString()}'" +
                                   $@"AND Название_борд = '{отгрузки_бордDataGridView.Rows[n].Cells[2].FormattedValue.ToString()}'" +
                                   $@"AND Цвет = '{отгрузки_бордDataGridView.Rows[n].Cells[3].FormattedValue.ToString()}'" +
                                   $@"AND Количество = '{отгрузки_бордDataGridView.Rows[n].Cells[4].FormattedValue.ToString()}'" +
                                   $@"AND Дата = '{отгрузки_бордDataGridView.Rows[n].Cells[5].FormattedValue.ToString()} '";
                    MySqlCommand command2 = new MySqlCommand(query, connection);
                    if (command2.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            label2.Visible = true;
                            label2.Text = "Успешно!";
                            Clear(отгрузки_бордDataGridView);
                            refOTZB_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            label2.Visible = true;
                            label2.Text = ex.ToString() + "Error!";
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            отгрузки_бордDataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyy";
            sortmode();
        }

        //private void ComboInsOrderGB1(object sender, EventArgs e)
        //{
        //    ComboInsOrderGB1();
        //}

        private void названиеComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboInsOrderGB2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f2 = new RedOrdersV2();
            f2.Show();
            //MessageBox.Show("Возможность временно выключена");
        }



        public void код_заказаTextBox_TextChanged(object sender, EventArgs e)
        {
            string sql = $@"SELECT Заказчик, Название, Цвет FROM заказ_борд WHERE код_заказа = '{код_заказаTextBox.Text}'";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                заказчикTextBox.Text = reader[0].ToString();
                название_бордTextBox1.Text = reader[1].ToString();
                цветTextBox1.Text = reader[2].ToString();
            }
            reader.Close();
            

        }

        public void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("sp_test", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    label2.Visible = true;
                    label2.Text = "Успешно";
                    refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label2.Visible = true;
                label2.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }


            string sql2 = $@"UPDATE склад_борд 
                                SET Свободная_продажа = Количество - В_заказах";
            MySqlCommand command2 = new MySqlCommand(sql2, connection);

            try
            {
                if (command2.ExecuteNonQuery() > 0)
                {
                    label2.Visible = true;
                    label2.Text = "Успешно";
                    refWarehouse_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                label2.Visible = true;
                label2.Text = ex.ToString() + "Ошибка";
                MessageBox.Show(ex.ToString());
            }
        }

        private void обновитьВсеТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refList_Click(sender, e);
            refOrder_Click(sender, e);
            refWarehouse_Click(sender, e);
            refCell_Click(sender, e);
            refCal_Click(sender, e);
            refOrd_Click(sender, e);
            refOTZB_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f2 = new RedWare();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //TODO: подтверждение

            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (comboBox6.Text != "")
                {
                    string sql = $@"SELECT Код_заказа, Заказчик, Название_борд, Цвет, Количество, Дата FROM отгрузки_борд WHERE Заказчик = '{comboBox6.Text}'";
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    sqladapter.Fill(ds);
                    отгрузки_бордDataGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    refOTZB_Click(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox6.Text = "";
            refOTZB_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (dateTimePicker5.Enabled == true )
            {
                string sql = $@"SELECT Дата, Название_борд, Цвет, Количество FROM продажа_борд 
                        WHERE Дата BETWEEN '" + dateTimePicker5.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker4.Value.ToString("yyyy-MM-dd") + "'";
                MySqlDataAdapter sqladapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                sqladapter.Fill(ds);
                продажа_бордDataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                refCell_Click(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            refCell_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (dateTimePicker2.Enabled == true)
            {
                string sql = $@"SELECT Date, Название, Цвет, Количество FROM календарь_поступления_борд WHERE Название = '{comboBox8.Text}'" +
                                    $@"AND Date BETWEEN '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'";
                MySqlDataAdapter sqladapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                try
                {
                    sqladapter.Fill(ds);
                    календарь_поступления_бордDataGridView.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            else
            {
                if (comboBox8.Text != "")
                {
                    string sql = $@"SELECT Date, Название, Цвет, Количество FROM календарь_поступления_борд WHERE Название = '{comboBox8.Text}'";
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    try
                    {
                        sqladapter.Fill(ds);
                        календарь_поступления_бордDataGridView.DataSource = ds.Tables[0];
                    }
                    catch
                    { 
                        MessageBox.Show("Ошибка");
                    }
                }
                else
                {
                    refCal_Click(sender, e);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox8.Text = "";
            checkBox1.Checked = false;
            refCal_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
                if (comboBox9.Text != "")
                {
                    string sql = $@"SELECT код_заказа, Заказчик, Название, Количество, Остаток, Цвет, Дата_заключения FROM заказ_борд WHERE Заказчик = '{comboBox9.Text}'";
                    MySqlDataAdapter sqladapter = new MySqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    sqladapter.Fill(ds);
                    заказ_бордDataGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    refOrder_Click(sender, e);
                }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox9.Text = "";
            refOrder_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new DeleteWarehouse();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form f = new sortbord3();
            f.Show();
        }





        //private void заказ_бордDataGridView_SelectionChanged(object sender, EventArgs e)
        //{

        //    var senderGrid = (DataGridView)sender;        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //    e.RowIndex >= 0)
        //    {
        //        RedOrders RedOrd = new RedOrders();
        //        RedOrd.код_заказаTextBox.Text = Convert.ToString(заказ_бордDataGridView.CurrentRow.Cells[0].Value);
        //        RedOrd.заказчикTextBox.Text = Convert.ToString(this.заказ_бордDataGridView.CurrentRow.Cells[1].Value);
        //        RedOrd.названиеTextBox.Text = Convert.ToString(this.заказ_бордDataGridView.CurrentRow.Cells[2].Value);
        //        RedOrd.количествоTextBox.Text = Convert.ToString(this.заказ_бордDataGridView.CurrentRow.Cells[3].Value);
        //        RedOrd.остатокTextBox.Text = Convert.ToString(this.заказ_бордDataGridView.CurrentRow.Cells[4].Value);
        //        RedOrd.цветTextBox.Text = Convert.ToString(this.заказ_бордDataGridView.CurrentRow.Cells[5].Value);
        //    }
        //}
    }
}


