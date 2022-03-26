using static System.Console;
using System.Collections.Generic;
using Teste.Atividade1;
using Teste.Atividade2;
namespace Teste.Atividade2
{
    public class TelaAtividade2
    {
        public void Tela()
        {
            while(true)
                {
                        string Menu = "=============== CALCULADOR [IDADE/IMC] ==============="+
                        "\nSelecione uma das opções abaixo: "+
                        "\n\nPara saber a Idade. Pressione [1]"+
                        "\nPara saber o IMC. Pressione [2]"+
                        "\nPara Sair... Pressione [3]";
                        WriteLine(Menu);
                        int Opcao = int.Parse(ReadLine());
      

                        switch(Opcao)
                        {
                        case 1:
                        Idade Pessoa1 = new Idade();
                        Pessoa1.Mensagem();
                        Pessoa1.Calculo();
                        Pessoa1.MensagemFinal();
                        break;

                        case 2:
                        Imc Pessoa2= new Imc();
                        Pessoa2.Mensagem();
                        Pessoa2.Calculo();
                        Pessoa2.MensagemFinal();
                        break;

                        case 3:
                        WriteLine("Saindo...");
                        break;
                        }

                  WriteLine("\nDeseja continuar no app 'CALCULADOR'? [S]Sim/[N]Nao");
                  var Decisao = ReadLine();
                  
                        if (Decisao.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                        {          
                        WriteLine("Você acaba de utilizar o nosso calculador [IDADE/IMC], obrigado!. ");
                        break;
                        }     
                  
            }   
        }
    }
}