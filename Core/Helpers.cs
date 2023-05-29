using System.Text;
using System.Text.RegularExpressions;

namespace Core
{
    public class Helpers
    {
        /* 
        * Monta menu dinamicamente.
        *
        */
        public static void MakeMenu(string usuario, string menu, string mensagem)
        {
            int len = mensagem.Length;
            int totalChars = 62 - len;
            string chars = string.Concat(Enumerable.Repeat(" ", totalChars));

            Console.Clear();
            Console.WriteLine($"{menu} | Olá{(usuario == "" ? "," : " " + usuario + ",")} Seja Bem Vindo!");
            Console.WriteLine("");
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine($"| {mensagem}{chars}|");
            Console.WriteLine("+---------------------------------------------------------------+");
        }

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