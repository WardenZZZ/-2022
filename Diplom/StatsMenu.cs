using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diplom
{
    public partial class StatsMenu : Form
    {
        public StatsMenu()
        {
            InitializeComponent();
            this.Text = "Статистика";
            DTPickerBetween1.Format = DateTimePickerFormat.Custom;
            DTPickerBetween1.CustomFormat = "yyyy-MM-dd";
            DTPickerBetween2.Format = DateTimePickerFormat.Custom;
            DTPickerBetween2.CustomFormat = "yyyy-MM-dd";
        }

        private void ShowChartButton_Click(object sender, EventArgs e)
        {
            if (ChartType.Text == "")
            {
                MessageBox.Show("Выберите тип диаграммы!");
            }

            else
            {
                switch (StatsCombobox.Text)
                {
                    case "Состояние заказов":
                        Variables.SqlQuery = "SELECT os.statusname, COUNT(*) FROM orderhistory oh, orderstatus os WHERE oh.id_orderstatus = os.id_orderstatus GROUP BY os.statusname";
                        FillChart();


                        this.chart1.Series[0].XValueMember = "statusname";

                        this.chart1.Series[0].YValueMembers = "COUNT(*)";

                        this.chart1.DataBind();




                        break;


                    case "Товарам в П.Д.":
                        Variables.SqlQuery = "SELECT COUNT(mb.id_main), wh.warehousetypename FROM mainbase mb, warehousetype wh, warehouse w WHERE " +
                            "w.id_warehousetype = wh.id_warehousetype AND w.id_warehouse = mb.id_warehouse GROUP BY wh.warehousetypename";
                        FillChart();

                        this.chart1.Series[0].XValueMember = "warehousetypename";

                        this.chart1.Series[0].YValueMembers = "COUNT(mb.id_main)";

                        this.chart1.DataBind();


                        break;


                    case "Заказы за промежуток времени":
                        Variables.SqlQuery = "SELECT COUNT(*), orderdataestimation FROM orders WHERE orderdataestimation " +
                            "BETWEEN '" + DTPickerBetween1.Text + "' AND '" + DTPickerBetween2.Text + "' GROUP BY orderdataestimation";
                        FillChart();
                        this.chart1.Series[0].XValueMember = "orderdataestimation";
                        this.chart1.Series[0].XValueType = ChartValueType.Date;

                        this.chart1.Series[0].YValueMembers = "COUNT(*)";

                        this.chart1.DataBind();

                        break;
                    case "Выручка по типу товара":
                        Variables.SqlQuery = "SELECT mt.maintypename, SUM(orderdetailsprice) FROM maintype mt, orderdetails od, mainbase mb " +
                            "WHERE od.id_main = mb.id_main AND mb.id_maintype = mt.id_maintype GROUP BY mt.maintypename";
                        FillChart();

                        this.chart1.Series[0].XValueMember = "maintypename";

                        this.chart1.Series[0].YValueMembers = "SUM(orderdetailsprice)";

                        this.chart1.DataBind();
                        break;

                    case "Количество заказов по типу":
                        Variables.SqlQuery = "SELECT COUNT(*), ot.ordertypename FROM orders o, ordertype ot WHERE o.id_ordertype = ot.id_ordertype GROUP by ot.ordertypename";
                        FillChart();

                        this.chart1.Series[0].XValueMember = "ordertypename";

                        this.chart1.Series[0].YValueMembers = "COUNT(*)";

                        this.chart1.DataBind();
                        break;
                }
            
            }
        }

        private void FillChart()
        {
            Database DB = new Database();
            DB.openConnection();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=citilink_database");
            MySqlDataAdapter MySQLAdapter = new MySqlDataAdapter();
            MySqlCommand MySQLQuery = connection.CreateCommand();
            MySQLQuery.CommandText = Variables.SqlQuery;
            MySQLAdapter.SelectCommand = MySQLQuery;
            DataSet ds = new DataSet();

            DB.openConnection();
            MySQLAdapter.Fill(ds);

            this.chart1.DataSource = ds.Tables[0];

            connection.Close();
        }

        private void ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChartType.Text)
            {
                case "Горизонтальная Гистограмма":
                    chart1.Series[0].ChartType = SeriesChartType.Column;
                    chart1.Series[0].IsVisibleInLegend = false;
                    break;

                case "Вертикальная Гистограмма":
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    chart1.Series[0].IsVisibleInLegend = false;
                    break;

                case "Круговая":
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    chart1.Series[0].IsVisibleInLegend = true;
                    break;
                case "График":
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].IsVisibleInLegend = false;
                    break;

            }

        }

        private void DTPickerBetween1_ValueChanged(object sender, EventArgs e)
        {
            DTPickerBetween1.Format = DateTimePickerFormat.Custom;
            DTPickerBetween1.CustomFormat = "yyyy-MM-dd";
            DTPickerBetween2.Format = DateTimePickerFormat.Custom;
            DTPickerBetween2.CustomFormat = "yyyy-MM-dd";
            ShowChartButton.Enabled = true;

        }

        private void StatsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatsCombobox.Text == "Заказы за промежуток времени")
            {
                ShowChartButton.Enabled = false;
                DTPickerBetween1.Visible = true;
                DTPickerBetween2.Visible = true;
                Datelabeltip.Visible = true;
            }
            else
            {
                ShowChartButton.Enabled = true;
                DTPickerBetween1.Visible = false;
                DTPickerBetween2.Visible = false;
                Datelabeltip.Visible = false;
            }
        }

        private void OrderHistoryButton_Click(object sender, EventArgs e)
        {
            Variables.TempVariableN4 = "OrderHistory";
            OrderComponents OCHistory = new OrderComponents();
            OCHistory.ShowDialog();
        }
    }
}
