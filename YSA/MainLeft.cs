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
    public partial class MainLeft : Form
    {
        public MainLeft()
        {
            InitializeComponent();
        }

        private void заказ_бордBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказ_бордBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ysaDataSet);

        }

        private void MainLeft_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.список_борд". При необходимости она может быть перемещена или удалена.
            this.список_бордTableAdapter.Fill(this.ysaDataSet.список_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.склад_борд". При необходимости она может быть перемещена или удалена.
            this.склад_бордTableAdapter.Fill(this.ysaDataSet.склад_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.продажа_борд". При необходимости она может быть перемещена или удалена.
            this.продажа_бордTableAdapter.Fill(this.ysaDataSet.продажа_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.отгрузки_борд". При необходимости она может быть перемещена или удалена.
            this.отгрузки_бордTableAdapter.Fill(this.ysaDataSet.отгрузки_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.календарь_поступления_борд". При необходимости она может быть перемещена или удалена.
            this.календарь_поступления_бордTableAdapter.Fill(this.ysaDataSet.календарь_поступления_борд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказчики". При необходимости она может быть перемещена или удалена.
            this.заказчикиTableAdapter.Fill(this.ysaDataSet.заказчики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ysaDataSet.заказ_борд". При необходимости она может быть перемещена или удалена.
            this.заказ_бордTableAdapter.Fill(this.ysaDataSet.заказ_борд);




            заказ_бордDataGridView.Sort(заказ_бордDataGridView.Columns[0], ListSortDirection.Descending);
            календарь_поступления_бордDataGridView.Sort(календарь_поступления_бордDataGridView.Columns[0], ListSortDirection.Descending);
            продажа_бордDataGridView.Sort(продажа_бордDataGridView.Columns[0], ListSortDirection.Descending);
            отгрузки_бордDataGridView.Sort(отгрузки_бордDataGridView.Columns[5], ListSortDirection.Descending);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void обновитьВсеТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.refList_Click(sender, e);
            f.refOrder_Click(sender, e);
            f.refWarehouse_Click(sender, e);
            f.refCell_Click(sender, e);
            f.refCal_Click(sender, e);
            f.refOrd_Click(sender, e);
            f.refOTZB_Click(sender, e);
        }

        private void MainLeft_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
