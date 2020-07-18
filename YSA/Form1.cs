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
