using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.ComponentModel;
using System.Data;

namespace YSA
{
    public partial class Main
    {
        public void ComboIns()
        {
            string sql_idListBord = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idListBord = new MySqlCommand(sql_idListBord, connection);
            MySqlDataReader reader_idListBord = com_idListBord.ExecuteReader();
            while (reader_idListBord.Read())
            {
                названиеComboBox.Items.Add(reader_idListBord[0].ToString());
            }
            reader_idListBord.Close();

            string sql_idcellins = "SELECT DISTINCT Название_борд FROM склад_борд ";
            MySqlCommand com_idcellins = new MySqlCommand(sql_idcellins, connection);
            MySqlDataReader reader_idcellins = com_idcellins.ExecuteReader();
            while (reader_idcellins.Read())
            {
                comboBuy.Items.Add(reader_idcellins[0].ToString());
            }
            reader_idcellins.Close();


            string sql_idwareBord = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idwareBord = new MySqlCommand(sql_idwareBord, connection);
            MySqlDataReader reader_idwareBord = com_idwareBord.ExecuteReader();

            while (reader_idwareBord.Read())
            {
                comboBox1.Items.Add(reader_idwareBord[0].ToString());
            }
            reader_idwareBord.Close();

            string sql_idDateIn = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idDateIn = new MySqlCommand(sql_idDateIn, connection);
            MySqlDataReader reader_idDateIn = com_idDateIn.ExecuteReader();
            while (reader_idDateIn.Read())
            {
                comboBox2.Items.Add(reader_idDateIn[0].ToString());
            }
            reader_idDateIn.Close();

            string sql_idOrd = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBox2.Text}' ";
            MySqlCommand com_idOrd = new MySqlCommand(sql_idOrd, connection);
            MySqlDataReader reader_idOrd = com_idOrd.ExecuteReader();
            while (reader_idOrd.Read())
            {
                comboBox3.Items.Add(reader_idOrd[0].ToString());
            }
            reader_idOrd.Close();

            string sql_idWareBuy = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBuy.Text}' ";
            MySqlCommand com_idWareBuy = new MySqlCommand(sql_idWareBuy, connection);
            MySqlDataReader reader_idWareBuy = com_idWareBuy.ExecuteReader();
            while (reader_idWareBuy.Read())
            {
                comboBox5.Items.Add(reader_idWareBuy[0].ToString());
            }
            reader_idWareBuy.Close();

