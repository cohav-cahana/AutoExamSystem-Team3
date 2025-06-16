using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ClosedXML.Excel;


namespace PRO1
{
    public class ValidationHelper
    {
        public static bool IsValidUsername(string username)
        {
            if (username.Length < 6 || username.Length > 8)
                return false;
            int digitCount = username.Count(char.IsDigit);
            int letterCount = username.Count(char.IsLetter);
            return digitCount <= 2 && (digitCount + letterCount == username.Length);
        }
        public static async Task<bool> IsUniqueUsernameAsync(string username, string excelFilePath, FirebaseHelper firebaseHelper)
        {
            List<string> excelUsernames = new List<string>();

            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet("Users");
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1))
                {
                    string existingUsername = row.Cell(1).GetValue<string>().Trim();
                    if (!string.IsNullOrEmpty(existingUsername))
                        excelUsernames.Add(existingUsername);
                }
            }

            if (excelUsernames.Contains(username))
                return false;

            var firebaseUsers = await firebaseHelper.GetAllUsersAsync(); // תוודאי שיש לך את המתודה הזו

            if (firebaseUsers.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
                return false;

            return true;
        }

        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,10}$");

        }

        public static bool IsValidID(string id)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(id, @"^\d{9}$");
        }
        public static bool IsUniqueID(string id, List<string> existingIDs)
        {
            return !existingIDs.Contains(id);
        }


        public static bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        
    }
}

