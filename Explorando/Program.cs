using Explorando.Models;

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


