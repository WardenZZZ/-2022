using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Diplom
{
    public partial class RegisterMenu : Form
    {
        public RegisterMenu()
        {
            InitializeComponent();
        }
        public Form RefToLogMain { get; set; }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if ((LoginTextBox.Text != "") && (PasswordTextBox.Text != "") && (FirstnameTextBox.Text != "") && (LastnameTextBox.Text != "") && (MiddlenameTextBox.Text != ""))
            {
                string connectionString = "server=localhost;port=3306;username=root;password=root;database=citilink_database";

                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();

                var CheckIfLoginExists = new MySqlCommand("SELECT COUNT(*) FROM users WHERE login = @RegLoginTextBox", connection);
                CheckIfLoginExists.Parameters.Add("@RegLoginTextBox", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                var LoginExistingValue = CheckIfLoginExists.ExecuteScalar();

                if (Convert.ToInt32(LoginExistingValue) == 0)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (login, password, id_Perms, Firstname, Lastname, Middlename) VALUES (@RegLoginTextBox,@RegPasswordTextBox,@RegPerms,@RegFirstNameTextBox,@RegLastNameTextBox,@RegMiddleNameTextBox)", connection);
                    command.Parameters.Add("@RegLoginTextBox", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                    command.Parameters.Add("@RegPasswordTextBox", MySqlDbType.VarChar).Value = PasswordTextBox.Text;
                    command.Parameters.Add("@RegPerms", MySqlDbType.VarChar).Value = "4";
                    command.Parameters.Add("@RegFirstNameTextBox", MySqlDbType.VarChar).Value = FirstnameTextBox.Text;
                    command.Parameters.Add("@RegLastNameTextBox", MySqlDbType.VarChar).Value = LastnameTextBox.Text;
                    command.Parameters.Add("@RegMiddleNameTextBox", MySqlDbType.VarChar).Value = MiddlenameTextBox.Text;

                    command.ExecuteNonQuery();


                    MessageBox.Show("Аккаунт успешно создан!");

                    this.Close();
                    this.RefToLogMain.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.");
                }
            }
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToLogMain.Show();

        }

        private void RegisterMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
