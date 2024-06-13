using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-yourname\SQLEXPRESS;Initial Catalog=InventoryManagementSystemDB;Integrated Security=True");

        public void openConnection() 
        { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            } 
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}
