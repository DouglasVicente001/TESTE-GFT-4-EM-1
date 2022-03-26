using static System.Console;
namespace Teste.Atividade1
{
    public class NaoEstudante : BaseAluno
    {
    public override void AlunoInfo()
    {
        WriteLine("Digite o nome do aluno: ");
        Nome = ReadLine();
        WriteLine("Digite a matricula do aluno: ");
        Matricula = ReadLine();
    }
    public override void Mensagem()
    {
        WriteLine($"\n\nEscola do aluno: {Nome}"+ $"\nMatricula: {Matricula}");
    }

    }
}