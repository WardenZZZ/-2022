using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddData : Form
    {
        string messagebox;
        public AddData()
        {
            InitializeComponent();

            switch (Variables.AddVariable)
            {
                case "BaseMenu":
                    this.Size = new Size(350, 425);
                    Variables.TempVariableN1 = "maintype";
                    Variables.TempVariableN2 = "maintypename";
                    Variables.TempVariableN3 = "id_maintype";
                    messagebox = "Товар";
                    AddDataLabel.Text = "Добавление новых комплектующих";
                    FillComboBox();

                    Database DB = new Database();
                    Variables.SqlQuery = "SELECT * FROM `warehouse`";
                    MySqlCommand SQLComboBoxSecond = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    DB.openConnection();
                    MySqlDataReader sqlReaderSecond = SQLComboBoxSecond.ExecuteReader();

                    while (sqlReaderSecond.Read())
                    {
                        AddDataValueCB2.Items.Add(sqlReaderSecond["warehouseaddress"].ToString());
                    }
                    sqlReaderSecond.Close();
                    DB.closeConnection();

                    break;
                case "WarehouseMenu":

                    Variables.TempVariableN1 = "warehousetype";
                    Variables.TempVariableN2 = "warehousetypename";
                    Variables.TempVariableN3 = "id_warehousetype";

                    FillComboBox();
                    messagebox = "Пункт выдачи";
                    AddDataLabel.Text = "Добавление нового пункта выдачи";
                    AddDataLabel1.Text = "Тип пункта выдачи";
                    AddDataLabel2.Text = "Адрес пункта выдачи";
                    AddDataLabel3.Text = "Директор склада/магазина (ФИО)";
                    AddDataValueCB1.Location = new Point(56, 121);
                    AddDataValueTB1.Location = new Point(56, 175);
                    this.Size = new Size(350, 314);
                    AddDataLabel4.Visible = false;
                    AddDataValueTB3.Visible = false;
                    AddDataLabel5.Visible = false;
                    AddDataValueTB5.Visible = false;
                    AddDataLabel6.Visible = false;
                    AddDataValueCB2.Visible = false;



                    break;
                case "UsersMenu":
                    Variables.TempVariableN1 = "userperms";
                    Variables.TempVariableN2 = "Permsname";
                    Variables.TempVariableN3 = "id_Perms";
                    FillComboBox();
                    messagebox = "Пользователь";
                    AddDataLabel.Text = "Добавление нового пользователя";
                    AddDataLabel1.Text = "Логин пользователя";
                    AddDataLabel2.Text = "Пароль пользователя";
                    AddDataLabel3.Text = "Уровень доступа";
                    AddDataLabel4.Text = "Имя пользователя";
                    AddDataLabel5.Text = "Фамилия пользователя";
                    AddDataValueCB2.Visible = false;
                    AddDataValueTB4.Visible = true;
                    AddDataValueCB1.Location = new Point(56, 229);
                    AddDataValueTB2.Location = new Point(56, 175);
                    AddDataLabel6.Visible = true;
                    AddDataValueTB5.Visible = true;
                    break;

            }
        }
        private void FillComboBox()
        {
            Database DB = new Database();

            Variables.SqlQuery = "SELECT * FROM `" + Variables.TempVariableN1 + "`";
            MySqlCommand SQLComboBox = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
            DB.openConnection();
            MySqlDataReader sqlReader = SQLComboBox.ExecuteReader();

            while (sqlReader.Read())
            {
                AddDataValueCB1.Items.Add(sqlReader[Variables.TempVariableN2].ToString());

            }
            sqlReader.Close();
            DB.closeConnection();

        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            DB.openConnection();
            try
            {
                switch (Variables.AddVariable)
                {
                    case "BaseMenu":

                        Variables.SqlQuery = "INSERT INTO `mainbase` (mainname, id_maintype, mainamount, mainprice, id_warehouse) VALUES (@mname, @mtype, @mamount, @mprice, @mwareh)";
                        MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

                        MySQLQueryBaseMenu.Parameters.AddWithValue("@mname", AddDataValueTB1.Text);
                        MySQLQueryBaseMenu.Parameters.AddWithValue("@mtype", Comboboxlabel.Text);
                        MySQLQueryBaseMenu.Parameters.AddWithValue("@mamount", AddDataValueTB2.Text);
                        MySQLQueryBaseMenu.Parameters.AddWithValue("@mprice", AddDataValueTB3.Text);
                        MySQLQueryBaseMenu.Parameters.AddWithValue("@mwareh", Variables.MainID);
                        MySQLQueryBaseMenu.ExecuteNonQuery();
                        MessageBox.Show("Успех! " + messagebox + " " + AddDataValueTB1.Text + " успешно добавлен!");
                        Dialoguepopup();
                        break;
                    case "WarehouseMenu":
                        Variables.SqlQuery = "INSERT INTO `warehouse` (id_warehousetype, warehouseaddress, warehouseincharge) VALUES (@wtype, @waddress, @wincharge)";
                        MySqlCommand MySQLQueryWarehouse = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

                        MySQLQueryWarehouse.Parameters.AddWithValue("@wtype", Comboboxlabel.Text);
                        MySQLQueryWarehouse.Parameters.AddWithValue("@waddress", AddDataValueTB1.Text);
                        MySQLQueryWarehouse.Parameters.AddWithValue("@wincharge", AddDataValueTB2.Text);
                        MySQLQueryWarehouse.ExecuteNonQuery();
                        MessageBox.Show("Успех! " + messagebox + " типа " + AddDataValueCB1.Text + " по адресу " + AddDataValueTB1.Text + " успешно добавлен!");
                        Dialoguepopup();
                        break;
                    case "UsersMenu":
                        Variables.SqlQuery = "INSERT INTO `users` (login, password, id_Perms, Firstname, Lastname, Middlename) VALUES (@ulogin, @upass, @uperms, @uFname, @uLname, @uMname)";
                        MySqlCommand MySQLQueryUsers = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

                        MySQLQueryUsers.Parameters.AddWithValue("@ulogin", AddDataValueTB1.Text);
                        MySQLQueryUsers.Parameters.AddWithValue("@upass", AddDataValueTB2.Text);
                        MySQLQueryUsers.Parameters.AddWithValue("@uperms", Comboboxlabel.Text);
                        MySQLQueryUsers.Parameters.AddWithValue("@uFname", AddDataValueTB3.Text);
                        MySQLQueryUsers.Parameters.AddWithValue("@uLname", AddDataValueTB4.Text);
                        MySQLQueryUsers.Parameters.AddWithValue("@uMname", AddDataValueTB5.Text);

                        MySQLQueryUsers.ExecuteNonQuery();
                        MessageBox.Show("Успех! " + messagebox + " с именем " + AddDataValueTB3.Text + " и уровнем доступа " + AddDataValueCB1.Text + " успешно добавлен!");
                        Dialoguepopup();
                        break;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при добавлении данных.");
            }

            finally
            {
                DB.closeConnection();

            }
            AddDataValueCB1.Text = "";
            AddDataValueCB2.Text = "";
            AddDataValueTB1.Text = "";
            AddDataValueTB2.Text = "";
            AddDataValueTB3.Text = "";
            AddDataValueTB4.Text = "";

        }

        private void WarehouseName(object sender, EventArgs e)
        {
            Database DB = new Database();

            DB.openConnection();

            Variables.SqlQuery = "SELECT id_warehouse from warehouse WHERE `warehouseaddress` = @warehouseaddressvalue";

            MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQuery.Parameters.AddWithValue("@warehouseaddressvalue", AddDataValueCB2.Text);

            var WarehouseAddress = MySQLQuery.ExecuteScalar();

            Variables.MainID = Convert.ToString(WarehouseAddress);

            DB.closeConnection();
        }

        private void AddDataTextBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypesValue;
            Database DB = new Database();
            DB.openConnection();

            Variables.SqlQuery = "SELECT " + Variables.TempVariableN3 + " from " + Variables.TempVariableN1 + " WHERE " + Variables.TempVariableN2 + " = @typevalue";

            MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQueryBaseMenu.Parameters.AddWithValue("@typevalue", AddDataValueCB1.Text);

            TypesValue = Convert.ToString(MySQLQueryBaseMenu.ExecuteScalar());

            DB.closeConnection();

            Comboboxlabel.Text = TypesValue;

        }

        private void Dialoguepopup()
        {
            Database DB = new Database();
            DialogResult result = MessageBox.Show(
            "Добавить ещё " + messagebox + "?",
            "Добавление",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                this.Close();
                DB.closeConnection();


            }
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
