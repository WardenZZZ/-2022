using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic;


namespace Diplom
{
    public partial class ExportMenu : Form
    {
        string Filepath;

        public ExportMenu()
        {
            InitializeComponent();
            this.Text = "Меню экспорта";

        }

        private void TableChooseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database DB = new Database();
            DB.openConnection();
            switch (TableChooseCB.Text)
            {
                case "База товаров":
                    Notelabel.Visible = true;
                    Notelabel2.Visible = true;
                    this.Size = new Size(578, 412);
                    Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                    "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                    "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype";

                    var MySQLQueryBaseMenu = new SqlQueryCommand();

                    MySQLQueryBaseMenu.QueryForGridFill(PreviewdataGridView);

                    FilterCheckbox1.Text = "Комплектующие";
                    FilterCheckbox2.Text = "Периферия";
                    /*FilterCheckbox3.Text = "По возрастанию в цене";
                    FilterCheckbox4.Text = "По убыванию в цене";
                    FilterCheckbox5.Text = "По возрастанию в количестве";
                    FilterCheckbox6.Text = "По убыванию в количестве";*/

                    FilterCheckbox1.Tag = " AND m.id_maintype = 1";
                    FilterCheckbox2.Tag = " AND m.id_maintype = 2";
                    /*FilterCheckbox3.Tag = " ORDER BY mainprice ASC";
                    FilterCheckbox4.Tag = " ORDER BY mainprice DESC";
                    FilterCheckbox5.Tag = " ORDER BY mainamount ASC";
                    FilterCheckbox6.Tag = " ORDER BY mainamount DESC";*/

                    FilterCheckbox1.Visible = true;
                    FilterCheckbox2.Visible = true;
                    /*FilterCheckbox3.Visible = true;
                    FilterCheckbox4.Visible = true;
                    FilterCheckbox5.Visible = true;
                    FilterCheckbox6.Visible = true;*/



                    break;

                case "Заказы":
                    Variables.SqlQuery = "SELECT o.id_order AS `Идентификатор заказа`, o.ordernumber AS `Номер заказа`, m.mainname AS `Название товара`, " +
                        "mt.maintypename AS `Тип товара`, od.orderdetailsamount AS `Количество товара в заказе`, od.orderdetailsprice AS `Стоимость товара` FROM " +
                        "orders o, mainbase m, maintype mt, orderdetails od WHERE od.id_order = o.id_order AND od.id_main = m.id_main AND m.id_maintype = mt.id_maintype";
                    this.Size = new Size(439, 412);
                    Notelabel.Visible = false;
                    Notelabel2.Visible = false;
                    FilterCheckbox1.Visible = false;
                    FilterCheckbox2.Visible = false;
                    var MySQLQueryOrder = new SqlQueryCommand();

                    MySQLQueryOrder.QueryForGridFill(PreviewdataGridView);
                    break;

                case "Пункты выдачи":
                    Notelabel.Visible = true;
                    Notelabel2.Visible = true;
                    Variables.SqlQuery = "SELECT w.id_warehouse AS `Идентификатор склада/магазина`, wt.warehousetypename AS `Склад или магазин`, w.warehouseaddress AS `Адрес`, " +
                    "w.warehouseincharge AS `Ответственный за склад/магазин` FROM warehouse w, warehousetype wt WHERE w.id_warehousetype = wt.id_warehousetype";

                    var MySQLQueryWarehouse = new SqlQueryCommand();

                    MySQLQueryWarehouse.QueryForGridFill(PreviewdataGridView);

                    this.Size = new Size(578, 412);

                    FilterCheckbox1.Text = "Склад";
                    FilterCheckbox2.Text = "Магазин";

                    FilterCheckbox1.Tag = " AND w.id_warehousetype = 1";
                    FilterCheckbox2.Tag = " AND w.id_warehousetype = 2";

                    FilterCheckbox1.Visible = true;
                    FilterCheckbox2.Visible = true;

                    break;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Word.Document oDoc = new Word.Document();
            folderBrowserDialog1.ShowDialog();
            Filepath = folderBrowserDialog1.SelectedPath;
            string UserAnswer = Interaction.InputBox("Введите название экспортируемого документа.", "Название документа", "");
            try
            {
                int RowCount = PreviewdataGridView.Rows.Count;
                int ColumnCount = PreviewdataGridView.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = PreviewdataGridView.Rows[r].Cells[c].Value;
                    }
                }

