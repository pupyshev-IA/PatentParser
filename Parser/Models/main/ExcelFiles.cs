using System;
using System.Collections.Generic;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Parser.UI;
using System.Runtime.InteropServices;
using System.IO;

namespace Parser.Models.main
{
    public class ExcelFiles
    {
        FileExplorer fileExplorer;

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

                workBook.SaveAs(Path.GetFullPath(filePath) + fileName + ".xlsx");


                Marshal.ReleaseComObject(workSheet);

                workBook.Close();
                Marshal.ReleaseComObject(workBook);
                
                app.Quit();
                Marshal.ReleaseComObject(app);

                fileExplorer.UpdateFileExplorer();
                fileExplorer.SelectNewFile(fileName);
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
