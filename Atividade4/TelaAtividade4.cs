using static System.Console;
using System.Collections.Generic;
using Teste.Atividade1;
using Teste.Atividade2;
namespace Teste.Atividade4
{
    public class TelaAtividade4
    {
        public void Tela()
        {
             while(true)
                  {
                  string Menu ="=============== LOJA DE PEÇAS 3D ===============" + "\nDigite o valor da compra: ";
                  WriteLine(Menu);

                        int Valor = int.Parse(ReadLine());

                        if (Valor >= 300 && Valor <= 2200)
                        {
                              int Desconto = Valor - 200;
                              int DescontoFinal = Desconto / 100;
                              int Resultado = (Valor * DescontoFinal) / 100;
                              int ValorFinal = Valor - Resultado;

                              WriteLine($"\nValor da compra: R${Valor}" + $"\n\nPorcentagem de desconto: {DescontoFinal}% de desconto no valor da compra." + $"\n\nValor Final: R${ValorFinal} Reais inclusos os {DescontoFinal}% de desconto.");
                        }
                        else if (Valor > 2200)
                        {
                              int ValorDesconto = (Valor * 20) / 100;
                              int ValorFinal = Valor - ValorDesconto;
                              WriteLine($"\nValor da compra: R${Valor}" + $"\n\nPorcentagem de desconto: 20% de desconto no valor da compra." + $"\n\nValor Final: R${ValorFinal} Reais inclusos os 20% de desconto.");
                        }
                        else if (Valor < 300)
                        {
                              WriteLine($"valor da compra: R${Valor}");
                              WriteLine("Infelizmente você não adquiriu descontos :(");
                        }
                        WriteLine("\nDeseja continuar similando testes no app de venda?   [S]Sim / [N]Nao");
                        string Saida = ReadLine();

                        if (Saida.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                        {
                              WriteLine("Obrigado por acessar a 'LOJA DE PEÇAS PEÇAS 3D'. Redirencionado você para o menu principal.");
                              break;
                        }
                  }
        }
    }
}