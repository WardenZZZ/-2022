using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Diplom
{
    public partial class WarehouseMenu : Form
    {
        public WarehouseMenu()
        {
            InitializeComponent();
            this.Text = "Список пунктов выдачи";

            AccessLevelLabel.Text = AccessLevelLabel.Text + " " + Variables.name;

            Variables.SqlQuery = "SELECT w.id_warehouse AS `Идентификатор склада/магазина`, wt.warehousetypename AS `Тип пункта выдачи`, w.warehouseaddress AS `Адрес`, " +
                "w.warehouseincharge AS `Ответственный за склад/магазин` FROM warehouse w, warehousetype wt WHERE w.id_warehousetype = wt.id_warehousetype";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(WarehouseDataGrid);
        }
        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            WarehouseDataGrid.ClearSelection();

            if (SearchtextBox.Text != "")
            {
                WarehouseDataGrid.MultiSelect = true;
                int i = 0;
                for (i = 0; i < WarehouseDataGrid.RowCount; i++)
                {
                    for (int j = 0; j < WarehouseDataGrid.ColumnCount; j++)
                        if (WarehouseDataGrid.Rows[i].Cells[j].Value != null)
                            if (WarehouseDataGrid.Rows[i].Cells[j].Value.ToString().Contains(SearchtextBox.Text))
                            {
                                WarehouseDataGrid.Rows[i].Cells[j].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                WarehouseDataGrid.MultiSelect = false;
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT w.id_warehouse AS `Идентификатор склада/магазина`, wt.warehousetypename AS `Тип пункта выдачи`, w.warehouseaddress AS `Адрес`, " +
                "w.warehouseincharge AS `Ответственный за склад/магазин` FROM warehouse w, warehousetype wt WHERE w.id_warehousetype = wt.id_warehousetype";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(WarehouseDataGrid);
        }
        private void WarehouseExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Variables.AddVariable = "WarehouseMenu";
            AddData AD = new AddData();
            AD.ShowDialog();
        }
        
        private void EditWareButton_Click(object sender, EventArgs e)
        {
            Variables.AddVariable = "WarehouseMenu";
            EditMenu EM = new EditMenu();
            EM.Close();
            EM = new EditMenu();
            int row = WarehouseDataGrid.CurrentRow.Index;
            EM.IDTextBox.Text = WarehouseDataGrid[0, row].Value.ToString();
            EM.ValueBeforeTB1.Text = WarehouseDataGrid[1, row].Value.ToString();
            EM.ValueBeforeTB2.Text = WarehouseDataGrid[2, row].Value.ToString();
            EM.ValueBeforeTB3.Text = WarehouseDataGrid[3, row].Value.ToString();
            EM.ShowDialog();
        }
        private void DeleteWareButton_Click(object sender, EventArgs e)
        {
            int row = WarehouseDataGrid.CurrentRow.Index;
            Database DB = new Database();
            DB.openConnection();
            DialogResult result = MessageBox.Show(
               "Вы действительно хотите удалить " + WarehouseDataGrid[1, row].Value.ToString() + " с идентификатором " + WarehouseDataGrid[0, row].Value.ToString() +  " по адресу " + WarehouseDataGrid[2, row].Value.ToString() + "?",
               "Удаление пункта выдачи из базы данных",
               MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Variables.SqlQuery = "DELETE FROM Warehouse WHERE id_warehouse = " + WarehouseDataGrid[0, row].Value.ToString() + "";
                    MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryBaseMenu.ExecuteNonQuery();
                    MessageBox.Show(WarehouseDataGrid[1, row].Value.ToString() + " с ID " + WarehouseDataGrid[0, row].Value.ToString() + " (По адресу " + WarehouseDataGrid[2, row].Value.ToString() + ") успешно удалён!");

                    UpdateButton.PerformClick();
                }
                catch (MySqlException)
                {
                    List<string> LinkedValues = new List<string>();
                    Variables.SqlQuery = "SELECT * FROM mainbase WHERE id_warehouse= " + WarehouseDataGrid[0, row].Value.ToString() + "";
                    MySqlCommand cmd = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        LinkedValues.Add(dt.Rows[i]["id_main"].ToString());
                    }
                    string combinedString = string.Join(", ", LinkedValues.ToArray());

                    MessageBox.Show("Нельзя удалить, т.к. данный пункт выдачи связан с товаром, имеющим идентификатор " + combinedString);
                }
            }
        }

        private void WarehouseMenu_Activated(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }
    }
}
