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

namespace YSA
{
    public partial class Auth : Form
    {
        private const string Conect = @"server=127.0.0.1;user id=root;password = 1234;database=ysa;persistsecurityinfo=True;allowuservariables=True";
                MySqlConnection connection = new MySqlConnection(Conect);
        public Auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                if (password.Text == "")
                {
                    Main f = new Main();
                    f.Show();
                    this.Hide();
                }
            }
            else if (login.Text == "1")
            {
                if (password.Text == "1")
                {
                    MainLeft f = new MainLeft();
                    f.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Неверно введены данные. Попробуйте снова");
            }
        }
    }

    internal class mysqlconnection
    {
        private string conect;

        public mysqlconnection(string conect)
        {
            this.conect = conect;
        }
    }
}
