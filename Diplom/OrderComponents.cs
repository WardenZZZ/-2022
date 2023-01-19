using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
    public partial class OrderComponents : Form
    {
        public OrderComponents()
        {
            InitializeComponent();

            Database DB = new Database();
            DB.openConnection();
            switch (Variables.TempVariableN4)
            {
                case "OrderView":
                    this.Text = "Товары в заказе с идентификатором " + Variables.OrderComponentsNumber;

                    Variables.SqlQuery = "SELECT m.mainname AS `Название товара`, od.orderdetailsamount AS `Количество`, od.orderdetailsprice AS `Стоимость` FROM mainbase m, orderdetails od WHERE od.id_order = @idComponent AND od.id_main = m.id_main";

                    MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQuery.Parameters.AddWithValue("@idComponent", Variables.OrderComponentsNumber);
                    DataTable Dtable = new DataTable();
                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                    DataAdapter.SelectCommand = MySQLQuery;
                    DataAdapter.Fill(Dtable);
                    ComponentsDataGrid.DataSource = Dtable;
                    this.Size = new Size(416, 126);
                    break;

                case "OrderHistory":
                    this.Size = new Size(446, 294); 
                    this.Text = "История заказов";

                    Variables.SqlQuery = "SELECT oh.ordernumber AS `Номер заказа`, os.statusname AS `Состояние заказа`, oh.ordercustomercomment AS `Комментарий клиента`, oh.orderdate AS `Дата добавления заказа   ` FROM orderhistory oh, orderstatus os WHERE oh.id_orderstatus = os.id_orderstatus";


                    DB.openConnection();
                    MySqlCommand MySQLQueryHistory = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    DataTable DtableHistory = new DataTable();
                    MySqlDataAdapter DataAdapterHistory = new MySqlDataAdapter();
                    DataAdapterHistory.SelectCommand = MySQLQueryHistory;
                    DataAdapterHistory.Fill(DtableHistory);
                    ComponentsDataGrid.DataSource = DtableHistory;
                    ComponentsDataGrid.RowHeadersVisible = false;
                    break;
            }
            
        }
    }
}
