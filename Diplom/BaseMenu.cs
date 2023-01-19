using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Diplom
{
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
            this.Text = "База товаров магазина";

            Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(BazadataGridView1);
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            BazadataGridView1.ClearSelection();

            if (SearchtextBox.Text != "")
            {
                BazadataGridView1.MultiSelect = true;
                int i = 0;
                for (i = 0; i < BazadataGridView1.RowCount; i++)
                {
                    BazadataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < BazadataGridView1.ColumnCount; j++)
                        if (BazadataGridView1.Rows[i].Cells[j].Value != null)
                            if (BazadataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchtextBox.Text))
                            {
                                BazadataGridView1.Rows[i].Cells[j].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                BazadataGridView1.MultiSelect = false;
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype";
            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(BazadataGridView1);

            PartsButton.Enabled = true;
            PeriButton.Enabled = true;

            BazadataGridView1.MultiSelect = false;
        }

        private void PartsButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype AND m.id_maintype = 1";
            var MySQLQuery = new SqlQueryCommand();
            MySQLQuery.QueryForGridFill(BazadataGridView1);

            PartsButton.Enabled = false;
            PeriButton.Enabled = true;

        }

        private void PeriButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype AND m.id_maintype = 2";
            var MySQLQuery = new SqlQueryCommand();
            MySQLQuery.QueryForGridFill(BazadataGridView1);

            PeriButton.Enabled = false;
            PartsButton.Enabled = true;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Variables.AddVariable = "BaseMenu";
            AddData AD = new AddData();
            AD.ShowDialog();
        }

        private void EditPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = BazadataGridView1.CurrentRow.Index;
                Variables.AddVariable = "BaseMenu";
                EditMenu EM = new EditMenu();
                EM.IDTextBox.Text = BazadataGridView1[0, row].Value.ToString();
                EM.ValueBeforeTB1.Text = BazadataGridView1[1, row].Value.ToString();
                EM.ValueBeforeTB2.Text = BazadataGridView1[2, row].Value.ToString();
                EM.ValueBeforeTB3.Text = BazadataGridView1[3, row].Value.ToString();
                EM.ValueBeforeTB4.Text = BazadataGridView1[4, row].Value.ToString();
                EM.ValueBeforeTB5.Text = BazadataGridView1[5, row].Value.ToString();
                EM.ShowDialog();


            }
            catch (Exception)
            {
                MessageBox.Show("Выделите строку, которую хотите отредактировать.");
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            int row = BazadataGridView1.CurrentRow.Index;
            Database DB = new Database();
            DB.openConnection();

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить " + BazadataGridView1[1, row].Value.ToString() + "?",
                "Удаление товара из базы данных",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                    try
                    {
                        Variables.SqlQuery = "DELETE FROM mainbase WHERE id_main = " + BazadataGridView1[0, row].Value.ToString() + "";
                        MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                        MySQLQueryBaseMenu.ExecuteNonQuery();
                        MessageBox.Show("Товар с ID " + BazadataGridView1[0, row].Value.ToString() + " (" + BazadataGridView1[1, row].Value.ToString() + ") успешно удалён!");

                        UpdateButton.PerformClick();
                    }
                    catch (MySqlException)
                    {
                        List<string> LinkedValues = new List<string>();
                        Variables.SqlQuery = "SELECT * FROM orderdetails WHERE id_main= " + BazadataGridView1[0, row].Value.ToString() + "";
                        MySqlCommand cmd = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            LinkedValues.Add(dt.Rows[i]["id_order"].ToString());
                        }
                        string combinedString = string.Join(", ", LinkedValues.ToArray());

                        MessageBox.Show("Нельзя удалить, т.к. товар связан с заказом, имеющим идентификатор " + combinedString);
                    }

            }
        }

        private void BaseMenu_Activated(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }
    }
}
