using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Diplom
{
    public partial class UsersMenu : Form
    {

        public UsersMenu()
        {
            InitializeComponent();
            this.Text = "Список зарегистрированных пользователей";

            AccessLevelLabel.Text = AccessLevelLabel.Text + " " + Variables.name;

            Variables.SqlQuery = "SELECT u.id_user AS `Идентификатор пользователя`, u.login AS `Логин пользователя`, u.password AS `Пароль пользователя`, " +
                "up.Permsname as `Уровень доступа`, u.Firstname AS `Имя`, u.Lastname AS `Фамилия`, u.Middlename AS `Отчество` " +
                "FROM users u, userperms up WHERE u.id_Perms = up.id_Perms";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(UsersdataGridView1);

        }
        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            UsersdataGridView1.ClearSelection();

            if (SearchtextBox.Text != "")
            {
                UsersdataGridView1.MultiSelect = true;
                int i = 0;
                for (i = 0; i < UsersdataGridView1.RowCount; i++)
                {
                    UsersdataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < UsersdataGridView1.ColumnCount; j++)
                        if (UsersdataGridView1.Rows[i].Cells[j].Value != null)
                            if (UsersdataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchtextBox.Text))
                            {
                                UsersdataGridView1.Rows[i].Cells[j].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                UsersdataGridView1.MultiSelect = false;
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Variables.SqlQuery = "SELECT u.id_user AS `Идентификатор пользователя`, u.login AS `Логин пользователя`, u.password AS `Пароль пользователя`, " +
            "up.Permsname as `Уровень доступа`, u.Firstname AS `Имя`, u.Lastname AS `Фамилия`, u.Middlename AS `Отчество` " +
            "FROM users u, userperms up WHERE u.id_Perms = up.id_Perms";

            var MySQLQuery = new SqlQueryCommand();

            MySQLQuery.QueryForGridFill(UsersdataGridView1);

            SearchtextBox.Clear();

            UsersdataGridView1.MultiSelect = false;
        }

        private void UsersExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Variables.AddVariable = "UsersMenu";
            AddData AD = new AddData();
            AD.Show();
        }
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            Variables.AddVariable = "UsersMenu";
            EditMenu EM = new EditMenu();
            EM.Close();
            EM = new EditMenu();
            int row = UsersdataGridView1.CurrentRow.Index;
            EM.IDTextBox.Text = UsersdataGridView1[0, row].Value.ToString();
            EM.ValueBeforeTB1.Text = UsersdataGridView1[1, row].Value.ToString();
            EM.ValueBeforeTB2.Text = UsersdataGridView1[2, row].Value.ToString();
            EM.ValueBeforeTB3.Text = UsersdataGridView1[3, row].Value.ToString();
            EM.ValueBeforeTB4.Text = UsersdataGridView1[4, row].Value.ToString();
            EM.ValueBeforeTB5.Text = UsersdataGridView1[5, row].Value.ToString();
            EM.ValueBeforeTB6.Text = UsersdataGridView1[6, row].Value.ToString();
            EM.ShowDialog();
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            int row = UsersdataGridView1.CurrentRow.Index;
            Database DB = new Database();
            DB.openConnection();
            DialogResult result = MessageBox.Show(
               "Вы действительно хотите удалить пользователя " + UsersdataGridView1[3, row].Value.ToString() + " с уровнем доступа " + UsersdataGridView1[2, row].Value.ToString() + "?",
               "Удаление пользователя из базы данных",
               MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Variables.SqlQuery = "DELETE FROM users WHERE id_user = " + UsersdataGridView1[0, row].Value.ToString() + "";
                    MySqlCommand MySQLQueryBaseMenu = new MySqlCommand(Variables.SqlQuery, DB.getConnection());
                    MySQLQueryBaseMenu.ExecuteNonQuery();
                    MessageBox.Show("Пользователь с ID " + UsersdataGridView1[0, row].Value.ToString() + " (" + UsersdataGridView1[4, row].Value.ToString() + ") успешно удалён!");

                    UpdateButton.PerformClick();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ошибка");
                }
            }

        }

        private void UsersMenu_Activated(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }
    }
}
