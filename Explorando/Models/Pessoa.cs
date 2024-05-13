using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Pessoa
    {
        public Pessoa() // Podemos ter dois, um que não recebe e outro com argumentos
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtores
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Descontruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        // Criamos a string _nome, que servirá de validação para a variavél Nome
        private string _nome; 
        private int _idade;
        public string Nome
        { 
            get => _nome;
            // get => _nome.ToUpper(); // Aqui é uma forma mais simples de representar, para validações simples.
            set 
            {
                if (value =="") // Chamamos a validação
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // Lembrar que isso finaliza o programa
                }            
                _nome = value; // Aqui atribuimos o valor ao Nome
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Não vou setar nada pois já existe o nome e sobrenome. Ou seja, read-only.
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value < 0 )
                {
                    throw new ArgumentException("Idade não pode ser menor que 0.");
                }

                _idade = value;
            }
        }

        public void ChamaModel()
        {
            Console.WriteLine($"{NomeCompleto} {Idade}");
        }
        
        
    }
}