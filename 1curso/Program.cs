//Menu options
string ShowBandMessage = "Digite 1 para registar uma banda";
string ListBandMessage = "Digite 2 para mostrar a lista de bandas";
string ExitAppMessage = "Digite -1 para sair"; 

string welcome_msg = "Boas vindas ao meu app";
string logo = @"
╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭╮
╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭╯╰╮
╭━━┳━━┳━┳━━┳━━┳━╮╱╭╮╭┳━━┳━┻╮╭╋━━┳━╮
┃━━┫╭━┫╭┫┃━┫┃━┫╭╮╮┃╰╯┃╭╮┃━━┫┃┃┃━┫╭╯
┣━━┃╰━┫┃┃┃━┫┃━┫┃┃┃┃┃┃┃╭╮┣━━┃╰┫┃━┫┃
╰━━┻━━┻╯╰━━┻━━┻╯╰╯╰┻┻┻╯╰┻━━┻━┻━━┻╯";

List<string> bandsList = new List<string>{"TTNG","Wulfpeck"};



void WelcomeUser()
{
    Console.WriteLine(welcome_msg);
}
void showLogo()
{
    Console.WriteLine(logo);
}

void MenuOptions()
{
    showLogo();
    Console.WriteLine(ShowBandMessage);
    Console.WriteLine(ListBandMessage);
    Console.WriteLine(ExitAppMessage);
    
    Console.Write("\nDigite a sua opção:");
    string CurrentOption = Console.ReadLine()!;
    int numCurrentOption = int.Parse(CurrentOption);
    ChooseOption(numCurrentOption);
    
}
void ChooseOption(int CurrentOption)
{
    switch(CurrentOption){
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowBand();
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case -1:
            break;
        default: Console.WriteLine("Opção Invalida");break;
    }
        
};

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("Digite o nome da banda a registar:");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Console.WriteLine($"A banda {bandName} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();
}

void ShowBand()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registadas");
//    for(int i = 0; i < bandsList.Count; i++)
//    {
//        Console.WriteLine($"Banda : {bandsList[i]}");
//    }
    foreach(string band in bandsList)
    {
        Console.WriteLine($"Banda: {band}");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    MenuOptions();

}

WelcomeUser();
MenuOptions();