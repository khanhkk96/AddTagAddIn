using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ReplaceAddIn
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnSelectSource_Click(object sender, RibbonControlEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.xls|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cboTags.Items.Clear();
                string filePath = dialog.FileName;

                Excel.Application xlApp = null;
                Excel.Workbook xlWorkbook = null;
                Excel._Worksheet xlWorksheet = null;
                Excel.Range xlRange = null;
                try
                {
                    xlApp = new Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(filePath);
                    //int sheet = 1;
                    string sheetName = "BBKP";
                    sheetName = cboTemplate.Text ?? sheetName;
                    xlWorksheet = xlWorkbook.Sheets[sheetName];
                    xlRange = xlWorksheet.UsedRange;
                    for (int j = 1; j <= xlRange.Rows.Count; j++)
                    {
                        RibbonDropDownItem item = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                        item.Label = xlRange.Cells[j, 1].Value2.ToString();
                        cboTags.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //release com objects to fully kill excel process from running in the background
                    if (xlRange != null)
                    {
                        Marshal.ReleaseComObject(xlRange);
                    }
                    if (xlWorksheet != null)
                    {
                        Marshal.ReleaseComObject(xlWorksheet);
                    }

                    //close and release
                    if (xlWorkbook != null)
                    {
                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);
                    }

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }
        }

        private void btnSelectTag_Click(object sender, RibbonControlEventArgs e)
        {
            var Application = Globals.ThisAddIn.Application;
            int start = Application.Selection.Range.Start;
            int end = Application.Selection.Range.End;
            Word.Range rng = Application.ActiveDocument.Range(start, end);
            rng.Select();
            string selectedTag = cboTags.Text;
            if (selectedTag != "")
            {
                string value = selectedTag.Trim();
                rng.Text = value;
                return;
            }
            rng.Text = "";
        }
    }
}
