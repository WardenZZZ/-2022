using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Diplom
{
    public partial class OrdersMenu : Form
    {

        public OrdersMenu()
        {
            InitializeComponent();
            this.Text = "Меню заказов";


            Variables.SqlQuery = "SELECT o.id_order AS `Идентификатор заказа`, o.ordernumber AS `Номер заказа`, ot.ordertypename AS `Тип заказа`, " +
                "o.orderamount AS `Количество товаров в заказе`, o.ordertotalprice AS `Общая сумма заказа`, o.ordercustomeraddress AS `Адрес клиента`, " +
                "o.orderdataestimation AS `Примерная дата получения заказа` FROM orders o, ordertype ot WHERE ot.id_ordertype = o.id_ordertype";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(OrdersdataGridView1);
        }
        private void OrdersMenu_Activated(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT o.id_order AS `Идентификатор заказа`, o.ordernumber AS `Номер заказа`, ot.ordertypename AS `Тип заказа`, " +
                "o.orderamount AS `Количество товаров в заказе`, o.ordertotalprice AS `Общая сумма заказа`, o.ordercustomeraddress AS `Адрес клиента`, " +
                "o.orderdataestimation AS `Примерная дата получения заказа` FROM orders o, ordertype ot WHERE ot.id_ordertype = o.id_ordertype";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(OrdersdataGridView1);

            OrdersdataGridView1.ClearSelection();
            SearchtextBox.Clear();
            OrdersdataGridView1.MultiSelect = false;
        }


        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            OrdersdataGridView1.ClearSelection();

            if (SearchtextBox.Text != "")
            {
                OrdersdataGridView1.MultiSelect = true;
                int i = 0;
                for (i = 0; i < OrdersdataGridView1.RowCount; i++)
                {
                    OrdersdataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < OrdersdataGridView1.ColumnCount; j++)
                        if (OrdersdataGridView1.Rows[i].Cells[j].Value != null)
                            if (OrdersdataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchtextBox.Text))
                            {
                                OrdersdataGridView1.Rows[i].Cells[j].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                OrdersdataGridView1.MultiSelect = false;
            }
        }
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Variables.TempVariableN4 = "Add";
            Database DB = new Database();

            Random RND = new Random();

            DB.openConnection();

            Variables.TempVariableN1 = Convert.ToString(RND.Next(100000, 999999));

            Variables.SqlQuery = "INSERT INTO `orders` (ordernumber) VALUES (@OrderRandom)";

            MySqlCommand MySQLQueryOrderAdd = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQueryOrderAdd.Parameters.AddWithValue("@OrderRandom", Variables.TempVariableN1);

            MySQLQueryOrderAdd.ExecuteNonQuery();

            AddOrder AddOR = new AddOrder();

            AddOR.ShowDialog();

            DB.closeConnection();

        }
        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            Variables.TempVariableN4 = "Edit";
            int row = OrdersdataGridView1.CurrentRow.Index;
            Database DB = new Database();
            AddOrder AddOR = new AddOrder();
            AddOR.OrderIDTextBox.Text = OrdersdataGridView1[0, row].Value.ToString();
            AddOR.OrderNumberTextBox.Text = OrdersdataGridView1[1, row].Value.ToString();
            AddOR.AddressTextBox.Text = OrdersdataGridView1[5, row].Value.ToString();
            AddOR.dateTimePicker1.Text = OrdersdataGridView1[6, row].Value.ToString();
            AddOR.ShowDialog();
            DB.closeConnection();

        }
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            int row = OrdersdataGridView1.CurrentRow.Index;
            Database DB = new Database();
            DB.openConnection();
            var OrderNumber = OrdersdataGridView1[1, row].Value.ToString();
            var OrderID = OrdersdataGridView1[0, row].Value.ToString();
            DialogResult ConfirmDelete = MessageBox.Show(
                "Вы действительно хотите удалить заказ с номером " + OrdersdataGridView1[1, row].Value.ToString() + "? Данный заказ и все товары в нём будут " +
                "удалены без возможности сохранения.",
                "Удаление заказа",
                MessageBoxButtons.YesNo);
            if (ConfirmDelete == DialogResult.Yes)
            {
                try
                {
                    DateTime dateTime = DateTime.UtcNow.Date;
                    Variables.SqlQueryOrdersDelete = "DELETE FROM orderdetails WHERE id_order = " + OrdersdataGridView1[0, row].Value.ToString() + "";
                    MySqlCommand MySQLQueryDetailsDelete = new MySqlCommand(Variables.SqlQueryOrdersDelete, DB.getConnection());
                    MySQLQueryDetailsDelete.ExecuteNonQuery();

                    Variables.SqlQuery = "DELETE FROM orders WHERE id_order = " + OrdersdataGridView1[0, row].Value.ToString() + "";
                    MySqlCommand MySQLQueryOrderDelete = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryOrderDelete.ExecuteNonQuery();

                    string DeleteComment = Interaction.InputBox("Причина удаления", "Введите причину удаления заказа", "");

                    MessageBox.Show("Заказ с ID " + OrderID + " и номером " + OrderNumber + " успешно удалён! Все товары в нём также " +
                        "были удалены.");


                    Variables.SqlQueryOrderHistory = "INSERT INTO orderhistory (ordernumber, id_orderstatus, ordercustomercomment, orderdate) VALUES (@OhNum, @OhStatus, @OhComment, @Ohorderdate)";
                    MySqlCommand MySQLQueryHistoryQuery = new MySqlCommand(Variables.SqlQueryOrderHistory, DB.getConnection());
                    MySQLQueryHistoryQuery.Parameters.AddWithValue("@OhNum", OrderNumber);
                    MySQLQueryHistoryQuery.Parameters.AddWithValue("@OhStatus", "3");
                    MySQLQueryHistoryQuery.Parameters.AddWithValue("@OhComment", DeleteComment);
                    MySQLQueryHistoryQuery.Parameters.AddWithValue("@Ohorderdate", dateTime.ToString("yyyy-MM-dd"));
                    MySQLQueryHistoryQuery.ExecuteNonQuery();


                    UpdateButton.PerformClick();

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ошибка удаления заказа.");
                }

            }
        }



        private void CheckItemsInOrder_Click(object sender, EventArgs e)
        {
            Variables.TempVariableN4 = "OrderView";
            Database DB = new Database();

            DB.openConnection();
            var CheckIfOrderExists = new MySqlCommand("SELECT COUNT(*) FROM orders WHERE id_order = @NumericNum", DB.getConnection());
            CheckIfOrderExists.Parameters.Add("@NumericNum", MySqlDbType.VarChar).Value = UpDownForOrderCheck.Value;
            var OrderExistingValue = CheckIfOrderExists.ExecuteScalar();
            if (Convert.ToInt32(OrderExistingValue) > 0)
            {
                Errorlabel.Hide();
                Variables.OrderComponentsNumber = UpDownForOrderCheck.Value.ToString();
                OrderComponents OC = new OrderComponents();
                OC.ShowDialog();
            }
            else
            {
                Errorlabel.Show();
            }

        }
    }
}
