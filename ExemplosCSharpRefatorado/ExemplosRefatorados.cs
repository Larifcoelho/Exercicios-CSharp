namespace ExemplosRefatorado;

/// <summary>
/// Versão refatorada dos exemplos originais.
/// Um único ponto de entrada (Main), sem métodos "Main" espalhados pelas classes.
/// Uso: dotnet run -- soma
///      dotnet run            (abre o menu interativo)
/// </summary>
internal static class Programa
{
    private static readonly (string Chave, string Descricao)[] Opcoes =
    {
        ("mensagem03", "Mensagem 03 - Olá"),
        ("mensagem04", "Mensagem 04 - Olá com nome"),
        ("soma", "Soma"),
        ("subtracao", "Subtração"),
        ("multiplicacao", "Multiplicação"),
        ("divisao", "Divisão"),
        ("simples", "Decisão simples"),
        ("composta", "Decisão composta"),
        ("encadeada", "Decisão encadeada"),
        ("switch", "Switch case - dia da semana"),
    };

    public static void Main(string[] args)
    {
        string escolha = args.Length > 0
            ? args[0].ToLowerInvariant()
            : EscolherInterativo();

        switch (escolha)
        {
            case "mensagem03": Mensagens.Ola(); break;
            case "mensagem04": Mensagens.OlaComNome("Jailson"); break;
            case "soma": Operacoes.Soma(); break;
            case "subtracao": Operacoes.Subtracao(); break;
            case "multiplicacao": Operacoes.Multiplicacao(); break;
            case "divisao": Operacoes.Divisao(); break;
            case "simples": Decisoes.Simples(); break;
            case "composta": Decisoes.Composta(); break;
            case "encadeada": Decisoes.Encadeada(); break;
            case "switch": DiaSemana.Executar(); break;
            default:
                Console.WriteLine($"Opção '{escolha}' desconhecida. Use uma das opções do menu.");
                break;
        }
    }

    private static string EscolherInterativo()
    {
        Console.WriteLine("Escolha um exemplo:");

        for (int i = 0; i < Opcoes.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {Opcoes[i].Descricao}");
        }

        int indice = Entrada.LerInteiro("Opção: ");

        return indice >= 1 && indice <= Opcoes.Length
            ? Opcoes[indice - 1].Chave
            : string.Empty;
    }
}

/// <summary>
/// Leitura de dados com validação, para não quebrar com letras ou Enter vazio.
/// </summary>
internal static class Entrada
{
    public static int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string? texto = Console.ReadLine();

            if (int.TryParse(texto, out int valor))
            {
                return valor;
            }

            Console.WriteLine("Valor inválido. Digite um número inteiro.");
        }
    }

    public static int LerIdade() => LerInteiro("Digite sua idade: ");
}

internal static class Mensagens
{
    public static void Ola()
    {
        Console.WriteLine("Olá");
    }

    public static void OlaComNome(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Aprenda a identificar os momentos felizes dentro do caos da sua vida.");
    }
}

internal static class Operacoes
{
    public static void Soma()
    {
        (int a, int b) = LerDoisNumeros("soma");
        Console.WriteLine($"O resultado entre: {a} + {b} = {a + b}");
    }

    public static void Subtracao()
    {
        (int a, int b) = LerDoisNumeros("subtração");
        Console.WriteLine($"O resultado entre: {a} - {b} = {a - b}");
    }

    public static void Multiplicacao()
    {
        (int a, int b) = LerDoisNumeros("multiplicação");
        Console.WriteLine($"O resultado entre: {a} X {b} = {a * b}");
    }

    public static void Divisao()
    {
        (int a, int b) = LerDoisNumeros("divisão");

        if (b == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return;
        }

        // Divisão inteira, igual ao exemplo original.
        // Para resultado com casas decimais, use double/decimal: (double)a / b.
        Console.WriteLine($"O resultado entre: {a} / {b} = {a / b}");
    }

    private static (int Primeiro, int Segundo) LerDoisNumeros(string operacao)
    {
        Console.WriteLine(char.ToUpperInvariant(operacao[0]) + operacao[1..]);

        int primeiro = Entrada.LerInteiro($"Digite o primeiro número para a {operacao}: ");
        int segundo = Entrada.LerInteiro($"Digite o segundo número para a {operacao}: ");

        return (primeiro, segundo);
    }
}

internal static class Decisoes
{
    public static void Simples()
    {
        Console.WriteLine("Programa de Decisão Simples");

        int idade = Entrada.LerIdade();

        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }

    public static void Composta()
    {
        Console.WriteLine("Estrutura de Decisão Composta");

        int idade = Entrada.LerIdade();
        Console.WriteLine(idade < 18 ? "Você é menor de idade." : "Você é maior de idade.");
    }

    public static void Encadeada()
    {
        Console.WriteLine("Estrutura de Decisão Encadeada");

        int idade = Entrada.LerIdade();

        if (idade < 16)
        {
            Console.WriteLine("Você não pode votar.");
        }
        else if (idade < 18)
        {
            Console.WriteLine("O voto é opcional.");
        }
        else
        {
            Console.WriteLine("Voto obrigatório.");
        }
    }
}

internal static class DiaSemana
{
    public static void Executar()
    {
        Console.WriteLine("Programa Switch Case");

        int dia = Entrada.LerInteiro("Digite um número de 1 a 7 e descubra o dia da semana: ");

        string mensagem = dia switch
        {
            1 => "Domingo",
            2 => "Segunda",
            3 => "Terça",
            4 => "Quarta",
            5 => "Quinta",
            6 => "Sexta",
            7 => "Sábado",
            _ => "Inválido. Digite novamente."
        };

        Console.WriteLine(mensagem);
    }
}
