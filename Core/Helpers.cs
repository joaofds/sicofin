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
    }
}