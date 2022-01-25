using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_26_interacting_with_excel
{

    class Program
    {
        static void Main(string[] args)
        {
            //create interop
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            //make the app visible
            excelApp.Visible = true;
            //add new workbook
            excelApp.Workbooks.Add();

            //obtain the active sheet from the app
            Microsoft.Office.Interop.Excel.Worksheet  worksheet= excelApp.ActiveSheet;

            //write into cells
            worksheet.Cells[1, "A"] = "hello";
            worksheet.Cells[1, "B"] = "from C#";
        }
    }
}
