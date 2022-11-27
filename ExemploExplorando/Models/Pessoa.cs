using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploExplorando.Models
{
    // Classe
    public class Pessoa
    {   
        // Campo de armazenamento
        private string _nome; 
        private int _idade;

        // Propriedades
        public string Nome 
        {   
            // Obter o valor com tratamento de letra maúscula.
            get => _nome.ToUpper();
          
            // Atribui o valor
            set
            {   
                // Tratar valor nulo
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        //propriedade somente leitura (get)
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero !");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
