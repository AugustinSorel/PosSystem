using System;
using System.Windows.Forms;

namespace PosSystem
{
    class Excel
    {
        public static void ListViewSaveToExcel(ListView listView)
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application { Visible = true };
            var wb = ExcelApp.Workbooks.Add(1);
            var ws = wb.Worksheets[1];
            int Columns = 1;
            int Rows = 1;
            foreach (ListViewItem lvi in listView.Items)
            {
                Columns = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[Rows, Columns] = lvs.Text;
                    Columns++;
                }
                Rows++;
            }
        }

        public static void DataGridViewSaveTOExcel(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = xcelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets[1];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "CustomerDetail";

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                xcelApp.Columns.AutoFit();
                var saveFileDialoge = new SaveFileDialog { FileName = "Stock", DefaultExt = ".xlsx" };

                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                }
                xcelApp.Quit();
            }
        }
    }
}
