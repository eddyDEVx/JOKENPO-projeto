using System;

namespace JOKENPO_projeto

{

    internal class Program

    {

        static void BoasVindas()

        {

            while (true)

            {

                Console.WriteLine("Bem vindo ao JOKENPO Buliçoso");

                Console.WriteLine("Agora diga-me seu nome:");

                string nome = Console.ReadLine();

                Console.WriteLine("Olá " + nome + ", agora diga-me sua idade:");

                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 15)

                {

                    Console.WriteLine("Boa Jogatina.");

                    Console.WriteLine("Pressione ENTER para continuar...");

                    Console.ReadLine();

                    Console.Clear();

                    break;

                }

                else

                {

                    Console.WriteLine("Você não tem idade suficiente para jogar.");

                    Console.WriteLine("Lhe esperamos em breve, " + nome + " até tiver a idade necessária.");

                    Console.Clear();

                }

            }

        }

        static string NomeCarta(int carta)

        {

            switch (carta)

            {

                case 1:

                    return "Rei";

                case 2:

                    return "Rainha";

                case 3:

                    return "Bruxa";

                case 4:

                    return "Bispo";

                case 5:

                    return "Demónio";

                default:

                    return "Carta inválida";

            }

        }

        static int VerificarVencedor(int jogador, int inimigo)

        {

            // 0 = empate

            // 1 = jogador venceu

            // -1 = inimigo venceu

            if (jogador == inimigo)

            {

                return 0;

            }

            // Rei ganha de Bruxa e Bispo

            if (jogador == 1 && (inimigo == 3 || inimigo == 4))

            {

                return 1;

            }

            // Rainha ganha de Rei e Bispo

            if (jogador == 2 && (inimigo == 1 || inimigo == 4))

            {

                return 1;

            }

            // Bruxa ganha de Rainha e Demónio

            if (jogador == 3 && (inimigo == 2 || inimigo == 5))

            {

                return 1;

            }

            // Bispo ganha de Demónio e Bruxa

            if (jogador == 4 && (inimigo == 5 || inimigo == 3))

            {

                return 1;

            }

            // Demónio ganha de Rei e Rainha

            if (jogador == 5 && (inimigo == 1 || inimigo == 2))

            {

                return 1;

            }

            // Se não empatou e o jogador não ganhou,

            // então o inimigo ganhou.

            return -1;

        }

        private static void Main(string[] args)

        {

            BoasVindas();

            Console.WriteLine("No mundo de TRELELEGVEN, existem 3 reinos");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Bureto: Um reino tranquilo e prospero, mas em contrapartida com um Rei malicioso e ardiloso chamado “Bulgar Olisio Bureto” ou BOB (ele odeia esse nome)");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("MORIA: Um reino xenôfobico por inteiro com cidadãos que infelizmente possuem o Qi mais alto entre todos os reinos, tendo como rei na verdade uma rainha que se veste no masculino pelo machismo dos outros reinos assim facilitando propostas com outros reinos, cuja o nome é “Patrícia Moria Vanti” ou Ms. Moria");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("LATESCO: Um reino equivalente a uma prisão onde pode ser encontrado os seres humanos mais perigosos de todo planeta junto com o comercio mais extravagante visto de todos os reinos, tendo um rei guerrilheiro que agora tem que aceitar as formas mais diplomáticas de resolver os conflitos “Tirino Vendeta Latesco” ou Sr Tirânio");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Os 3 reis presunçosos e narcisistas decidem que as guerras que decidiriam a vitória seriam feitos por um jogo inventado por um bobo da corte que se chama “RAINHA, REI, BRUXA, BISPO E DEMÓNIO”.");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Escolha seu tirano:");

            Console.WriteLine();

            Console.WriteLine("1 - Bob. Um Rei malicioso e ardiloso que sempre arruma um jeito de tirar vantagem.");

            Console.WriteLine("Habilidade = Desvio de Verba: A cada 2 partidas ele pode usar essa habilidade para roubar uma carta do jogador se ele tiver perdido uma rodada. Em compensação ele não pode ver qual é.");

            Console.WriteLine();

            Console.WriteLine("2 - Ms Moria. Uma rainha poderosa com uma mente calculadora que sempre pensa duas vezes antes de agir.");

            Console.WriteLine("Habilidade = Mente inigualável: A cada 2 partidas ela pode ver as cartas do inimigo.");

            Console.WriteLine();

            Console.WriteLine("3 - Sr Tirânio. Um veterano de guerra que de tantas vitórias, o povo decidiu que seria um bom rei para eles.");

            Console.WriteLine("Habilidade = Instinto de guerra: a cada 2 partidas ele pode destruir a carta do inimigo, mas ele não pode ver qual é a carta que ele destruiu.");

            Console.WriteLine();

            int escolha;

            do

            {

                Console.Write("Digite sua escolha: ");

                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha < 1 || escolha > 3)

