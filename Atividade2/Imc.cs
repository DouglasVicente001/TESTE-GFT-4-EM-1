using static System.Console;
namespace Teste.Atividade2
{
    public class Imc : Idade
    {   
        double Peso,Altura,Resultado;
        public override void Mensagem()
        {
        WriteLine("Informe o peso: ");
        Peso = double.Parse(ReadLine());
        WriteLine("Insira a altura: ");
        Altura = double.Parse(ReadLine());
        }
        public override void Calculo()
        {
        Resultado = Peso/(Altura*Altura);
        }
        public override void MensagemFinal()
        {
        WriteLine($"O índice de massa corporal <IMC> é: {Resultado}");
        }
    }
}