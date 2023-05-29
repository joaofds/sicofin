using System;
using Models;
using Core;

public class Program
{
    static int menu = 1;
    static Usuario usuario = new Usuario();
    static int selected;

    static void Main()
    {
        // remover após os testes
        usuario.logged = true;

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
                Helpers.MakeMenu(usuario.nome!, "Dashboard", "Escolha uma opção abaixo...");
                selected = ConsoleHelper.MultipleChoice(false, "Finanças", "Cartões");

                // receitas/despesas.
                if (selected == 0)
                {
                    Helpers.MakeMenu(usuario.nome!, "Finanças", "Gerenciamento de Finanças.");
                    selected = ConsoleHelper.MultipleChoice(true, "Cadastrar Receita", "Cadastrar Despesa", "Listar Todas");
                    switch (selected)
                    {
                        case 0:
                        case 1:
                            novaEntradaFinanceira(selected);
                            break;
                        case 2:
                            // listar finaças;
                            break;
                    }
                }

                // cartões.
                if (selected == 1)
                {
                    Helpers.MakeMenu(usuario.nome!, "Cartões", "Gerenciamento de Cartões.");
                    selected = ConsoleHelper.MultipleChoice(true, "Cadastrar Cartão", "Deletar Cartão", "Listar Cartões");
                    switch (selected)
                    {
                        case 0:
                            //novoCartao();
                            break;
                        case 1:
                            //removeCartao();
                            break;
                    }
                }
            }
        }
    }

    /*
    * Cadastro de receitas e despesas do usuário.
    *
    */
    static void novaEntradaFinanceira(int? opt = null)
    {

        Helpers.MakeMenu(usuario.nome!, "Finanças", opt == 0 ? "Cadastrar Receita." : "Cadastrar Despesa.");
        Console.WriteLine("Descrição: ");
        string descricao = Console.ReadLine()!;

    Valor:
        Console.WriteLine("Valor em R$: ");
        float valor;
        if (!float.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Insira um valor válido...");
            goto Valor;
        }

        Financa entradaFin = new Financa(1, descricao, valor);
        usuario.financas.Add(entradaFin);

        Console.Clear();
        Console.WriteLine("Sucesso!");
        Console.WriteLine("Deseja Cadastrar outra? s - (sim)");

        var option = Console.ReadLine();
        if (option == "s")
        {
            novaEntradaFinanceira(opt == 0 ? 0 : 1);
        }
    }

    static void novoCartao()
    {
        Helpers.MakeMenu(usuario.nome!, "Finanças", "Cadastrar Cartão.");
        Console.ReadLine();
    }

    /*
    * Cadastrar Usuário.
    *
    */
    static void novoUsuario()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de usuário...");

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

        // armazena arquivo de senha de usuario (AQUI TEMOS SEGURANÇA ZERO kkkkkk).
        // Só fiz pra aprender manipular arquivos e diretorios.
        FileStorage.createFolderAndFile("users", usuario.email!, ".dat", usuario.password);

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