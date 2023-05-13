using Models;
using Core;

public class Program
{
    static int menu = 1;
    static void Main()
    {
        Usuario usuario = new Usuario();

        // Se usuario ainda não fez o cadastro.
        if (!usuario.logged)
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Olá, Seja Bem Vindo!                                          |");
        Begin:
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Para acessar o sistema você precisa se cadastrar antes.       |");
            Console.WriteLine("| Deseja fazer isso agora? s - (sim), n - (não)                 |");
            Console.WriteLine("+---------------------------------------------------------------+");

            var option = Console.ReadLine();
            // Termina programa.
            if (option == "n")
            {
                Console.WriteLine("Ok.. até mais. ;)");
                return;
            }
            else if (option == "s")
            {
                // Cadastrar novo usuario.
                //novoUsuario();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, tente novamente...");
                goto Begin;
            }
        }
        else
        {
            while (menu > 0)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("Escolha uma opção...");
                Console.WriteLine("=====================================================");

                menu = int.Parse(Console.ReadLine()!);

                if (menu == 1)
                {
                    //
                }
            }
        }
    }
}