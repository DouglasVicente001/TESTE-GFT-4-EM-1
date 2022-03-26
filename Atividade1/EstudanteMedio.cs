using static System.Console;
namespace Teste.Atividade1
{
      public class EstudanteMedio : BaseAluno
      {
            public override void AlunoInfo()
            {
                WriteLine("Digite o nome do aluno: ");
                Nome = ReadLine();
                WriteLine("Digite a matricula do aluno: ");
                Matricula = ReadLine();
                WriteLine("Insira a escola: ");
                Escola = ReadLine();
            }

            public override void Mensagem()
            {
                   WriteLine($"\n\nEscola do aluno: {Nome}"+ $"\nMatricula: {Matricula}"+$"\nEscola: {Escola}");
            }
      }
}