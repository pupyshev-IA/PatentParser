using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;

namespace Parser.Models.main
{
    public class ExcelFiles
    {
        public bool CreateExcelFile(Dictionary<string, List<string>> forExcel, string filePath, string fileName)
        {
            if (!forExcel["Название"].Any())
                return false;

            Excel.Application app = new Excel.Application();
            app.Visible = false;

            Excel._Workbook workBook = app.Workbooks.Add(Missing.Value);
            Excel._Worksheet workSheet = (Excel._Worksheet)workBook.ActiveSheet;

            try
            {
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

                workBook.SaveAs(Path.GetFullPath(filePath) + fileName + ".xlsx");
            }
            finally
            {
                Marshal.ReleaseComObject(workSheet);

                workBook.Close();
                Marshal.ReleaseComObject(workBook);

                app.Quit();
                Marshal.ReleaseComObject(app);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return true;
        }
    }
}
