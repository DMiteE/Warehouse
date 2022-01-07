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
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Warehouse
{
    public partial class Box : Form
    {
        
        ProductDb databaseP = new ProductDb();
        DataTable dataTable = new DataTable();
        
        public Box()
        {
            InitializeComponent();
        }
      

        private void AddProduct_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            MySqlCommand command = new MySqlCommand("INSERT INTO boxx (Name,Amount,Price) VALUES (@Name,@Amount,@Price)", databaseP.GetConnetcion());
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM boxx", databaseP.GetConnetcion());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = PnameText.Text;
            command.Parameters.Add("@Amount", MySqlDbType.VarChar).Value = AmountText.Text;
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = PriceText.Text;
            databaseP.openConnetcion();
            if (command.ExecuteNonQuery() == 1)
            {
                
                
            }
            else
            {
                MessageBox.Show("Что то не так-_0");
            }

            databaseP.closConnetcion();
            PnameText.Clear();
            AmountText.Clear();
            PriceText.Clear();
            
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
       

        private void Склад_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM boxx", databaseP.GetConnetcion());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Number"].Value);
            MySqlCommand del = new MySqlCommand("Delete from boxx WHERE id = @id", databaseP.GetConnetcion());
            del.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            databaseP.openConnetcion();
            del.ExecuteNonQuery();
            databaseP.closConnetcion();
            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM boxx", databaseP.GetConnetcion());
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        void SaveTable()
        {
          

            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = @"C:\";
            openDlg.ShowDialog();
            string path = openDlg.FileName;

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workBook = excelApp.Workbooks.Add();
                    Excel.Worksheet workSheet = workBook.ActiveSheet;

                    for (int i = 1; i < dataGridView1.RowCount + 1; i++)
                    {
                        for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                        {
                            workSheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                        }
                    }
                    excelApp.AlertBeforeOverwriting = false;
                    workBook.SaveAs(path);
                    workBook.Close();
                }
                catch
                { 
                }
                


            }

        }
    }
}
