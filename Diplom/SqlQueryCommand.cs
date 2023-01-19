using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Diplom
{
    class SqlQueryCommand
    {
        public void QueryForGridFill(DataGridView dataGridView1)  
        {
            Database DB = new Database();
            DataTable Dtable = new DataTable();
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
            MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
            DataAdapter.SelectCommand = MySQLQuery;

            DataAdapter.Fill(Dtable);

            dataGridView1.DataSource = Dtable;
        }
    }
}
