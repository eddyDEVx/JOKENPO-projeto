using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOKENPO_projeto
{
    internal class Program
    {
        static void BoasVindas()
        {
            Console.WriteLine("Bem vindo ao JOKENPO Buliçoso");
            Console.WriteLine("Agora diga-me seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", agora diga-me sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 15)
            {
                Console.WriteLine("Boa Jogatina😎.");
            }
            else
            {
                Console.WriteLine("Você não tem idade suficiente para jogar.");
                Console.WriteLine("Lhe esperamos em breve, " + nome + " até tiver a idade necessária😢.");
                BoasVindas();
            }
        }

        private static void Main(string[] args)
        {
            BoasVindas();
            Console.WriteLine("No mundo de TRELELEGVEN, existem 3 reinos");
            Console.WriteLine("Bureto: Um reino tranquilo e prospero, mas em contrapartida com um Rei malicioso e ardiloso chamado “Bulgar Olisio Bureto” ou BOB (ele odeia esse nome)");
            Console.WriteLine("MORIA: Um reino xenôfobico por inteiro com cidadãos que infelizmente possuem o Qi mais alto entre todos os reinos, tendo como rei na verdade uma rainha que se veste no masculino pelo machismo dos outros reinos assim facilitando propostas com outros reinos, cuja o nome é “Patrícia Moria Vanti” ou Ms. Moria  ");
            Console.WriteLine("LATESCO: Um reino equivalente a uma prisão onde pode ser encontrado os seres humanos mais perigosos de todo planeta junto com o comercio mais extravagante visto de todos os reinos, tendo um rei guerrilheiro que agora tem que aceitar as formas mais diplomáticas de resolver os conflitos” Tirino Vendeta Latesco” ou Sr Tirânio ")
            Console.WriteLine("Escolha seu tirano: ");
            Console.WriteLine("1 - Bob. Um Rei malicioso e ardiloso que sempre arruma um jeito de tirar vantagem" +
                " Habilidade= Desvio de Verba: Desvio de verba: A cada 2 partidas ele pode usar essa habilidade para roubar uma carta do jogador se ele tiver perdido uma rodada (Em compensação ele não pode ver qual é).");
            Console.WriteLine("2 - Ms Moria. Uma rainha poderosa com uma mente calculadora que sempre pensa duas vezes antes de agir."
                + " Mente inigualável: A cada 2 partidas ela pode ver as cartas do inimigo.");
            Console.WriteLine("3 - Sr Tirânio. Um veterano de guerra que de tantas vitorias, o povo decidiu que seria um bom rei para eles." + " Instinto de guerra: a cada 2 partidas ele pode destruir a carta do inimigo, mas ele não pode ver qual é a carta que ele destruiu.  ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bob | Ms. Moria | Sr. Tirânio");
          switch(escolha) {
          case 0: Console.WriteLine("Você escolheu o Bob");
              break;
          case 1: Console.WriteLine("Você escolheu a Ms. Moria");
              break;
          case 2: Console.WriteLine("Você escolheu o Sr. Tirânio");
              break;
                    int Pv_jogador = 10;
                    int Pv_inimigo = 10;
            }


            { 
            }
        }
    }
}