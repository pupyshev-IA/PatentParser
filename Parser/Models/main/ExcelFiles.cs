using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using IronXL;

namespace Parser.Models.main
{
    public class ExcelFiles
    {
        public void CreateExcelFile(Dictionary<string, List<string>> forExcel)
        {
            Excel.Application app;
            Excel._Workbook wb;
            Excel._Worksheet ws;

            try
            {
                app = new Excel.Application();
                app.Visible = true;

                wb = app.Workbooks.Add(Missing.Value);
                ws = (Excel._Worksheet)wb.ActiveSheet;

                int column = 1;
                foreach (KeyValuePair<string, List<string>> kvp in forExcel)
                {
                    int row = 1;
                    ws.Cells[row, column] = kvp.Key;
                    foreach (string el in kvp.Value)
                    {
                        ws.Cells[++row, column] = el;
                    }
                    column++;
                }

                
            }
            catch
            {

            }
        }
    }
}
