using System;
using System.Collections.Generic;
using ExemploExplorando.Models;

namespace ExemploExplorando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Já atribuindo o valor na hora de criar o objeto.
            //Pessoa p1 = new Pessoa() { Nome = "Antônio", Idade = 56, Sobrenome =  "Airton"};
            //Pessoa p2 = new Pessoa();

            //p2.Nome = "Vinicius";
            //p2.Sobrenome = "José";
            //p2.Idade = 34;

            //// chamando o método
            //p1.Apresentar();
            //p2.Apresentar();

            // Pessoa, chamando o construtor

            Pessoa p1 = new Pessoa("Osvaldo", "Paiol");
            Pessoa p2 = new Pessoa(nome:"Eduarda", sobrenome:"Martilho"); // Deixando explícito
            

            // Curso

            Curso cursoDeIngles = new Curso(); // criando o objeto
            cursoDeIngles.Nome = "Inglês"; // nome do curso
            cursoDeIngles.Alunos = new List<Pessoa>(); // criando a lista vazia

            // Adicionando aluno
            cursoDeIngles.AdicionarAluno(p1);
            cursoDeIngles.AdicionarAluno(p2);

            cursoDeIngles.ListarAlunos();

            // Chamando o Desconstrutor

            (string nome, string sobrenome) = p1;

            Console.WriteLine($"{nome} {sobrenome}");

            
            
            Console.ReadKey();
        }
    }
}