            string sql_idWare = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBox1.Text}' ";
            MySqlCommand com_idWare = new MySqlCommand(sql_idWare, connection);
            MySqlDataReader reader_idWare = com_idWare.ExecuteReader();
            while (reader_idWare.Read())
            {
                comboBox4.Items.Add(reader_idWare[0].ToString());
            }
            reader_idWare.Close();

            //string sql_idOTZB = $@"SELECT DISTINCT Имя FROM заказчики";
            //MySqlCommand com_idOTZB = new MySqlCommand(sql_idOTZB, connection);
            //MySqlDataReader reader_idOTZB = com_idOTZB.ExecuteReader();
            //while (reader_idOTZB.Read())
            //{
            //    заказчикComboBox1.Items.Add(reader_idOTZB[0].ToString());
            //}
            //reader_idOTZB.Close();

            string sql_idORDERGB = $@"SELECT DISTINCT Имя FROM заказчики";
            MySqlCommand com_idORDERGB = new MySqlCommand(sql_idORDERGB, connection);
            MySqlDataReader reader_idORDERGB = com_idORDERGB.ExecuteReader();
            while (reader_idORDERGB.Read())
            {
                заказчикComboBox.Items.Add(reader_idORDERGB[0].ToString());
            }
            reader_idORDERGB.Close();

            //string sql_idORDERG1 = $@"SELECT DISTINCT Название_борд FROM список_борд";
            //MySqlCommand com_idORDERG1 = new MySqlCommand(sql_idORDERG1, connection);
            //MySqlDataReader reader_idORDERG1 = com_idORDERG1.ExecuteReader();
            //while (reader_idORDERG1.Read())
            //{
            //    название_бордComboBox.Items.Add(reader_idORDERG1[0].ToString());
            //}
            //reader_idORDERG1.Close();

            ComboFormOrd();
            ComboFormCell();
            ComboFormCal();
            ComboFormOrders();
        }
        public void addComboInsListBord()
        {

            //comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //comboBox3.Items.Clear();
            //comboBox4.Items.Clear();
            //comboBox5.Items.Clear();
            //comboBuy.Items.Clear();
            //названиеComboBox.Items.Clear();

            // Заполнение Комбо
            string sql_idListBord = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idListBord = new MySqlCommand(sql_idListBord, connection);
            MySqlDataReader reader_idListBord = com_idListBord.ExecuteReader();
            названиеComboBox.Items.Clear();
            comboBuy.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            while (reader_idListBord.Read())
            {
                названиеComboBox.Items.Add(reader_idListBord[0].ToString());
                comboBuy.Items.Add(reader_idListBord[0].ToString());
                comboBox1.Items.Add(reader_idListBord[0].ToString());
                comboBox2.Items.Add(reader_idListBord[0].ToString());
            }
            reader_idListBord.Close();
        }
        public void ComboInsListBord()
        {
            //comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //comboBox3.Items.Clear();
            //comboBox4.Items.Clear();
            //comboBox5.Items.Clear();
            //comboBuy.Items.Clear();
            //названиеComboBox.Items.Clear();

            // Заполнение Комбо
            string sql_idListBord = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBox2.Text}' ";
            MySqlCommand com_idListBord = new MySqlCommand(sql_idListBord, connection);
            MySqlDataReader reader_idListBord = com_idListBord.ExecuteReader();
            while (reader_idListBord.Read())
            {
                названиеComboBox.Items.Add(reader_idListBord[0].ToString());
                comboBuy.Items.Add(reader_idListBord[0].ToString());
                comboBox1.Items.Add(reader_idListBord[0].ToString());
                comboBox2.Items.Add(reader_idListBord[0].ToString());
            }
            reader_idListBord.Close();
        }
        public void ComboInswareBord() 
        {
            string sql_idwareBord = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idwareBord = new MySqlCommand(sql_idwareBord, connection);
            MySqlDataReader reader_idwareBord = com_idwareBord.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader_idwareBord.Read())
            {
                comboBox1.Items.Add(reader_idwareBord[0].ToString());
            }
            reader_idwareBord.Close();
        }
        public void ComboInsDateIn()
        {
            string sql_idDateIn = "SELECT DISTINCT Название_борд FROM список_борд ";
            MySqlCommand com_idDateIn = new MySqlCommand(sql_idDateIn, connection);
            MySqlDataReader reader_idDateIn = com_idDateIn.ExecuteReader();
            comboBox2.Items.Clear();
            while (reader_idDateIn.Read())
            {
                comboBox2.Items.Add(reader_idDateIn[0].ToString());
            }
            reader_idDateIn.Close();
        }
        public void ComboInsOrd()
        {
            string sql_idOrd = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{comboBox2.Text}' ";
            MySqlCommand com_idOrd = new MySqlCommand(sql_idOrd, connection);
            MySqlDataReader reader_idOrd = com_idOrd.ExecuteReader();
            comboBox3.Items.Clear();
            while (reader_idOrd.Read())
            {
                comboBox3.Items.Add(reader_idOrd[0].ToString());
            }
            reader_idOrd.Close();
        }
        public void ComboInsWare()
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
        public void ComboInsWareBuy()
        { 
            string sql_idWareBuy = $@"SELECT DISTINCT Цвет FROM склад_борд WHERE Название_борд = '{comboBuy.Text}' ";
            MySqlCommand com_idWareBuy = new MySqlCommand(sql_idWareBuy, connection);
            MySqlDataReader reader_idWareBuy = com_idWareBuy.ExecuteReader();
            comboBox5.Items.Clear();
            while (reader_idWareBuy.Read())
            {
                comboBox5.Items.Add(reader_idWareBuy[0].ToString());
            }
            reader_idWareBuy.Close();

        }
        //public void ComboInsOTZB()
        //{
        //    string sql_idWareBuy = $@"SELECT DISTINCT Цвет FROM склад_борд WHERE Название_борд = '{заказчикComboBox1.Text}' ";
        //    MySqlCommand com_idWareBuy = new MySqlCommand(sql_idWareBuy, connection);
        //    MySqlDataReader reader_idWareBuy = com_idWareBuy.ExecuteReader();
        //    comboBox5.Items.Clear();
        //    while (reader_idWareBuy.Read())
        //    {
        //        comboBox5.Items.Add(reader_idWareBuy[0].ToString());
        //    }
        //    reader_idWareBuy.Close();
        //}
        public void ComobInsORDERGB()
        {
            string sql_idORDERGB = $@"SELECT DISTINCT Имя FROM заказчики";
            MySqlCommand com_idORDERGB = new MySqlCommand(sql_idORDERGB, connection);
            MySqlDataReader reader_idORDERGB = com_idORDERGB.ExecuteReader();
            заказчикComboBox.Items.Clear();
            while (reader_idORDERGB.Read())
            {
                заказчикComboBox.Items.Add(reader_idORDERGB[0].ToString());
            }
            reader_idORDERGB.Close();
        }
        //public void ComboInsOrderGB1()
        //{
        //    string sql_idORDERG2 = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{название_бордComboBox.Text}'";
        //    MySqlCommand com_idORDERG2 = new MySqlCommand(sql_idORDERG2, connection);
        //    MySqlDataReader reader_idORDERG2 = com_idORDERG2.ExecuteReader();
        //    цветComboBox.Items.Clear();
        //    while (reader_idORDERG2.Read())
        //    {
        //        цветComboBox.Items.Add(reader_idORDERG2[0].ToString());
        //    }
        //    reader_idORDERG2.Close();
        //}
        public void ComboInsOrderGB2()
        {
            string sql_idORDERG2 = $@"SELECT DISTINCT Цвет FROM список_борд WHERE Название_борд = '{названиеComboBox.Text}'";
            MySqlCommand com_idORDERG2 = new MySqlCommand(sql_idORDERG2, connection);
            MySqlDataReader reader_idORDERG2 = com_idORDERG2.ExecuteReader();
            цветComboBox1.Items.Clear();
            while (reader_idORDERG2.Read())
            {
                цветComboBox1.Items.Add(reader_idORDERG2[0].ToString());
            }
            reader_idORDERG2.Close();
        }
        public void ComboFormOrd()
        {
            string sql = $@"SELECT DISTINCT Имя FROM заказчики";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();
            comboBox6.Items.Clear();
            while (reader.Read())
            {
                comboBox6.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public void ComboFormCell()
        {
            //string sql = $@"SELECT DISTINCT Название_борд FROM склад_борд";
            //MySqlCommand com = new MySqlCommand(sql, connection);
            //MySqlDataReader reader = com.ExecuteReader();
            //comboBox7.Items.Clear();
            //while (reader.Read())
            //{
            //    comboBox7.Items.Add(reader[0].ToString());
            //}
            //reader.Close();
        }
        public void ComboFormCal()
        {
            string sql = $@"SELECT DISTINCT Название_борд FROM склад_борд";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();
            comboBox8.Items.Clear();
            while (reader.Read())
            {
                comboBox8.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        public void ComboFormOrders()
        {
            string sql = $@"SELECT DISTINCT Имя FROM заказчики";
            MySqlCommand com = new MySqlCommand(sql, connection);
            MySqlDataReader reader = com.ExecuteReader();
            comboBox9.Items.Clear();
            while (reader.Read())
            {
                comboBox9.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        
        public void ButtonClear()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBuy.Items.Clear();
            названиеComboBox.Items.Clear();
        }
        public void sortmode()
        {
            заказ_бордDataGridView.Sort(заказ_бордDataGridView.Columns[0], ListSortDirection.Descending);
            календарь_поступления_бордDataGridView.Sort(календарь_поступления_бордDataGridView.Columns[0], ListSortDirection.Descending);
            продажа_бордDataGridView.Sort(продажа_бордDataGridView.Columns[0], ListSortDirection.Descending);
            отгрузки_бордDataGridView.Sort(отгрузки_бордDataGridView.Columns[5], ListSortDirection.Descending);
        }
    }
}
