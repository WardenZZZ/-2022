using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddOrder : Form
    {
        int Amount = 0;
        int TotalPrice = 0;
        string OrderTypeDistinctCheck = "";
        public AddOrder()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            LoadOrders();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            DB.openConnection();

            try
            {


                Variables.SqlQuery = "INSERT INTO `orderdetails` (id_order, id_main, orderdetailsamount, orderdetailsprice) VALUES (@idOrder, @idMain, @Amount, @Price)";
                MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

                MySQLQuery.Parameters.AddWithValue("@idOrder", OrderIDTextBox.Text);
                MySQLQuery.Parameters.AddWithValue("@idMain", Variables.MainID);
                MySQLQuery.Parameters.AddWithValue("@Amount", OrderDetailsAmount.Value);
                MySQLQuery.Parameters.AddWithValue("@Price", PriceTextBox.Text);

                MySQLQuery.ExecuteNonQuery();

                Variables.DataEstimation = dateTimePicker1.Text;
                Variables.CustomerAddress = AddressTextBox.Text;

                Variables.SqlQuery = "SELECT m.mainname, od.orderdetailsamount, od.orderdetailsprice FROM mainbase m, orderdetails od WHERE od.id_order = @idMain3 AND od.id_main = m.id_main";
                MySqlCommand MySQLQueryLoad = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                MySQLQueryLoad.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);


                DialogResult result = MessageBox.Show(
                    "Добавить ещё предметы в заказ?",
                    "Добавление заказа",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataTable Dtable = new DataTable();
                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                    DataAdapter.SelectCommand = MySQLQueryLoad;
                    DataAdapter.Fill(Dtable);
                    ItemsinOrdersDGV.DataSource = Dtable;
                    AddressTextBox.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    OrderDetailsAmount.Value = 1;
                    EditItemOrderButton.Enabled = true;
                }
                else
                {
                    Variables.SqlQuery = "SELECT m.mainname, od.orderdetailsamount, od.orderdetailsprice FROM mainbase m, orderdetails od WHERE od.id_order = @idMain3 AND od.id_main = m.id_main";
                    MySqlCommand MySQLQueryLoadNo = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryLoadNo.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);
                    DataTable Dtable = new DataTable();
                    MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                    DataAdapter.SelectCommand = MySQLQueryLoadNo;
                    DataAdapter.Fill(Dtable);
                    ItemsinOrdersDGV.DataSource = Dtable;
                    EditItemOrderButton.Enabled = true;
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Не все данные были введены для добавления!");
            }
           

        }

        private void LoadOrders()
        {
            OrderNumberTextBox.Text = Variables.TempVariableN1;

            Database DB = new Database();
            Variables.SqlQuery = "SELECT * FROM `mainbase`";
            MySqlCommand SQLComboBox = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
            DB.openConnection();
            MySqlDataReader sqlReader = SQLComboBox.ExecuteReader();

            while (sqlReader.Read())
            {
                BaseItemsComboBox.Items.Add(sqlReader["mainname"].ToString());
            }
            sqlReader.Close();
            DB.openConnection();
            Variables.TempVariableN2 = "SELECT id_order FROM orders WHERE ordernumber = @OrderNumber";
            MySqlCommand OrderIDCommand = new MySqlCommand(Variables.TempVariableN2, DB.getConnection());
            OrderIDCommand.Parameters.Add("@OrderNumber", MySqlDbType.VarChar).Value = Variables.TempVariableN1;
            var Perms1 = OrderIDCommand.ExecuteScalar();
            OrderIDTextBox.Text = Convert.ToString(Perms1);
            DB.closeConnection();
        }


        private void OrderPrice()
        {
            Database DB = new Database();

            DB.openConnection();

            Variables.SqlQuery = "SELECT mainprice from mainbase WHERE `mainname` = @OrderPrice";

            MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQuery.Parameters.AddWithValue("@OrderPrice", BaseItemsComboBox.Text);


            var Perms = MySQLQuery.ExecuteScalar();
            var ValueofNumericUpDown = OrderDetailsAmount.Value;
            var PriceValue = Convert.ToInt32(Perms);

            PriceTextBox.Text = Convert.ToString((PriceValue * ValueofNumericUpDown));

            DB.closeConnection();
        }

        private void BaseItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckList();

            OrderPrice();

            Database DB = new Database();

            DB.openConnection();

            Variables.SqlQuery = "SELECT id_main from mainbase WHERE `mainname` = @OrderPrice";

            MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQuery.Parameters.AddWithValue("@OrderPrice", BaseItemsComboBox.Text);

            var Perms = MySQLQuery.ExecuteScalar();

            Variables.MainID = Convert.ToString(Perms);


        }

        private void OrderDetailsAmount_ValueChanged(object sender, EventArgs e)
        {
            OrderPrice();
        }
        private void GetTotalPriceAmount()
        {
            Database DB = new Database();
            DB.openConnection();
            Variables.SqlQueryPriceAmount = "SELECT * FROM orderdetails WHERE id_order = @idMain3";
            MySqlCommand SQLOrderAmount = new MySqlCommand(Variables.SqlQueryPriceAmount, DB.getConnection());
            SQLOrderAmount.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);
            var sqlReaderAmount = SQLOrderAmount.ExecuteReader();

            while (sqlReaderAmount.Read())
            {
                Amount += Convert.ToInt32((sqlReaderAmount["orderdetailsamount"]));
                TotalPrice += +Convert.ToInt32((sqlReaderAmount["orderdetailsprice"]));
            }

            Amountlabel2.Text = Convert.ToString(Amount);
            TotalPricelabel3.Text = Convert.ToString(TotalPrice);
            DB.closeConnection();
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinishOrder_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            DB.openConnection();
            if (Variables.TempVariableN4 == "Edit")
            {
                GetTotalPriceAmount();
                Variables.CustomerAddress = AddressTextBox.Text;
                Variables.DataEstimation = dateTimePicker1.Text;
                Variables.SqlQuery = "UPDATE orders SET orderamount = '" + Amountlabel2.Text + "', ordertotalprice = '" + TotalPricelabel3.Text + "', ordercustomeraddress = '" + Variables.CustomerAddress + "', orderdataestimation = '" + Variables.DataEstimation + "' WHERE id_order = " + OrderIDTextBox.Text + "";
                MySqlCommand MySQLQueryEditP2 = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                MySQLQueryEditP2.ExecuteNonQuery();
                List<string> CheckOrderType = new List<string>();
                Variables.SqlQuery = "SELECT DISTINCT id_maintype FROM mainbase m, orderdetails od WHERE od.id_order = @idMain2 AND m.id_main = od.id_main";
                MySqlCommand SQLComboBox = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                SQLComboBox.Parameters.AddWithValue("@idMain2", OrderIDTextBox.Text);
                var sqlReader = SQLComboBox.ExecuteReader();
                while (sqlReader.Read())
                {
                    CheckOrderType.Add(sqlReader["id_maintype"].ToString());
                    comboBox1.Items.Add(sqlReader["id_maintype"].ToString());
                }
                if (CheckOrderType.Distinct().Count() == 1)
                {
                    OrderTypeDistinctCheck = Convert.ToString(CheckOrderType.First());

                }
                else
                {
                    OrderTypeDistinctCheck = "3";
                    CheckOrderTypelabel4.Text = OrderTypeDistinctCheck;

                };

            }
            else
            {
                OrderEnd();
            }
            DB.closeConnection();


        }

        private void OrderEnd()
        {
            Database DB = new Database();

            DB.openConnection();
            List<string> CheckOrderType = new List<string>();
            Variables.SqlQuery = "SELECT DISTINCT id_maintype FROM mainbase m, orderdetails od WHERE od.id_order = @idMain2 AND m.id_main = od.id_main";
            MySqlCommand SQLComboBox = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
            SQLComboBox.Parameters.AddWithValue("@idMain2", OrderIDTextBox.Text);
            var sqlReader = SQLComboBox.ExecuteReader();
            while (sqlReader.Read())
            {
                CheckOrderType.Add(sqlReader["id_maintype"].ToString());
                comboBox1.Items.Add(sqlReader["id_maintype"].ToString());
            }
            if (CheckOrderType.Distinct().Count() == 1)
            {
                OrderTypeDistinctCheck = Convert.ToString(CheckOrderType.First());

            }
            else
            {
                OrderTypeDistinctCheck = "3";
                CheckOrderTypelabel4.Text = OrderTypeDistinctCheck;

            }
            GetTotalPriceAmount();
            DB.closeConnection();


            Variables.SqlQuery = "UPDATE `Orders` SET id_ordertype = @TypeCheck, orderamount = @OrderQuantity, ordertotalprice = @PriceTotal, " +
                "ordercustomeraddress = @AddressOrder, orderdataestimation = @OrderDateArrivalEst WHERE ordernumber = @OrderNumber AND id_order = @IDOrderMain";
            MySqlCommand SqlOrderUpdate = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
            DB.openConnection();

            SqlOrderUpdate.Parameters.AddWithValue("@TypeCheck", OrderTypeDistinctCheck);
            SqlOrderUpdate.Parameters.AddWithValue("@OrderQuantity", Amount);
            SqlOrderUpdate.Parameters.AddWithValue("@PriceTotal", TotalPrice);
            SqlOrderUpdate.Parameters.AddWithValue("@AddressOrder", Variables.CustomerAddress);
            SqlOrderUpdate.Parameters.AddWithValue("@OrderDateArrivalEst", Variables.DataEstimation);
            SqlOrderUpdate.Parameters.AddWithValue("@OrderNumber", OrderNumberTextBox.Text);
            SqlOrderUpdate.Parameters.AddWithValue("@IDOrderMain", OrderIDTextBox.Text);
            SqlOrderUpdate.ExecuteNonQuery();

            Variables.TempVariableN3 = OrderNumberTextBox.Text;

            Close();

            AddOrderEnd AddOrdEnd = new AddOrderEnd();
            AddOrdEnd.Show();

            DB.closeConnection();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            if (Variables.TempVariableN4 == "Edit")
            {
                
                Database DB = new Database();
                VirtusLabel.Text = "Изменить заказ";
                Variables.SqlQuery = "SELECT m.mainname AS `Название товара`, od.orderdetailsamount AS `Количество`, od.orderdetailsprice AS `Стоимость` FROM mainbase m, orderdetails od WHERE od.id_order = @idMain3 AND od.id_main = m.id_main";
                MySqlCommand MySQLQueryLoad = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                MySQLQueryLoad.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);
                DataTable Dtable = new DataTable();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = MySQLQueryLoad;
                DataAdapter.Fill(Dtable);
                ItemsinOrdersDGV.DataSource = Dtable;
                EditItemOrderButton.Enabled = true;

            }
            else
            {
                VirtusLabel.Text = "Добавить заказ";
                this.ItemsinOrdersDGV.Columns.Clear();

            }
            CheckList();
        }
        private void ItemsinOrdersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = ItemsinOrdersDGV.CurrentRow.Index;

                BaseItemsComboBox.Text = ItemsinOrdersDGV[0, row].Value.ToString();
                OrderDetailsAmount.Text = ItemsinOrdersDGV[1, row].Value.ToString();


                Database DB = new Database();
                DB.openConnection();
                Variables.TempVariableN2 = "SELECT id_orderdetails FROM orderdetails WHERE id_order = " + OrderIDTextBox.Text + " AND orderdetailsamount = " + ItemsinOrdersDGV[1, row].Value.ToString() + " AND orderdetailsprice = " + ItemsinOrdersDGV[2, row].Value.ToString() + "";
                MySqlCommand MySQLGetID = new MySqlCommand(Variables.TempVariableN2, DB.getConnection());
                var GetID = MySQLGetID.ExecuteScalar();
                GetorderdetailsID.Text = GetID.ToString();
                DB.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("В таблице отсутствуют данные для выделения!");
            }


        }

        private void ItemsinOrdersDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ItemsinOrdersDGV.ClearSelection();
        }
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
                try
                {
                    int row = ItemsinOrdersDGV.CurrentRow.Index;
                    Database DB = new Database();
                    DB.openConnection();
                    DialogResult result = MessageBox.Show(
                        "Вы действительно хотите удалить " + ItemsinOrdersDGV[0, row].Value.ToString() + "?",
                        "Удаление товара из формирующегося заказа",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        {
                            Variables.SqlQuery = "DELETE FROM orderdetails WHERE id_orderdetails = " + GetorderdetailsID.Text + "";
                            MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                            MySQLQueryBaseMenu.ExecuteNonQuery();
                            MessageBox.Show("Товар с названием " + ItemsinOrdersDGV[0, row].Value.ToString() + " (" + ItemsinOrdersDGV[1, row].Value.ToString() + ") успешно удалён из заказа " + OrderIDTextBox.Text + "!");

                            Variables.SqlQuery = "SELECT m.mainname, od.orderdetailsamount, od.orderdetailsprice FROM mainbase m, orderdetails od WHERE od.id_order = @idMain3 AND od.id_main = m.id_main";
                            MySqlCommand MySQLQueryDeleteUpdate = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                            MySQLQueryDeleteUpdate.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);
                            DataTable Dtable = new DataTable();
                            MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                            DataAdapter.SelectCommand = MySQLQueryDeleteUpdate;
                            ItemsinOrdersDGV.DataSource = Dtable;
                            DataAdapter.Fill(Dtable);
                        }

                }
                catch (MySqlException)
                {
                MessageBox.Show("Ошибка при удалении!");
                }
        }

        private void EditItemOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database DB = new Database();
                DB.openConnection();
                Variables.SqlQuery = "UPDATE orderdetails SET id_main = " + Variables.MainID + ", orderdetailsamount = " + OrderDetailsAmount.Value + ", orderdetailsprice = " + PriceTextBox.Text + " WHERE id_orderdetails = " + GetorderdetailsID.Text + "";
                MySqlCommand MySQLQueryEdit = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                MySQLQueryEdit.ExecuteNonQuery();
                Variables.SqlQuery = "SELECT m.mainname, od.orderdetailsamount, od.orderdetailsprice FROM mainbase m, orderdetails od WHERE od.id_order = @idMain3 AND od.id_main = m.id_main";
                MySqlCommand MySQLQueryLoadEdit = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                MySQLQueryLoadEdit.Parameters.AddWithValue("@idMain3", OrderIDTextBox.Text);
                DataTable Dtable = new DataTable();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                DataAdapter.SelectCommand = MySQLQueryLoadEdit;
                DataAdapter.Fill(Dtable);
                ItemsinOrdersDGV.DataSource = Dtable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ошибка при редактировании.");
            }
        }

        private void CheckList()
        {
            if ((BaseItemsComboBox.Text == "") || (ItemsinOrdersDGV.SelectedCells.Count < 0))
            {
                AddItemButton.Enabled = false;
                DeleteItemButton.Enabled = false;
                EditItemOrderButton.Enabled = false;
                FinishOrderButton.Enabled = false;
            }
            else
            {
                AddItemButton.Enabled = true;
                DeleteItemButton.Enabled = true;
                EditItemOrderButton.Enabled = true;
                FinishOrderButton.Enabled = true;
            }
        }
    }
}
            
