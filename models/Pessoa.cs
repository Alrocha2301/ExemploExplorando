using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {

        public Pessoa()
        {}

        public Pessoa(string Nome, string Sobrenome, int Idade)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Idade = Idade;
        }

        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();

            set
            {
                if (value == "") 
                {
                    throw new ArgumentException ("O nome não pode ser vazio!");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 

        public int Idade 
        {
            get =>_idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException ("Idade não deve ser negativa!");
                }

                _idade = value;
            }
        }
        

        public void Apresentar() {
            Console.WriteLine($"Nome: {NomeCompleto} - Idade: {Idade} anos.");
        }
    }
}