using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Diplom
{
    public partial class MainMenu : Form
    {
        public Form RefToLogMain { get; set; }
        public MainMenu()
        {
            InitializeComponent();

            switch (Variables.UserPerms)
            {
                case "Админ":
                    break;
                case "Сотрудник":
                    StoreRoomButton.Enabled = false;
                    UsersButton.Enabled = false;
                    StatsButton.Enabled = false;
                    ExportButton.Enabled = false;
                    break;
                case "Работник склада":
                    OrdersButton.Enabled = false;
                    UsersButton.Enabled = false;
                    StatsButton.Enabled = false;
                    ExportButton.Enabled = false;
                    break;
                case "Новый аккаунт":
                    BaseButton.Enabled = false;
                    OrdersButton.Enabled = false;
                    StoreRoomButton.Enabled = false;
                    UsersButton.Enabled = false;
                    StatsButton.Enabled = false;
                    ExportButton.Enabled = false;
                    break;
                case "Менеджер":
                    BaseButton.Enabled = false;
                    OrdersButton.Enabled = false;
                    StoreRoomButton.Enabled = false;
                    UsersButton.Enabled = false;
                    StatsButton.Enabled = true;
                    ExportButton.Enabled = true;
                    break;
            }
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была разработана в рамках дипломной работы Ковбеля Никиты Олеговича. /n Тема дипломной работы: Проектирование и разработка автоматизированной информационной системы учета комплектующих ООО «Ситилинк»", "Справка");
        }

        private void BaseButton_Click(object sender, EventArgs e)
        {
            BaseMenu Base = new BaseMenu();
            Base.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersMenu Orders = new OrdersMenu();
            Orders.Show();
        }
        private void StoreRoomButton_Click(object sender, EventArgs e)
        {
            WarehouseMenu WareHouse = new WarehouseMenu();
            WareHouse.Show();
        }
        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersMenu UserMenu = new UsersMenu();
            UserMenu.Show();
        }
        private void StatsButton_Click(object sender, EventArgs e)
        {
            StatsMenu SM = new StatsMenu();
            SM.Show();
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportMenu ExportM = new ExportMenu();
            ExportM.Show();

        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefToLogMain.Show();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"Руководство пользователя.docx";
            Process.Start(file);
        }


        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefToLogMain.Close();
        }

    }
}
