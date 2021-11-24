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

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = loginText.Text;
            String pass = passText.Text;

            DataBase database = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @uL AND `pass` = @uP", database.GetConnetcion());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                Box box = new Box();
                box.Show();
            }
            else 
            {
                MessageBox.Show("Неправильный логин или пароль");

            }
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
