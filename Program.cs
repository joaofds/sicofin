using System;
using Models;
using Core;

public class Program
{
    static int menu = 1;
    static Usuario usuario = new Usuario();

    static void Main()
    {

        // Se usuario ainda não fez o cadastro ou login.
        if (!usuario.logged)
        {
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Seja Bem Vindo!                                               |");
        Begin:
            Console.WriteLine("+---------------------------------------------------------------+");
            Console.WriteLine("| Para acessar o sistema você precisa se cadastrar antes.       |");
            Console.WriteLine("| Deseja fazer isso agora? s - (sim), n - (não)                 |");
            Console.WriteLine("+---------------------------------------------------------------+");

            var option = Console.ReadLine();
            // Termina programa.
            if (option == "n")
            {
                Console.Clear();
                Console.WriteLine("Infelizmente não é possível acessar o sistema sem um cadastro.");
                Console.WriteLine("Pressione qualquer botão para sair...");
                Console.ReadKey();
                return;
            }
            else if (option == "s")
            {
                // Cadastrar novo usuario.
                novoUsuario();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, tente novamente...");
                goto Begin;
            }
        }

        // se usuario fez login entra aqui.
        if (usuario.logged)
        {
            while (menu > 0)
            {
                Console.Clear();
                Console.WriteLine($"Olá {usuario.nome}, Seja Bem Vindo!");
                Console.WriteLine("");
                Console.WriteLine("+---------------------------------------------------------------+");
                Console.WriteLine("| Escolha uma opção no menu abaixo...                           |");
                Console.WriteLine("+---------------------------------------------------------------+");
                Console.WriteLine("| O que deseja fazer agora?                                     |");
                Console.WriteLine("| Menu aqui                                                     |");
                Console.WriteLine("+---------------------------------------------------------------+");

                menu = int.Parse(Console.ReadLine()!);

                if (menu == 1)
                {
                    //
                }
            }
        }
    }

    /*
    * Cadastrar Usuário.
    *
    */
    static void novoUsuario()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de usuário...");

        //Usuario usuario = new Usuario();
        Console.WriteLine("Ótimo, primeiro queremos saber qual seu primeiro nome.");
        usuario.nome = Helpers.SanitizeString(Console.ReadLine()!);

        Console.WriteLine("Agora um email para acessar o sistema.");
    EMAIL:
        usuario.email = Console.ReadLine();
        if (!Helpers.IsValidEmail(usuario.email!))
        {
            Console.WriteLine("Email inválido, insira um endereço de email válido.");
            goto EMAIL;
        }

        Console.WriteLine("Já estamos finalizando... Digite uma senha.");
        usuario.password = Console.ReadLine()!;

        Console.Clear();
        login();
    }

    /*
    * Rotina para efetuar login no sistema.
    *
    */
    static void login()
    {
        string email = "";
        string senha = "";

    Login:
        Console.WriteLine("+---------------------------------------------------------------+");
        Console.WriteLine("| Login                                                         |");
        Console.WriteLine("+---------------------------------------------------------------+");

        Console.WriteLine("Email:");
        email = Console.ReadLine()!;

        Console.WriteLine("Senha:");
        senha = Console.ReadLine()!;
        if (usuario.isLogged(email, senha))
        {
            Main();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Email ou senha incorretos, tente novamente...");
            goto Login;
        }
    }
}