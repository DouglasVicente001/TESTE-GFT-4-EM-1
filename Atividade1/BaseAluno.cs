namespace Teste.Atividade1
{
    public abstract class BaseAluno
    {
        public string Nome;
        public string Matricula;
        public string Escola;
        public string Universidade;
        public abstract void AlunoInfo();
        public abstract void Mensagem();
    }
}