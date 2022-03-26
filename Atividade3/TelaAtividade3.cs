using static System.Console;
using System.Collections.Generic;
using Teste.Atividade1;
using Teste.Atividade2;
using Teste.Atividade4;
using Teste.Atividade3;

namespace Teste.Atividade3
{
    public class TelaAtividade3 
    {
        
        public void Tela()
        {   
            

            while (true)
            {
            string Menu = "=============== CARTEIRO MEDROSO ==============="+
            "\nPara as casas que existem cachorro, pressione [0] Para correr! ";
            WriteLine(Menu);

            var Moradores= new List<Morador>();
            Moradores.Add(new Morador("21322",1544));
            Moradores.Add(new Morador("23432",1543));
            Moradores.Add(new Morador("23233",2054));
            Moradores.Add(new Morador("5667",1877));
            Moradores.Add(new Morador("965567",1987));
            Moradores.Add(new Morador("567567",799));

            int CasaImparEntregue = 0;
                  foreach (var morador in Moradores)
                  {
                        WriteLine($"A casa de numero {morador.NmrCasaInfo()} tem cachorro? Pressione [0]Sim / [1]Nao\n");
                        var cachorro = int.Parse(ReadLine());
                        if (cachorro ==1)
                        {
                        WriteLine($"\nA correspondência foi entregue na casa de nº {morador.NmrCasaInfo()}");
                        if (morador.NmrCasaInfo() % 2 == 1)
                        {
                        CasaImparEntregue = CasaImparEntregue +1;
                        }
                        }
                        else 
                        {
                        WriteLine("Você não entregou a correspondência e foi para a próxima casa!\n");
                        }

                  }
                  WriteLine($"\nO numero de casas ímpares em que as correspondências foram entregues é: {CasaImparEntregue}");
            WriteLine("Deseja continuar no app 'CARTEIRO MEDROSO'?    [S]Sim / [N]Nao");
            var Saida = ReadLine();
            if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine("Você acaba de percorrer com nosso carteiro medroso! Voltando ao Menu principal...\n");
                break;
            }
            }
        }
    }
}