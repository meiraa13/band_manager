// Screen Sound from Alura
using band_manager.Models;

Band ira = new("Ira!");
ira.AddGrade(10);
ira.AddGrade(6);
Band beatles = new("The Beatles");
beatles.AddGrade(9);
beatles.AddGrade(7);

string welcomeMessage = "Boas vindas ao Screen Sound 2.0";
Dictionary<string, Band> registeredBands = new();
registeredBands.Add(ira.Name, ira);
registeredBands.Add(beatles.Name, beatles);

void ShowWelcomeMessage()
{   

    Console.WriteLine(welcomeMessage);

}

void ShowOptionsMenu()
{
    ShowWelcomeMessage();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o album de uma banda");
    Console.WriteLine("Digete 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int numberOption = int.Parse(chosenOption);

    switch (numberOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            RegisterAlbum();
            break;
        case 3:
            ShowBands();
            break;
        case 4:
            RateBand();
            break;
        case 5:
            ShowBandAverage();
            break;
        case -1:
            Console.WriteLine("Obrigado por usar o Screen Sound");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    ShowTitle("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    Band band = new Band(bandName);
    registeredBands.Add(bandName, band);
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
        Band band = registeredBands[bandName];
        Console.WriteLine("Digite uma nota para a banda");
        int rating = int.Parse(Console.ReadLine()!);
        band.AddGrade(rating);
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
        Band band = registeredBands[bandName]; 
        Console.WriteLine($"a média de {bandName} é {band.Average}");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();

    }
    else
    {
        Console.WriteLine("Banda não encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }
    ShowOptionsMenu();


}

void RegisterAlbum()
{
    Console.Clear();
    ShowTitle("Registro de albuns");
    Console.Write("Digite a banda cujo album deseja registrar: ");
    string bandName = Console.ReadLine()!;
    if(registeredBands.ContainsKey(bandName))
    {
        Console.Write("Agora digite o nome do album: ");
        string albumName = Console.ReadLine()!;
        Band band = registeredBands[bandName];
        band.AddAlbum(new Album(albumName));
        Console.WriteLine($"o album {albumName} da {bandName} foi registrado!");
        Thread.Sleep(1000);
        Console.Clear();
    }else
    {
        Console.WriteLine("Banda não encontrada!");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }



    ShowOptionsMenu();
}


ShowOptionsMenu();