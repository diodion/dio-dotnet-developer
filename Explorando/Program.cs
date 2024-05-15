using Explorando.Models;
using Newtonsoft.Json;



/* LeituraArquivo arquivo = new();

var(sucesso, linhas, _ ) = arquivo.LerArquivo("files/Leitura.txt"); // Aqui estou fazendo descarte da QtdLinhas com o _ no lugar do QtdLinhas

if (sucesso)
{
    // Console.WriteLine($"Linhas: {QtdLinhas}");
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não Foi possível ler");
} */

/* (int Id, string Nome, string Sobrenome, decimal Valor) tupla = (1, "Leopardo", "Jandira", 10.5M);

Console.WriteLine(tupla.Id); */



/* Dictionary<string, string> estados = new Dictionary<string, string>(); // Valores devem ser únicos

estados.Add("SP", "São Paulo");
estados.Add("CE", "Ceará");
estados.Add("RS", "Rio Grande do Sul");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA"); // Remove só utilizando a chave
estados["SP"] = "São Paulo - Alterado"; // Altera o valor de uma chave

string chave = "BA";

if(estados.ContainsKey(chave)) // Verifica se existe antes de adicionar por exemplo
{
    // Do something
} */

/* Stack<int> pilha = new Stack<int>();

pilha.Push(5);
pilha.Push(7);
pilha.Push(8);
pilha.Push(1);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo: {pilha.Pop()}"); // Vai remover sempre o ultimo que adicionou, e também retorna qual removeu

pilha.Push(30);

foreach(int item in pilha)
{
    Console.WriteLine(item);
} */

/* //FIFO
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(3);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue(); // Não declaramos pois sempre sairá o primeiro a entrar
 */

/* try {
    string[] linhas = File.ReadAllLines("files/Leitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Erro generico. {ex.Message}");
}
finally
{
    Console.WriteLine("Executo sempre colega.");
} */

/* using Explorando.Models;

Pessoa p1 = new Pessoa("James", "Arrabujura");
Pessoa p2 = new Pessoa(nome: "Teo", sobrenome: "Arrabujura"); // Passo para ficar mais claro


Curso cursoDeIngles = new Curso
{
    Nome = "Inglês",
    Alunos = new List<Pessoa>()
};

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

 */
