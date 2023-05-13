using System.Text;
using System.Text.RegularExpressions;

namespace Core
{
    public class Helpers
    {
        /* 
        * Remove caracteres inválidos de uma string.
        *
        */
        public static string SanitizeString(string str)
        {
            return Regex.Replace(str, @"[^\w\.@-]", "");
        }

        /*
        * Validação de email.
        *
        */
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}