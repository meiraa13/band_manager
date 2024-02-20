// Screen Sound from Alura

string welcomeMessage = "Boas vindas ao Screen Sound";
List<string> bandList = new List<string>();

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
        case 3:BandRegister();
            break;
        case 4:BandRegister();
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
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);
    Console.WriteLine($"A banda {bandName} foi registrada!");
    Thread.Sleep(1500);
    Console.Clear();
    ShowOptionsMenu();
}

void ShowBands()
{
    
    Console.Clear();
    if (bandList.Count == 0)
    {
        Console.WriteLine("Não possui banda registrada, selecione a opção 1 para fazer o registro");
        Thread.Sleep(2000);
        Console.Clear();
        ShowOptionsMenu();
    }
    else
    {
        Console.WriteLine("Exibindo as bandas registradas");
        for (int i = 0; i < bandList.Count; i++) 
        {
            Console.WriteLine($"banda:{bandList[i]}");
        }
        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();

    }
}

ShowOptionsMenu();