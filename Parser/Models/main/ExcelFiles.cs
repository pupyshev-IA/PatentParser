using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Parser.UI;
using System.Runtime.InteropServices;

namespace Parser.Models.main
{
    public class ExcelFiles
    {
        FileExplorer fileExplorer;
        string specialChar = "\\|/?»:«*\"<>";

        public ExcelFiles() 
        {
            fileExplorer = FileExplorer.getInstance();
        }

        public void CreateExcelFile(Dictionary<string, List<string>> forExcel, string filePath, string fileName)
        {
            Excel.Application app;
            Excel._Workbook workBook;
            Excel._Worksheet workSheet;

            try
            {
                app = new Excel.Application();
                app.Visible = false;

                workBook = app.Workbooks.Add(Missing.Value);
                workSheet = (Excel._Worksheet)workBook.ActiveSheet;

                int column = 1;
                foreach (KeyValuePair<string, List<string>> kvp in forExcel)
                {
                    int row = 1;
                    workSheet.Cells[row, column] = kvp.Key;
                    foreach (string el in kvp.Value)
                    {
                        workSheet.Cells[++row, column] = el;
                    }
                    column++;
                }

                workBook.SaveAs(filePath + fileName + ".xlsx");

                fileExplorer.UpdateFileExplorer();
                fileExplorer.SelectNewFile(fileName);

                workBook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workBook);
                Marshal.ReleaseComObject(app);
            }
            catch
            {

            }
            finally
            {

            }
        }

        public bool CheckFileName(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (var item in specialChar)
                {
                    if (fileName.Contains(item))
                    {
                        return false;
                    }
                }
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}
