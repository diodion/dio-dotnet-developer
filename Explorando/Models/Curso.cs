using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno) // void não retorna
        {
            Alunos.Add(aluno);
        }
        
        public int ObterQuantidadeMatriculados()
        {
            int quantidade = Alunos.Count;

            return quantidade;
        }

        public bool RemoverAluno (Pessoa aluno)
        {
            return Alunos.Remove(aluno);  // O metodo de remover ja retorna booleano, logo podemos colocar o return nele.
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}