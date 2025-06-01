using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace PRO1
{
    public class ValidationHelper
    {
        public static bool IsValidUsername(string username)
        {
            return username.Length >= 6 && username.Length <= 8 &&
                   System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9]{6,8}$");
        }

        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,10}$");

        }

        public static bool IsValidID(string id)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(id, @"^\d{9}$");
        }

        public static bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        
    }
}

