using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Warehouse
{
    public partial class Box : Form
    {

  
        public Box()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            String name = PnameText.Text;
            String price = PriceText.Text;
            String amoun = AmountText.Text;

            ProductDb databaseP = new ProductDb();
            string comString = "INSERT INTO `boxx` (Name,Amount,Price) VALUES (@Name,@Amount,@Price)";
            MySqlCommand command = new MySqlCommand(comString,databaseP.GetConnetcion());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = PnameText.Text;
            command.Parameters.Add("@Amount", MySqlDbType.VarChar).Value = AmountText.Text;
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = PriceText.Text;

            databaseP.openConnetcion();
            if (command.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("Добавлено");
            }
            else
            {
                MessageBox.Show("Что то не так-_0");
            }


            databaseP.closConnetcion();
            PnameText.Clear();
            AmountText.Clear();
            PriceText.Clear();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Склад_Load(object sender, EventArgs e)
        {

        }

        private void PnameText_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void ProductName2_Click(object sender, EventArgs e)
        {

        }

        private void ProductName3_Click(object sender, EventArgs e)
        {

        }

        private void SearchName_Click(object sender, EventArgs e)
        {

        }

        private void SearchID_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
