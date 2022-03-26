using static System.Console;
using System.Collections.Generic;
using Teste.Atividade3;
using Teste.Atividade1;
using Teste.Atividade2;
using Teste.Atividade4;

namespace Teste.MenuPrincipal
{
    public class Menu
    {
        public void TelaPrincipal()
        {
            while(true)
            {
                string Mensagem = "=============== PROGRAMAS DE TESTE GFT START ==============="+
                "\nSelecione um dos testes abaixo para utilizar: "+
                "\nPara acessar programa TESTE 1 (ESCOLA DE ALUNOS) Pressione [1]"+
                "\nPara acessar programa TESTE 2 (CALCULO-IMC-IDADE) Pressione [2]"+
                "\nPara acessar programa TESTE 3 (ENTREGA DE CORRESPONDÊNCIAS) Pressione [3]"+
                "\nPara acessar programa TESTE 4 (LOJA DE VENDAS- PEÇAS 3D) Pressione [4]"+
                "\nPara sair do programa de (TESTES GFT START). Pressione[0]";
                  
                WriteLine(Mensagem);
                  
                int Opcao = int.Parse(ReadLine());
                if (Opcao ==0)
                {
                WriteLine("Espero que tenha apreciado os testes da GFT com sucesso. Obrigado!!!");
                break;
                }
                    else if (Opcao ==1)

                {
                TelaAtividade1 Teste1 = new TelaAtividade1();
                Teste1.Tela();
                }
                    else if (Opcao ==2)
                {
                TelaAtividade2 Teste2 = new TelaAtividade2();
                Teste2.Tela();
                }
                if (Opcao ==3)
                {
                TelaAtividade3 Teste3 = new TelaAtividade3();
                Teste3.Tela();
                }
                else if (Opcao ==4)
                {
                TelaAtividade4 Teste4 = new TelaAtividade4();
                Teste4.Tela();
                }
                else
                {
                WriteLine("Esta opção não e válida! Retornaremos você para o menu principal...");
                }
            
            WriteLine("Deseja continuar analisando os Testes GFT Start? [S]Sim / [N]Nao");
                var Saida = ReadLine();
                  
                if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                {     
                        WriteLine("Espero que tenha apreciado os testes da GFT com sucesso. Obrigado!!!");
                        break;
                }
                
            }
        }
    }
}