                oDoc.Application.Visible = false;

                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = PreviewdataGridView.Columns[c].HeaderText;
                }
                oDoc.Application.Selection.Tables[1].set_Style("Таблица-сетка 4");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Отчёт по таблице " + TableChooseCB.Text;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                oDoc.SaveAs2(Path.Combine(Filepath, UserAnswer));


                oDoc.Close();
                Word.Application ioi = new Word.Application();
                ioi.Quit();
                MessageBox.Show("Данные таблицы " + TableChooseCB.Text + " были успешно экспортированы в документ с названием " + UserAnswer + ", по пути " + Filepath);
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("WINWORD"))
                    {
                        proc.Kill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выделили таблицу для экспорта.");
            }


        }

        private void FilePathButton_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QueryTag(string Filters)
        {
            Variables.SqlQuery += Filters;
        }

        public void CheckBoxChecked(System.Windows.Forms.CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                QueryTag(Convert.ToString(checkBox.Tag));

                var MySQLQueryFiltered = new SqlQueryCommand();

                MySQLQueryFiltered.QueryForGridFill(PreviewdataGridView);
            }
        }

        private void FilterCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(FilterCheckbox1);
            FilterCheckbox1.Enabled = false;
            FilterCheckbox2.Enabled = false;
        }

        private void FilterCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChecked(FilterCheckbox2);
            FilterCheckbox2.Enabled = false;
            FilterCheckbox1.Enabled = false;
        }

        private void ResetFilters_Click(object sender, EventArgs e)
        {
            switch (TableChooseCB.Text)
            {
                case "База товаров":
                    Variables.SqlQuery = "SELECT m.id_main AS `Номер товара`, m.mainname AS `Название товара`, mt.maintypename AS `Тип товара`, m.mainamount AS `Количество`, " +
                    "m.mainprice AS `Стоимость за штуку`, w.warehouseaddress AS `Где располагается товар` FROM mainbase m, maintype mt, warehouse w, warehousetype wt " +
                    "WHERE m.id_maintype = mt.id_maintype AND m.id_warehouse = w.id_warehouse AND w.id_warehousetype = wt.id_warehousetype";
                    var MySQLQueryReset = new SqlQueryCommand();
                    MySQLQueryReset.QueryForGridFill(PreviewdataGridView);
                    UncheckBoxes();
                    break;

                case "Заказы":
                    break;

                case "Пункты выдачи":
                    Variables.SqlQuery = "SELECT w.id_warehouse AS `Идентификатор склада/магазина`, wt.warehousetypename AS `Склад или магазин`, w.warehouseaddress AS `Адрес`, " +
                    "w.warehouseincharge AS `Ответственный за склад/магазин` FROM warehouse w, warehousetype wt WHERE w.id_warehousetype = wt.id_warehousetype";
                    var MySQLQueryWarehouse = new SqlQueryCommand();
                    MySQLQueryWarehouse.QueryForGridFill(PreviewdataGridView);
                    UncheckBoxes();
                    break;
            }
            

        }

        private void UncheckBoxes()
        {
            FilterCheckbox1.Checked = false;
            FilterCheckbox2.Checked = false;
            FilterCheckbox3.Checked = false;
            FilterCheckbox4.Checked = false;
            FilterCheckbox5.Checked = false;
            FilterCheckbox6.Checked = false;

            FilterCheckbox1.Enabled = true;
            FilterCheckbox2.Enabled = true;
            FilterCheckbox3.Enabled = true;
            FilterCheckbox4.Enabled = true;
            FilterCheckbox5.Enabled = true;
            FilterCheckbox6.Enabled = true;

        }

        private void ShowDGVForExportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
