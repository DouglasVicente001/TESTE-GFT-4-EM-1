using static System.Console;
using System.Collections.Generic;
using Teste.Atividade1;
namespace Teste.Atividade1
{
    public class TelaAtividade1
    {
        public void Tela()
        {
            while(true)
            {
                        
                  string Menu = "=============== ESCOLA ==============="+
                  "\nDigite qual o perfil do aluno: "+
                  "\n\n\n[Sair] : Pressione [0]"+
                  "\nAluno de ensino básico: Pressione [1]"+
                  "\nAluno de ensino médio: Pressione [2]"+
                  "\nAluno de ensino superior: Pressione [3]";
                  WriteLine(Menu);
                  int Opcao = int.Parse(ReadLine());
                  if (Opcao == 0)
                  {     
                        WriteLine("Saindo..."+"\nObrigado por utilizar nossos serviços escolares.");
                        break;
                  }
                  else if (Opcao == 1)
                  {     
                        NaoEstudante Aluno1 = new NaoEstudante(); 
                        Aluno1.AlunoInfo();
                        Aluno1.Mensagem();
                  }
                  else if(Opcao == 2)
                  {
                        EstudanteMedio  Aluno2 = new EstudanteMedio();
                        Aluno2.AlunoInfo();
                        Aluno2.Mensagem();
                  }
                  else if(Opcao == 3)
                  {
                        EstudanteSuperior  Aluno3 = new EstudanteSuperior();
                        Aluno3.AlunoInfo();
                        Aluno3.Mensagem();
                  }
                  else
                  {
                        WriteLine("Infore uma opção válida!"+"\nRetornando você para Menu.");
                  }
            
            WriteLine ("\nDeseja continuar inserindo alunos no app 'ESCOLA'? [S]Sim/[N]Nao");
            string Saida = ReadLine();
            if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
            {     
                  WriteLine("Saindo..."+"\nObrigado por utilizar nossos serviços escolares.");
                  break;
            }

            }     
        }
    }
}