// Screen Sound from Alura

string welcomeMessage = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>(); 
void ShowWelcomeMessage()
{   

    Console.WriteLine(welcomeMessage);

}

void ShowOptionsMenu()
{
    ShowWelcomeMessage();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digete 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int numberOption = int.Parse(chosenOption);

    switch (numberOption)
    {
        case 1:BandRegister();
            break;
        case 2:ShowBands();
            break;
        case 3:RateBand();
            break;
        case 4:ShowBandAverage();
            break;
        case -1:Console.WriteLine("Obrigado por usar o Screen Sound");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void BandRegister()
{
    Console.Clear();
    ShowTitle("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, []);
    Console.WriteLine($"A banda {bandName} foi registrada!");
    Thread.Sleep(1000);
    Console.Clear();
    ShowOptionsMenu();
}

void ShowBands()
{
    
    Console.Clear();
    if (registeredBands.Count == 0)
    {
        Console.WriteLine("Não possui banda registrada, selecione a opção 1 para fazer o registro");
        Thread.Sleep(2000);
        Console.Clear();
        ShowOptionsMenu();
    }
    else
    {
        ShowTitle("Exibindo todas as bandas");
        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"- {band}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();

    }
}

void ShowTitle(string title)
{
    int letterCount = title.Length;
    char star = '*';
    string stars = string.Empty.PadLeft(letterCount, star);
    Console.WriteLine(stars);
    Console.WriteLine(title);
    Console.WriteLine(stars + "\n");
}

void RateBand()
{
    Console.Clear();
    ShowTitle("Avalie a banda");
    Console.Write("Digite a banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        Console.WriteLine("Digite uma nota para a banda");
        int rating = int.Parse(Console.ReadLine()!);
        registeredBands[bandName].Add(rating);
        Console.WriteLine("\nNota atribuída com sucesso!");
        Thread.Sleep(1500);
        Console.Clear();
        ShowOptionsMenu();

    }else
    {
        Console.WriteLine("Banda não encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();
    }

}

void ShowBandAverage()
{
    Console.Clear();
    ShowTitle("Média da banda");
    Console.Write("Digite a banda que deseja ver a média: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        Console.WriteLine("Digite uma nota para a banda");
        double average = registeredBands[bandName].Average();
        Console.WriteLine($"a média de {bandName} é {average}");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();

    }
    else
    {
        Console.WriteLine("Banda não encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();
    }



}

ShowOptionsMenu();