using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddOrderEnd : Form
    {
        public AddOrderEnd()
        {
            InitializeComponent();
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string createdDate = $"{date:yyyy-MM-dd}";

            Database DB = new Database();
            DB.openConnection();
            Variables.SqlQuery = "INSERT INTO `orderhistory` (ordernumber, id_orderstatus, ordercustomercomment, orderdate) VALUES (@ordernum, @ordstatus, @CustomerComment, @orddate)";

            MySqlCommand OrderHistoryQuery = new MySqlCommand(Variables.SqlQuery, DB.getConnection());

            OrderHistoryQuery.Parameters.AddWithValue("@ordernum", Variables.TempVariableN3);
            OrderHistoryQuery.Parameters.AddWithValue("@ordstatus", "1");
            OrderHistoryQuery.Parameters.AddWithValue("@CustomerComment", CustomerCommentTextBox.Text);
            OrderHistoryQuery.Parameters.AddWithValue("@orddate", createdDate);

            OrderHistoryQuery.ExecuteNonQuery();

            MessageBox.Show("Заказ оформлен полностью оформлен!", "Добавление заказа");
            DB.closeConnection();

            Close();

        }
    }
}