                {

                    Console.WriteLine("Escolha inválida. Digite 1, 2 ou 3.");

                }

            } while (escolha < 1 || escolha > 3);

            Console.Clear();

            Console.WriteLine("Você escolheu:");

            switch (escolha)

            {

                case 1:

                    Console.WriteLine("Bob");

                    break;

                case 2:

                    Console.WriteLine("Ms. Moria");

                    break;

                case 3:

                    Console.WriteLine("Sr. Tirânio");

                    break;

            }

            Console.WriteLine("----------------------------");

            Console.WriteLine("         1 PARTIDA");

            Console.WriteLine("----------------------------");

            Console.WriteLine();

            Console.WriteLine("MAS PERAIIIIIIIIIIIIIIIIII...");

            Console.WriteLine();

            Console.WriteLine("Vamos passar por um pequeno tutorial:");

            Console.WriteLine();

            Console.WriteLine("Antes de começar, iremos lhe ensinar o básico do jogo.");

            Console.WriteLine("O jogo é simples, funciona como um corta-papel e tesoura.");

            Console.WriteLine("Porém, temos 5 tipos de opções (cartas), sendo elas:");

            Console.WriteLine();

            Console.WriteLine("1 - Rei");

            Console.WriteLine("2 - Rainha");

            Console.WriteLine("3 - Bruxa");

            Console.WriteLine("4 - Bispo");

            Console.WriteLine("5 - Demónio");

            Console.WriteLine();

            Console.WriteLine("Cada carta perde e ganha de 2 outras cartas:");

            Console.WriteLine("Rei ganha de Bruxa/Bispo e perde para Rainha/Demónio");

            Console.WriteLine("Rainha ganha de Rei/Bispo e perde para Demónio/Bruxa");

            Console.WriteLine("Bruxa ganha de Rainha/Demónio e perde para Rei/Bispo");

            Console.WriteLine("Bispo ganha de Demónio/Bruxa e perde para Rainha/Rei");

            Console.WriteLine("Demónio ganha de Rei/Rainha e perde para Bispo/Bruxa");

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para começar...");

            Console.ReadLine();

            Console.Clear();

            int Vitoria = 0;

            int Derrota = 0;

            int Empate = 0;

            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("         1 PARTIDA");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("Escolha seu tirano:");
                Console.WriteLine();
                Console.WriteLine("1 - Bob. Um Rei malicioso e ardiloso que sempre arruma um jeito de tirar vantagem.");
                Console.WriteLine("Habilidade = Desvio de Verba: A cada 2 partidas ele pode usar essa habilidade para roubar uma carta do jogador se ele tiver perdido uma rodada. Em compensação ele não pode ver qual é.");
                Console.WriteLine();
                Console.WriteLine("2 - Ms Moria. Uma rainha poderosa com uma mente calculadora que sempre pensa duas vezes antes de agir.");
                Console.WriteLine("Habilidade = Mente inigualável: A cada 2 partidas ela pode ver as cartas do inimigo.");
                Console.WriteLine();
                Console.WriteLine("3 - Sr Tirânio. Um veterano de guerra que de tantas vitórias, o povo decidiu que seria um bom rei para eles.");
                Console.WriteLine("Habilidade = Instinto de guerra: a cada 2 partidas ele pode destruir a carta do inimigo, mas ele não pode ver qual é a carta que ele destruiu.");
                Console.WriteLine();
            }

            Random random = new Random();

            // 3 rodadas

            for (int rodada = 1; rodada <= 3; rodada++)

            {

                Console.WriteLine("----------------------------");

                Console.WriteLine("        RODADA " + rodada);

                Console.WriteLine("----------------------------");

                Console.WriteLine();

                Console.WriteLine("Escolha uma carta:");

                Console.WriteLine("1 - Rei");

                Console.WriteLine("2 - Rainha");

                Console.WriteLine("3 - Bruxa");

                Console.WriteLine("4 - Bispo");

                Console.WriteLine("5 - Demónio");

                int cartas;

                do

                {

                    Console.Write("Sua escolha: ");

                    cartas = Convert.ToInt32(Console.ReadLine());

                    if (cartas < 1 || cartas > 5)

                    {

                        Console.WriteLine("Carta inválida. Escolha uma carta de 1 a 5.");

                    }

                } while (cartas < 1 || cartas > 5);

                Console.WriteLine();

                Console.WriteLine("Você escolheu: " + NomeCarta(cartas));

                // O computador escolhe uma carta de 1 até 5

                int escolhaInimigo = random.Next(1, 6);

                Console.WriteLine("O inimigo escolheu: " + NomeCarta(escolhaInimigo));

                Console.WriteLine();

                int resultado = VerificarVencedor(cartas, escolhaInimigo);

                if (resultado == 1)

                {

                    Console.WriteLine("Você venceu a rodada!");

                    Vitoria++;

                }

                else if (resultado == -1)

                {

                    Console.WriteLine("Você perdeu a rodada!");

                    Derrota++;

                }

                else

                {

                    Console.WriteLine("Empate!");

                    Empate++;

                }

                Console.WriteLine();

                Console.WriteLine("Placar atual:");

                Console.WriteLine("Vitórias: " + Vitoria);

                Console.WriteLine("Derrotas: " + Derrota);

                Console.WriteLine("Empates: " + Empate);

                Console.WriteLine();

                if (rodada < 3)

                {

                    Console.WriteLine("Pressione ENTER para a próxima rodada...");

                    Console.ReadLine();

                    Console.Clear();

                }

            }

            Console.Clear();

            Console.WriteLine("----------------------------");

            Console.WriteLine("         FIM DE JOGO");

            Console.WriteLine("----------------------------");

            Console.WriteLine();

            Console.WriteLine("Vitórias: " + Vitoria);

            Console.WriteLine("Derrotas: " + Derrota);

            Console.WriteLine("Empates: " + Empate);

            Console.WriteLine();

            if (Vitoria > Derrota)

            {

                Console.WriteLine("PARABÉNS! Você venceu a partida!");

            }

            else if (Derrota > Vitoria)

            {

                Console.WriteLine("Você perdeu a partida!");

                return;

            }

            else

            {

                Console.WriteLine("A partida terminou empatada!");

                return;


            }

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para proxima partida...");

            Console.ReadLine();

            Console.Clear();

            
        }
    }    
}