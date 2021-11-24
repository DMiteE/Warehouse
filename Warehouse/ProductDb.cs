using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class ProductDb
    {
        MySqlConnection connectionProduct = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=prodcut");

        public void openConnetcion()
        {
            if (connectionProduct.State == System.Data.ConnectionState.Closed)
            {

                connectionProduct.Open();
            }
        }
        public void closConnetcion()
        {
            if (connectionProduct.State == System.Data.ConnectionState.Open)
            {

                connectionProduct.Close();
            }
        }
        public MySqlConnection GetConnetcion()
        {

            return connectionProduct;
        }

    }
}
