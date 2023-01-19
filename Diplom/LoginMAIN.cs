using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Diplom
{
    public partial class LoginMAIN : Form
    {
        string fileName = "data.txt";
        public LoginMAIN()
        {
            InitializeComponent();

            //BaseMenu test = new BaseMenu(); - Проверка 
            //test.Show();




            if ((File.Exists(fileName)) && (File.ReadAllText(fileName).Length != 0))
            {
                string[] lines = File.ReadAllLines("data.txt");
                foreach (var line in lines)
                    LoginTextBox.Text = line;
                RememberAccCheckbox.Checked = true;
            }
            else 
            {
                FileStream fileStream = File.Open(fileName, FileMode.Create);
                StreamWriter output = new StreamWriter(fileStream);
                output.Close();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if ((RememberAccCheckbox.Checked == true) && (LoginTextBox.Text != " "))
            {
                string login = Convert.ToString(LoginTextBox.Text);

                FileStream fileStream = File.Open(fileName, FileMode.Create);
                StreamWriter output = new StreamWriter(fileStream);
                output.Write(login);
                output.Close();
            }
            else if (RememberAccCheckbox.Checked == false)
            {
                File.Delete(fileName);
            }

            string connectionString = "server=localhost;port=3306;username=root;password=root;database=citilink_database";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String loginUser = LoginTextBox.Text;
            String passUser = PasswordTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` WHERE `login`= @TextBoxLogin AND `password` = @TextBoxPassword", connection);

            command.Parameters.Add("@TextBoxLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@TextBoxPassword", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            var name = new MySqlCommand($"Select up.Permsname FROM userperms up, users u WHERE u.login = @TextBoxLogin AND u.id_Perms = up.id_Perms", connection);

            name.Parameters.Add("@TextBoxLogin", MySqlDbType.VarChar).Value = loginUser;

            Variables.UserPerms = name.ExecuteScalar().ToString();

            var FullName = new MySqlCommand("Select Firstname, Lastname, Middlename FROM users WHERE login = @TextBoxLogin", connection);

            FullName.Parameters.Add("@TextBoxLogin", MySqlDbType.VarChar).Value = loginUser;

            MySqlDataReader reader = FullName.ExecuteReader();

            if (table.Rows.Count > 0)
            {
                MainMenu MainWindow = new MainMenu();

                MainWindow.AccessLevelLabel.Text = MainWindow.AccessLevelLabel.Text + " " + Convert.ToString(Variables.UserPerms);
                while (reader.Read())
                {
                    MainWindow.UserNameLabel.Text = MainWindow.UserNameLabel.Text + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
                }
                MessageBox.Show("Добро пожаловать, " + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));

                Variables.name = Convert.ToString(Variables.UserPerms);

                MainWindow.Show();

                MainWindow.RefToLogMain = this;

                this.Hide();

                LoginTextBox.Clear();
                PasswordTextBox.Clear();
                RememberAccCheckbox.Checked = false;
            }
            else
                MessageBox.Show("Логин или пароль неверны.");

            connection.Close();
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            RegisterMenu RegMenu = new RegisterMenu();
            RegMenu.RefToLogMain = this;
            this.Visible = false;
            RegMenu.Show();
            
        }

        private void LoginMAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowPasswordCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void LoginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
