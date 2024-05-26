using DesafioPOO.Models;
while (true)
{
    Console.WriteLine("Selecione seu smartphone:");
    Console.WriteLine("1 - iPhone");
    Console.WriteLine("2 - Nokia");

    int celular = int.Parse(Console.ReadLine());

    string numero, modelo, imei, nomeApp;
    int memoria;

    Console.WriteLine("Digite o número do smartphone:");
    numero = Console.ReadLine();

    Console.WriteLine("Digite o modelo do smartphone:");
    modelo = Console.ReadLine();

    Console.WriteLine("Digite o IMEI do smartphone:");
    imei = Console.ReadLine();

    Console.WriteLine("Digite a memória do smartphone:");
    memoria = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o nome do aplicativo a ser instalado:");
    nomeApp = Console.ReadLine();

    Smartphone smartphone = null;


    switch (celular)
    {
        case 1:
            smartphone = new Iphone(numero, modelo, imei, memoria);
            break;
        case 2:
            smartphone = new Nokia(numero, modelo, imei, memoria);
            break;
        default:
            Console.WriteLine("Opção inválida. Escolha 1 para iPhone ou 2 para Nokia.");
            continue; // Skip to the next iteration of the loop
    }



    smartphone.Ligar();


    smartphone.InstalarAplicativo(nomeApp);

    Console.WriteLine("Pressione qualquer tecla para escolher outro smartphone...");
    Console.ReadKey();
    Console.Clear();
}