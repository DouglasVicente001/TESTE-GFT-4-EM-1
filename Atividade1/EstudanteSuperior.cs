using static System.Console;
namespace Teste.Atividade1
{
      public class EstudanteSuperior : BaseAluno
      {
            public override void AlunoInfo()
            {
                WriteLine("Digite o nome do aluno: ");
                Nome = ReadLine();
                WriteLine("Digite a matricula do aluno: ");
                Matricula = ReadLine();
                WriteLine("Insira a escola: ");
                Escola = ReadLine();
                WriteLine($"Informe a universidade cursada pelo aluno: {Nome}");
                Universidade = ReadLine();
            }

            public override void Mensagem()
            {
                   WriteLine($"\n\nEscola do aluno: {Nome}"+ $"\nMatricula: {Matricula}"+$"\nEscola: {Escola}"+$"\nUniversidade: {Universidade}");
            }
      }
}