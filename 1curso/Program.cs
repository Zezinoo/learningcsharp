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

void WelcomeUser()
{
    Console.WriteLine(logo);
    Console.WriteLine(welcome_msg);
}

void MenuOptions()
{
    Console.WriteLine(ShowBandMessage);
    Console.WriteLine(ListBandMessage);
    Console.WriteLine(ExitAppMessage);
    
    Console.Write("\nDigite a sua opção:");
    string CurrentOption = Console.ReadLine()!;
    int numCurrentOption = int.Parse(CurrentOption);
    
}
void ChooseOption(int CurrentOption)
{
    switch(CurrentOption){
        case 1:
            break;
        case 2:
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
