using static System.Console;
namespace Teste.Atividade2
{
    public class Idade
    {
        int AnoAtual,AnoNasci,Resultado;
        
        public virtual void Mensagem()
        {
            WriteLine("Informe a data de nascimento: ");
            AnoNasci = int.Parse(ReadLine());

            WriteLine("Insira o ano atual: ");
            AnoAtual = int.Parse(ReadLine());
        }   
        public virtual void Calculo()
        {
            Resultado = AnoAtual - AnoNasci;
        }
        public virtual void MensagemFinal()
        {
            WriteLine($"A sua idade é: {Resultado} anos.");
        }
        
    }
}