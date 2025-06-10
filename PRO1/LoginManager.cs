using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;

namespace PRO1
{
    public class LoginManager
    {
      
        public static bool Authenticate(string username, string password)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Users.xlsx");
            if (!File.Exists(filePath))
                return false;
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheets.First();
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1)) // מדלג על הכותרת
                {
                    string excelUsername = row.Cell(1).GetString();
                    string excelPassword = row.Cell(2).GetString();

                    if (username == excelUsername && password == excelPassword)
                        return true;
                }
            }

            return false;
        }
    }
}
  

