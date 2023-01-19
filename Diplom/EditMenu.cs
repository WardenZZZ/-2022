using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
    public partial class EditMenu : Form
    {

        public EditMenu()
        {
            InitializeComponent();
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {
            switch (Variables.AddVariable)
            {
                case "BaseMenu":
                    Variables.TempVariableN1 = "maintype";
                    Variables.TempVariableN2 = "maintypename";
                    Variables.TempVariableN3 = "id_maintype";
                    FillComboBox();

                    Database DB = new Database();
                    Variables.SqlQuery = "SELECT * FROM `warehouse`";
                    MySqlCommand SQLComboBoxSecond = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    DB.openConnection();
                    MySqlDataReader sqlReaderSecond = SQLComboBoxSecond.ExecuteReader();

                    while (sqlReaderSecond.Read())
                    {
                        ValueAfterCB2.Items.Add(sqlReaderSecond["warehouseaddress"].ToString());
                    }
                    ValueAfterTB1.Text = ValueBeforeTB1.Text;
                    ValueAfterCB1.Text = ValueBeforeTB2.Text;
                    ValueAfterTB2.Text = ValueBeforeTB3.Text;
                    ValueAfterTB4.Text = ValueBeforeTB4.Text;
                    ValueAfterCB2.Text = ValueBeforeTB5.Text;
                    ValueAfterTB5.Visible = false;
                    EditButton.Size = new Size(254, 34);

                    sqlReaderSecond.Close();
                    DB.closeConnection();

                    break;
                case "WarehouseMenu":
                    Variables.TempVariableN1 = "Warehousetype";
                    Variables.TempVariableN2 = "warehousetypename";
                    Variables.TempVariableN3 = "id_warehousetype";
                    ValueBeforeLabel1.Text = "Тип пункта выдачи";
                    ValueBeforeLabel2.Text = "Адрес пункта выдачи";
                    ValueBeforeLabel3.Text = "Ответственный за пункт";
                    this.Size = new Size(701, 193);
                    ValueAfterCB1.Location = new Point(103, 112);
                    ValueAfterTB1.Location = new Point(304, 111);
                    groupBox1.Size = new Size(671, 44);
                    EditButton.Size = new Size(208, 34);
                    EditButton.Location = new Point(490, 147);
                    FillComboBox();

                    ValueAfterCB1.Text = ValueBeforeTB1.Text;
                    ValueAfterTB1.Text = ValueBeforeTB2.Text;
                    ValueAfterTB2.Text = ValueBeforeTB3.Text;

                    break;

                case "UsersMenu":
                    Variables.TempVariableN1 = "userperms";
                    Variables.TempVariableN2 = "Permsname";
                    Variables.TempVariableN3 = "id_Perms";
                    this.Size = new Size(1321, 193);
                    EditButton.Location = new Point(670, 147);
                    groupBox1.Size = new Size(1288, 44);
                    ValueAfterCB1.Location = new Point(507, 111);
                    ValueAfterTB2.Location = new Point(304, 111);
                    ValueAfterCB2.Visible = false;
                    ValueBeforeLabel1.Text = "Логин пользователя";
                    ValueBeforeLabel2.Text = "Пароль пользователя";
                    ValueBeforeLabel3.Text = "Уровень доступа";
                    ValueBeforeLabel4.Text = "Имя пользователя";
                    ValueBeforeLabel5.Text = "Фамилия пользователя";
                    ValueBeforeLabel6.Text = "Отчество пользователя";
                    FillComboBox();

                    ValueAfterTB1.Text = ValueBeforeTB1.Text;
                    ValueAfterTB2.Text = ValueBeforeTB2.Text;
                    ValueAfterCB1.Text = ValueBeforeTB3.Text;
                    ValueAfterTB3.Text = ValueBeforeTB4.Text;
                    ValueAfterTB4.Text = ValueBeforeTB5.Text;
                    ValueAfterTB5.Text = ValueBeforeTB6.Text;

                    ValueAfterTB2.TabIndex = 2;
                    ValueAfterCB1.TabIndex = 3;
                    ValueAfterTB3.TabIndex = 4;
                    ValueAfterTB4.TabIndex = 5;
                    ValueAfterTB5.TabIndex = 6;
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
                ValueAfterCB1.Items.Add(sqlReader[Variables.TempVariableN2].ToString());

            }
            sqlReader.Close();
            DB.closeConnection();

        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Database DB = new Database();

            DB.openConnection();
            switch (Variables.AddVariable)
            {
                case "BaseMenu":
                    WarehouseCheck();
                    Variables.SqlQuery = "UPDATE mainbase SET mainname='" + ValueAfterTB1.Text + "', id_maintype='" + LabelforForeignKeys.Text + "', " +
                        "mainamount='" + ValueAfterTB2.Text + "', mainprice='" + ValueAfterTB3.Text + "', id_warehouse='" + Variables.MainID + "' WHERE id_main='" + IDTextBox.Text + "'";
                    MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryBaseMenu.ExecuteNonQuery();
                    MessageBox.Show("Товар с ID " + IDTextBox.Text + " под названием " + ValueAfterTB1.Text + " был успешно изменён!");
                    this.Close();
                    break;

                case "WarehouseMenu":
                    WarehouseCheck();
                    Variables.SqlQuery = "UPDATE warehouse SET id_warehousetype='" + LabelforForeignKeys.Text + "', warehouseaddress='" + ValueAfterTB1.Text + "', " +
                        "warehouseincharge='" + ValueAfterTB2.Text + "' WHERE id_warehouse='" + IDTextBox.Text + "'";
                    MySqlCommand MySQLQueryWarehouseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryWarehouseMenu.ExecuteNonQuery();
                    MessageBox.Show("Пункт выдачи с ID " + IDTextBox.Text + ", расположенный по адресу " + ValueAfterTB1.Text + " был успешно изменён!");
                    this.Close();
                    break;

                case "UsersMenu":
                    Variables.SqlQuery = "UPDATE users SET login='" + ValueAfterTB1.Text + "', password='" + ValueAfterTB2.Text + "', " +
                    "id_Perms='" + LabelforForeignKeys.Text + "', Firstname='" + ValueAfterTB3.Text + "', Lastname='" + ValueAfterTB4.Text + "', Middlename='" + ValueAfterTB5.Text + "' WHERE id_user='" + IDTextBox.Text + "'";
                    MySqlCommand MySQLQueryUsersMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryUsersMenu.ExecuteNonQuery();
                    MessageBox.Show("Пользователь с ID " + IDTextBox.Text + " с ФИО " + ValueAfterTB3.Text + " " + ValueAfterTB4.Text + " " + ValueAfterTB5.Text);
                    this.Close();
                    break;
            }
            DB.closeConnection();

        }

        private void MTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypesValue;
            Database DB = new Database();
            DB.openConnection();

            Variables.SqlQuery = "SELECT " + Variables.TempVariableN3 + " from " + Variables.TempVariableN1 + " WHERE  " + Variables.TempVariableN2 + " = @typevalue";

            MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQueryBaseMenu.Parameters.AddWithValue("@typevalue", ValueAfterCB1.Text);

            TypesValue = Convert.ToString(MySQLQueryBaseMenu.ExecuteScalar());

            LabelforForeignKeys.Text = TypesValue;

            DB.closeConnection();

        }

        private void WarehouseCheck()
        {
            Database DB = new Database();

            DB.openConnection();

            Variables.SqlQuery = "SELECT id_warehouse from warehouse WHERE `warehouseaddress` = @warehouseaddressvalue";

            MySqlCommand MySQLQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            MySQLQuery.Parameters.AddWithValue("@warehouseaddressvalue", ValueAfterCB2.Text);

            var WarehouseAddress = MySQLQuery.ExecuteScalar();

            Variables.MainID = Convert.ToString(WarehouseAddress);

            DB.closeConnection();
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
