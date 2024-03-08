Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("Digite o valor da operação que deseja:");
    Console.WriteLine("1 - Soma:");
    Console.WriteLine("2 - Subtração:");
    Console.WriteLine("3 - Divisão:");
    Console.WriteLine("4 - Multiplicação:");
    Console.WriteLine("5 - Sair:");

    Console.WriteLine("-------------");
    Console.WriteLine("Sua opção é:");
    float operacao = float.Parse(Console.ReadLine());

    switch (operacao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 + v2;

    Console.WriteLine($"O resultado da soma é: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;

    Console.WriteLine($"O resultado da subtracao é: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro Valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;

    Console.WriteLine($"O resultado da multiplicação é: {resultado}");

    Console.ReadKey();
    Menu();
}