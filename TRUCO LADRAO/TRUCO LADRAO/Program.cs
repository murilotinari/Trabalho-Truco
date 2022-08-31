using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUCO_LADRAO
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Esse jogo foi criado por: \n\nAndré Vitor Pereira Cini --   RA: 081200039\n\nGustavo Peterlini de Oliveira --  RA: 081200046\n\nMurilo Tinari Abdalla --  RA: 081200012\n\n\n");

            Console.WriteLine("Para jogar ative o CAPS LOCK e para ir para a proxima jogada aperte ENTER");
   
            int PontosPC = 0, PontosJog = 0, rodada = 0;
            
            do
            {
                
                Console.WriteLine("Aperte ENTER para a rodada iniciar.");
                Console.ReadLine();
                Console.Clear();
                rodada++;
                Random rndNum = new Random();
                int[] cartasGeradas = new int[14];
                int x = 0, y = 0;
                string[] naipes = { "Ouro", "Espadas", "Coração", "Paus" };
                for (x = 0; x < 13; x += 2)
                {
                    cartasGeradas[x] = rndNum.Next(0, 10);

                    cartasGeradas[x + 1] = rndNum.Next(0, 3);

                    for (int z = 0; z < 13; z += 2)
                    {
                        if ((x > 1 && x != z - 2) && (y != z - 1) && (z >= 2))
                        {
                            if (cartasGeradas[x] == cartasGeradas[z - 2] && cartasGeradas[x + 1] == cartasGeradas[z - 1])
                            {
                                x -= 2;
                                y -= 2;
                            }
                        }
                    }
                }
                string maode11;
                string[] cartas = new string[11];
                //Console.WriteLine("{0}{1}", cartasGeradas[0], cartasGeradas[1]);
                //Console.WriteLine("{0}{1}  {2}{3}  {4}{5}", cartasGeradas[2], cartasGeradas[3], cartasGeradas[4], cartasGeradas[5], cartasGeradas[6], cartasGeradas[7]);
                //Console.WriteLine("{0}{1}  {2}{3}  {4}{5}", cartasGeradas[8], cartasGeradas[9], cartasGeradas[10], cartasGeradas[11], cartasGeradas[12], cartasGeradas[13]);

                if (cartasGeradas[0] == 0)
                {
                    cartas[0] = "4"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "5";
                }

                if (cartasGeradas[0] == 1)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "6";
                }

                if (cartasGeradas[0] == 2)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "7";
                }

                if(cartasGeradas[0] == 3)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "Q";
                }

                if (cartasGeradas[0] == 4)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "J";
                }

                if (cartasGeradas[0] == 5)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "K";
                }

                if (cartasGeradas[0] == 6)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "A";
                }

                if (cartasGeradas[0] == 7)
                {
                   cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "3"; cartas[9] = "2";
                }

                if (cartasGeradas[0] == 8)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3";
                }

                if (cartasGeradas[0] == 9)
                {
                    cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3"; cartas[10] = "4";
                    for(x=0; x<11; x+=2)
                    {
                        if (cartasGeradas[x] == 0)
                        {
                            cartasGeradas[x] = 10;
                        }
                    }
                }

                string[] vira = { cartas[cartasGeradas[0]], naipes[cartasGeradas[1]] };
                string[] carta1Jog = { cartas[cartasGeradas[2]], naipes[cartasGeradas[3]] };
                string[] carta2Jog = { cartas[cartasGeradas[4]], naipes[cartasGeradas[5]] };
                string[] carta3Jog = { cartas[cartasGeradas[6]], naipes[cartasGeradas[7]] };
                string[] carta1Pc = { cartas[cartasGeradas[8]], naipes[cartasGeradas[9]] };
                string[] carta2Pc = { cartas[cartasGeradas[10]], naipes[cartasGeradas[11]] };
                string[] carta3Pc = { cartas[cartasGeradas[12]], naipes[cartasGeradas[13]] };
                int[] cartasJogador = { cartasGeradas[2], cartasGeradas[4], cartasGeradas[6] };
                int[] naipesJogador = { cartasGeradas[3], cartasGeradas[5], cartasGeradas[7] };

                int acumulador = 0;
                int[] calculoCartaPC = { cartasGeradas[8], cartasGeradas[10], cartasGeradas[12] };
                int[] calculoNaipePC = { cartasGeradas[9], cartasGeradas[11], cartasGeradas[13] };
                int[] maiorCarta = new int[2];
                int[] menorCarta = new int[2];
                int[] mediaCarta = new int[2];


                for (x = 0; x < 3; x++)
                {

                    acumulador = 0;
                    for (y = 0; y < 3; y++)
                    {
                        if (calculoCartaPC[x] > calculoCartaPC[y])
                            acumulador++;
                        else if (calculoCartaPC[x] == calculoCartaPC[y])
                        {
                            if (calculoNaipePC[x] > calculoNaipePC[y])
                                acumulador++;
                        }
                    }
                    if (acumulador == 2)
                    {
                        maiorCarta[0] = calculoCartaPC[x];
                        maiorCarta[1] = calculoNaipePC[x];
                        continue;
                    }

                    if (acumulador == 1)
                    {
                        mediaCarta[0] = calculoCartaPC[x];
                        mediaCarta[1] = calculoNaipePC[x];
                        continue;
                    }


                    menorCarta[0] = calculoCartaPC[x];
                    menorCarta[1] = calculoNaipePC[x];

                }
                //Console.WriteLine("{0} {1} {2}" ,cartasGeradas[8], cartasGeradas[10], cartasGeradas[12]);

                //Console.WriteLine("Maior {0}{1}   Media {2}{3}  Menor {4}{5}", cartas[maiorCarta[0]], naipes[maiorCarta[1]], cartas[mediaCarta[0]], naipes[mediaCarta[1]], cartas[menorCarta[0]], naipes[menorCarta[1]]);


                int[] cartasPc = { maiorCarta[0], mediaCarta[0], menorCarta[0] };
                int[] naipesPc = { maiorCarta[1], mediaCarta[1], menorCarta[1] };

                int pontojogada = 1;

                if (PontosJog == 11 && PontosPC == 11)
                {
                    Console.WriteLine("\nA mão de ferro irá começar.");
                    Console.WriteLine("\nVoçê nao pode ver suas cartas e jogará no escuro");
                    Console.WriteLine("\nEscolha a primeira carta a ser jogada.(1/2/3)");
                    int cartajogada1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Agora escolha qual carta o Pc vai jogar. (1/2/3)");
                    int cartajogada1pc = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada1 - 1], naipesJogador[cartajogada1 - 1]);
                    Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada1pc - 1], naipesPc[cartajogada1pc - 1]);
                    int cartajogada2 = 0, cartajogada2pc = 0, cartajogada3 = 0, cartajogada3pc = 0;

                    if (cartasJogador[cartajogada1 - 1] > cartasPc[cartajogada1pc - 1])
                    {
                        Console.WriteLine("\nVoce ganhou a primeira jogada. ");
                        Console.WriteLine("\nDigite qual carta quer jogar.");
                        cartajogada2 = naoRepetirCarta1(cartajogada1, cartajogada2);

                        Console.WriteLine("\nAgora digite qual carta quer que o Pc jogue.");
                        cartajogada2pc = naoRepetirCarta1(cartajogada1pc, cartajogada2pc);
                        Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada2 - 1], naipesJogador[cartajogada2 - 1]);
                        Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada2pc - 1], naipesPc[cartajogada2pc - 1]);

                        if (cartasJogador[cartajogada2 - 1] > cartasPc[cartajogada2pc - 1])
                        {
                            Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                            PontosJog++;
                            continue;
                        }
                        else if (cartasJogador[cartajogada2 - 1] < cartasPc[cartajogada2pc - 1])
                        {
                            Console.WriteLine("\nPC ganhou esta jogada.");
                            Console.WriteLine("\nDigite qual carta quer que o Pc jogue.");
                            cartajogada3pc = naoRepetirCarta2(cartajogada1pc, cartajogada2pc, cartajogada3pc);

                            Console.WriteLine("\nAgora digite qual carta quer jogar");
                            cartajogada3 = naoRepetirCarta2(cartajogada1, cartajogada2, cartajogada3);

                            Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada3pc - 1], naipesPc[cartajogada3pc - 1]);
                            Console.WriteLine("\nVocê jogou: {0}{1}", cartasJogador[cartajogada3 - 1], naipesJogador[cartajogada3 - 1]);

                            if (cartasJogador[cartajogada3 - 1] > cartasPc[cartajogada3pc - 1])
                            {
                                Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                PontosJog++;
                                continue;
                            }
                            else if (cartasJogador[cartajogada3 - 1] < cartasPc[cartajogada3pc - 1])
                            {
                                Console.WriteLine("\nPuts, você perdeu a última rodada.");
                                PontosPC++;
                                continue;
                            }
                            else
                            {// terminar caso seja manilla
                                if (cartasJogador[cartajogada3 - 1] >= 9)
                                {
                                    if (naipesPc[cartajogada3pc - 1] > naipesJogador[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else if (naipesPc[cartajogada3pc - 1] < naipesJogador[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEmpate! Logo, você ganhou a última rodada.");
                                    PontosJog++;
                                    continue;
                                }

                            }

                        }
                        else
                        {
                            if (cartasJogador[cartajogada2 - 1] >= 9)
                            {
                                if (naipesPc[cartajogada2pc - 1] > naipesJogador[cartajogada2 - 1])
                                {
                                    Console.WriteLine("\nPc ganhou essa jogada.");
                                    Console.WriteLine("\nEscolha uma carta para o pc jogar.");
                                    cartajogada3pc = naoRepetirCarta2(cartajogada1pc, cartajogada2pc, cartajogada3pc);

                                    Console.WriteLine("\n Agora escolha uma carta para voçê jogar.");
                                    cartajogada3 = naoRepetirCarta2(cartajogada1, cartajogada2, cartajogada3);

                                    Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada3 - 1], naipesPc[cartajogada3 - 1]);
                                    Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada3 - 1], naipesJogador[cartajogada3 - 1]);

                                    if (cartasJogador[cartajogada3 - 1] > cartasPc[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                    else if (cartasJogador[cartajogada3 - 1] < cartasPc[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else
                                    {
                                        if (cartasJogador[cartajogada3 - 1] >= 9)
                                        {
                                            if (naipesPc[cartajogada3pc - 1] < naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                                PontosJog++;
                                                continue;
                                            }
                                            else if (naipesPc[cartajogada3pc - 1] > naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                                PontosPC++;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nEmpate! Logo, você ganhou a última rodada.");
                                                PontosJog++;
                                                continue;
                                            }

                                        }

                                    }

                                }
                                else if (naipesPc[cartajogada2pc - 1] < naipesJogador[cartajogada2 - 1])
                                {
                                    Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                    PontosJog++;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate! Logo, você ganhou a última rodada.");
                                PontosJog++;
                                continue;
                            }


                        }
                    }
                    else if (cartasJogador[cartajogada1 - 1] < cartasPc[cartajogada1pc - 1]) 
                    {


                        Console.WriteLine("\nVoce perdeu a primeira jogada. ");
                        Console.WriteLine("\nDigite qual carta quer que o Pc jogue.");
                        cartajogada2pc = naoRepetirCarta1(cartajogada1pc, cartajogada2pc);

                        Console.WriteLine("\nAgora digite qual carta quer jogar");
                        cartajogada2 = naoRepetirCarta1(cartajogada1, cartajogada2);
                        Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada2pc - 1], naipesPc[cartajogada2pc - 1]);
                        Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada2 - 1], naipesJogador[cartajogada2 - 1]);

                        if (cartasJogador[cartajogada2 - 1] < cartasPc[cartajogada2pc - 1])
                        {
                            Console.WriteLine("\nPuts, Voce perdeu a ultima rodada.");
                            PontosPC++;
                            continue;
                        }
                        else if (cartasJogador[cartajogada2 - 1] > cartasPc[cartajogada2pc - 1])
                        {
                            Console.WriteLine("\nVoce ganhou esta jogada.");
                            Console.WriteLine("\nAgora digite qual carta quer jogar");
                            cartajogada3 = naoRepetirCarta2(cartajogada1, cartajogada2, cartajogada3);

                            Console.WriteLine("\nDigite qual carta quer que o Pc jogue.");
                            cartajogada3pc = naoRepetirCarta2(cartajogada1pc, cartajogada2pc, cartajogada3pc);

                            Console.WriteLine("\nVocê jogou: {0}{1}", cartasJogador[cartajogada3 - 1], naipesJogador[cartajogada3 - 1]);
                            Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada3pc - 1], naipesPc[cartajogada3pc - 1]);
                            
                            if (cartasJogador[cartajogada3 - 1] < cartasPc[cartajogada3pc - 1])
                            {
                                Console.WriteLine("\nPuts, Voce perdeu a ultima rodada.");
                                PontosPC++;
                                continue;
                            }
                            else if (cartasJogador[cartajogada3 - 1] > cartasPc[cartajogada3pc - 1])
                            {
                                Console.WriteLine("\nParabén! Voce ganhou a ultima rodada.");
                                PontosJog++;
                                continue;
                            }
                            else
                            {// terminar caso seja manilla
                                if (cartasJogador[cartajogada3 - 1] >= 9)
                                {
                                    if (naipesPc[cartajogada3pc - 1] > naipesJogador[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else if (naipesPc[cartajogada3pc - 1] < naipesJogador[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEmpate! Logo, PC ganhou a última rodada.");
                                    PontosPC++;
                                    continue;
                                }

                            }

                        }
                        else
                        {
                            if (cartasJogador[cartajogada2 - 1] >= 9)
                            {
                                if (naipesPc[cartajogada2pc - 1] > naipesJogador[cartajogada2 - 1])
                                {
                                    Console.WriteLine("\nVocê ganhou essa jogada.");
                                    Console.WriteLine("\nAgora escolha uma carta para voçê jogar.");
                                    cartajogada3 = naoRepetirCarta2(cartajogada1, cartajogada2, cartajogada3);
                                    Console.WriteLine("\nEscolha uma carta para o pc jogar.");
                                    cartajogada3pc = naoRepetirCarta2(cartajogada1pc, cartajogada2pc, cartajogada3pc);
                                    Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada3 - 1], naipesJogador[cartajogada3 - 1]);
                                    Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada3 - 1], naipesPc[cartajogada3 - 1]);
                                    
                                    if (cartasJogador[cartajogada3 - 1] > cartasPc[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                    else if (cartasJogador[cartajogada3 - 1] < cartasPc[cartajogada3 - 1])
                                    {
                                        Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else
                                    {
                                        if (cartasJogador[cartajogada3 - 1] >= 9)
                                        {
                                            if (naipesPc[cartajogada3pc - 1] < naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                                PontosJog++;
                                                continue;
                                            }
                                            else if (naipesPc[cartajogada3pc - 1] > naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPuts, voce perdeu a ultima rodada.");
                                                PontosPC++;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nEmpate! Logo, você ganhou a última rodada.");
                                                PontosJog++;
                                                continue;
                                            }

                                        }

                                    }

                                }
                                else if (naipesPc[cartajogada2pc - 1] > naipesJogador[cartajogada2 - 1])
                                {
                                    Console.WriteLine("\nPuts, Pc ganhou a ultima rodada.");
                                    PontosPC++;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate! Logo, Pc ganhou a última rodada.");
                                PontosPC++;
                                continue;
                            }


                        }
                    }
                    else
                    {
                        if(cartasJogador[cartajogada1-1] >= 9)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Empate!");
                            Console.WriteLine("\nDigite qual carta quer jogar.");
                            cartajogada2 = naoRepetirCarta1(cartajogada1, cartajogada2);

                            Console.WriteLine("\nAgora digite qual carta quer que o Pc jogue.");
                            cartajogada2pc = naoRepetirCarta1(cartajogada1pc, cartajogada2pc);
                            Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada2 - 1], naipesJogador[cartajogada2 - 1]);
                            Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada2pc - 1], naipesPc[cartajogada2pc - 1]);
                            if (cartasJogador[cartajogada2 - 1] > cartasPc[cartajogada2pc - 1])
                            {
                                Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                PontosJog++;
                                continue;
                            }
                            else if (cartasJogador[cartajogada2 - 1] < cartasPc[cartajogada2pc - 1])
                            {
                                Console.WriteLine("\nPuts,Pc ganhou a ultima rodada.");
                                PontosPC++;
                                continue;
                            }
                            else
                            {
                                if (cartasJogador[cartajogada2 - 1] >= 9)
                                {
                                    if (naipesPc[cartajogada2pc - 1] > naipesJogador[cartajogada2 - 1])
                                    {
                                        Console.WriteLine("\nPuts,Pc ganhou a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else if (naipesPc[cartajogada2pc - 1] < naipesJogador[cartajogada2 - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEmpate!");
                                    Console.WriteLine("\nDigite qual carta quer jogar.");
                                    cartajogada3 = naoRepetirCarta2(cartajogada1, cartajogada2, cartajogada3);

                                    Console.WriteLine("\nAgora digite qual carta quer que o Pc jogue.");
                                    cartajogada3pc = naoRepetirCarta2(cartajogada1pc, cartajogada2pc, cartajogada3pc);
                                    Console.WriteLine("\nVoce jogou: {0}{1}", cartasJogador[cartajogada3 - 1], naipesJogador[cartajogada3 - 1]);
                                    Console.WriteLine("\nPc jogou: {0}{1}", cartasPc[cartajogada3pc - 1], naipesPc[cartajogada3pc - 1]);

                                    if (cartasJogador[cartajogada3 - 1] > cartasPc[cartajogada3pc - 1])
                                    {
                                        Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                        PontosJog++;
                                        continue;
                                    }
                                    else if (cartasJogador[cartajogada3 - 1] < cartasPc[cartajogada3pc - 1])
                                    {
                                        Console.WriteLine("\nPuts,Pc ganhou a ultima rodada.");
                                        PontosPC++;
                                        continue;
                                    }
                                    else
                                    {
                                        if (cartasJogador[cartajogada3 - 1] >= 9)
                                        {
                                            if (naipesPc[cartajogada3pc - 1] > naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPuts,Pc ganhou a ultima rodada.");
                                                PontosPC++;
                                                continue;
                                            }
                                            else if (naipesPc[cartajogada3pc - 1] < naipesJogador[cartajogada3 - 1])
                                            {
                                                Console.WriteLine("\nPARABENS! Voce ganhou a ultima rodada.");
                                                PontosJog++;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Que azar! Empate novamente! A rodada vai recomeçar.");
                                            continue;
                                        }

                                    }
                                }

                            }
                        }

                    
                    }

                }
               
                if (PontosJog == 11 && PontosPC < 11)
                {
                    
                    do
                    {
                        Console.WriteLine("A mão de 11 vai começar");
                        Console.WriteLine(" ");
                        Console.WriteLine("Essa é a vira: {0}-{1}", cartas[cartasGeradas[0]], naipes[cartasGeradas[1]]);
                        Console.WriteLine(" ");
                        Console.WriteLine("Essas são as suas cartas: ({0}-{1}), ({2}-{3}) e ({4}-{5}).", cartas[cartasGeradas[2]], naipes[cartasGeradas[3]], cartas[cartasGeradas[4]], naipes[cartasGeradas[5]], cartas[cartasGeradas[6]], naipes[cartasGeradas[7]]);
                        Console.WriteLine("Você deseja jogar essa mão de onze (S/N) ?");
                        maode11 = Console.ReadLine().Trim().ToUpper();

                        do
                        {
                            if (maode11 == "S")
                            {
                                int[] cartaJogadaJog = new int[3];
                                Console.WriteLine("\nQue carta deseja jogar? (1,2 ou 3)");
                                cartaJogadaJog[0] = int.Parse(Console.ReadLine());

                                int cartaPc = jogabilidade1(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], cartasJogador[cartaJogadaJog[0] - 1], naipesJogador[cartaJogadaJog[0] - 1], cartasGeradas[0]);
                                if (cartasPc[cartaPc] > cartasJogador[cartaJogadaJog[0] - 1])
                                {
                                    Console.WriteLine("\nPc Ganhou. Pc torna.");
                                    
                                    Console.ReadLine();
                                    
                                    if (cartaPc == 0)
                                    {
                                        Console.WriteLine("\nPc tornou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                       
                                        Console.WriteLine("\nQue carta deseja jogar?");
                                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                                        int pontos = jogada2PcComecando(mediaCarta[0], mediaCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                                        if (pontos < 0)
                                        {
                                            PontosPC += 3;
                                            continue;
                                        }
                                        else if (pontos > 0)
                                        {
                                            
                                            pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], menorCarta[0], menorCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                            if (pontos > 0)
                                            {
                                                PontosJog += pontojogada; continue;
                                            }
                                            else if (pontos < 0)
                                            {
                                                PontosPC += 3; continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Como Pc ganhou a primeira jogada. Pc levou esta rodada.");
                                            PontosPC += 3;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        
                                        Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                        
                                        Console.WriteLine("\nQue carta deseja jogar?");
                                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                                        int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                                        if (pontos < 0)
                                        {
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                        else if (pontos > 0)
                                        {
                                            
                                            Console.WriteLine("\nJogue sua última carta.");
                                            if (cartaPc == 1)
                                                pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], menorCarta[0], menorCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                            else if (cartaPc == 2)
                                                pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], mediaCarta[0], mediaCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);

                                            if (pontos > 0)
                                            {
                                                PontosJog++;
                                                continue;
                                            }
                                            else
                                            {
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Como Pc ganhou a primeira jogada. Pc levou esta rodada.");
                                            PontosPC += 3;
                                            continue;
                                        }
                                    }
                                }
                                else if (cartasPc[cartaPc] < cartasJogador[cartaJogadaJog[0] - 1])
                                {
                                    
                                    Console.WriteLine("\nVoçê ganhou.");
                                    
                                    Console.WriteLine("\nQue carta deseja tornar?");

                                    cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                    Console.WriteLine("\nVoçê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[1] - 1]], naipes[naipesJogador[cartaJogadaJog[1] - 1]]);

                                    if (cartaPc == 2)
                                    {
                                        cartaPc = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], cartasPc[0], naipesPc[0], cartasPc[1], naipesPc[1], cartasGeradas[0]);
                                        if (cartaPc == 0)
                                        {
                                            
                                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                            if (maiorCarta[0] == cartasJogador[cartaJogadaJog[1] - 1])
                                            {
                                                Console.WriteLine("Empate! Logo, voçê leva pontua.");
                                                PontosJog++;
                                                continue;
                                            }
                                            else
                                            {
                                                
                                                Console.WriteLine("\nPc ganhou essa jogada.");
                                                Console.ReadLine();
                                                
                                                Console.WriteLine("\nPc tornou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                                
                                                Console.WriteLine("\nJogue sua ultima carta.");
                                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                if (cartasJogador[cartaJogadaJog[2] - 1] > mediaCarta[0])
                                                {
                                                    Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                    PontosJog++;
                                                    continue;
                                                }
                                                else if (cartasJogador[cartaJogadaJog[2] - 1] < mediaCarta[0])
                                                {
                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                    PontosPC = PontosPC + 3;
                                                    continue;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nEmpate! Logo, você pontua.");
                                                    PontosJog++;
                                                    continue;
                                                }
                                            }
                                        }
                                        else if (cartaPc == 1)
                                        {
                                           
                                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                            if (cartasJogador[cartaJogadaJog[1] - 1] > mediaCarta[0])
                                            {
                                                Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                            {
                                                Console.WriteLine("\nPc levou essa jogada.");
                                                Console.ReadLine();
                                                
                                                Console.WriteLine("\nPc torna: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                                
                                                Console.WriteLine("\nQue carta deseja jogar?");
                                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                if (cartasJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                                {
                                                    Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                    PontosJog+= pontojogada;
                                                    continue;
                                                }
                                                else if (cartasJogador[cartaJogadaJog[2] - 1] < maiorCarta[0])
                                                {
                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                    PontosPC = PontosPC + 3;
                                                    continue;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nEmpate! Logo, você pontua.");
                                                    PontosJog++;
                                                    continue;
                                                }
                                            }

                                        }
                                    }
                                }
                                else if (cartasPc[cartaPc] == cartasJogador[cartaJogadaJog[0] - 1])
                                {
                                    if (cartasJogador[cartaJogadaJog[0] - 1] >= 9)
                                    {
                                        if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[0] - 1])
                                        {
                                            Console.WriteLine("\nPc Ganhou. Pc torna.");
                                           
                                            Console.ReadLine();
                                            if (cartaPc == 0)
                                            {
                                                
                                                Console.WriteLine("\nPc tornou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                                
                                                Console.WriteLine("\nQue carta deseja jogar?");
                                                cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                                if (cartasJogador[cartaJogadaJog[1] - 1] > mediaCarta[0])
                                                {
                                                    
                                                    Console.WriteLine("\nVoce levou esta jogada.");
                                                    
                                                    Console.WriteLine("Jogue sua ultima carta.");
                                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                    if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                    {
                                                        Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                        PontosJog += pontojogada;
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                        PontosPC = PontosPC + 3;
                                                        continue;
                                                    }


                                                }
                                                else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                                {
                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                    PontosPC = PontosPC + 3;
                                                    continue;
                                                }
                                                else
                                                {
                                                    if (mediaCarta[0] >= 9)
                                                    {
                                                        if (naipesJogador[cartaJogadaJog[1] - 1] > mediaCarta[1])
                                                        {
                                                            
                                                            Console.WriteLine("\nVoce levou esta jogada.");
                                                            
                                                            Console.WriteLine("\nJogue sua ultima carta.");
                                                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                            if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                            {
                                                                Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                                PontosJog += pontojogada;
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                                PontosPC = PontosPC + 3;
                                                                continue;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                                Console.WriteLine("\nQue carta deseja jogar?");
                                                cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                                if (cartasJogador[cartaJogadaJog[1] - 1] > maiorCarta[0])
                                                {
                                                    
                                                    Console.WriteLine("\nVoce levou esta jogada.");
                                                    
                                                    Console.WriteLine("\nJogue sua ultima carta.");
                                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                    if (cartaPc == 1)
                                                    {
                                                        if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                        {
                                                            Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                            PontosJog += pontojogada;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[1])
                                                        {
                                                            Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                            PontosJog += pontojogada;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }
                                                    }

                                                }
                                                else if (cartasJogador[cartaJogadaJog[1] - 1] < maiorCarta[0])
                                                {
                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                    PontosPC = PontosPC + 3;
                                                    continue;
                                                }
                                                else
                                                {
                                                    if (maiorCarta[0] >= 9)
                                                    {
                                                        if (naipesJogador[cartaJogadaJog[1] - 1] > maiorCarta[1])
                                                        {
                                                            
                                                            Console.WriteLine("\nVoce levou esta jogada.");
                                                            
                                                            Console.WriteLine("\nJogue sua ultima carta.");
                                                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                            if (cartaPc == 1)
                                                            {
                                                                if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                                {
                                                                    Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                                    PontosJog += pontojogada;
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                                    PontosPC = PontosPC + 3;
                                                                    continue;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[1])
                                                                {
                                                                    Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                                    PontosJog += pontojogada;
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                                    PontosPC = PontosPC + 3;
                                                                    continue;
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                                        PontosPC = PontosPC + 3;
                                                        continue;
                                                    }
                                                }
                                            }

                                        }
                                        else if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[0] - 1])
                                        {
                                           
                                            Console.WriteLine("\nVocê Ganhou.");
                                            

                                            Console.WriteLine("Que carta deseja tornar?");
                                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                            int cartaPc2 = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], cartasGeradas[0]);

                                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[cartasPc[cartaPc2]], naipes[naipesPc[cartaPc2]]);

                                            if (cartasPc[cartaPc2] > cartasJogador[cartaJogadaJog[1] - 1])
                                            {
                                                Console.WriteLine("\nPc levou esta jogada. Pc torna.");
                                                Console.ReadLine();
                                                int cartaPc3;
                                                do
                                                {
                                                    cartaPc3 = rndNum.Next(0, 3);
                                                } while (cartaPc3 == cartaPc2 || cartaPc3 == cartaPc);
                                                Console.WriteLine("\nPc tornou: {0}{1}", cartas[cartasPc[cartaPc3]], naipes[naipesPc[cartaPc3]]);
                                                
                                                Console.WriteLine("\nJogue sua ultima carta.");
                                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);

                                                if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[cartaPc3])
                                                {
                                                    Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                    PontosJog += pontojogada;
                                                    continue;
                                                }
                                                else if (cartasJogador[cartaJogadaJog[1] - 1] < cartasPc[cartaPc3])
                                                {
                                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                    PontosPC = PontosPC + 3;
                                                    continue;
                                                }
                                                else
                                                {
                                                    if (cartasPc[cartaPc3] >= 9)
                                                    {
                                                        if (naipesJogador[cartaJogadaJog[1] - 1] > cartasPc[cartaPc3])
                                                        {
                                                            Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                            PontosJog += pontojogada;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                PontosJog += pontojogada;
                                                continue;
                                            }

                                        }


                                    }
                                    else
                                    {
                                        if (cartaPc == 0)
                                        {
                                            Console.WriteLine("\nEmpate.");
                                            Console.ReadLine();
                                            Console.Write("\nJogue a melhor carta. \nPc jogou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                           
                                            Console.WriteLine("\nDigite sua melhor carta que ainda nao foi jogada.");
                                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                            if (cartasJogador[cartaJogadaJog[1] - 1] > mediaCarta[0])
                                            {
                                                Console.WriteLine("Parabéns, você ganhou o jogo! ");
                                                PontosJog += pontojogada;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                            {
                                                Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                PontosPC = PontosPC + 3;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[1] - 1] == mediaCarta[0])
                                            {
                                                if (cartasJogador[cartaJogadaJog[1] - 1] == 10)
                                                {
                                                    if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[0] - 1])
                                                    {
                                                        Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                        PontosPC = PontosPC + 3;
                                                    }
                                                    if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[0] - 1])
                                                    {
                                                        Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                        PontosJog += pontojogada;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nEmpate novamente.");
                                                    Console.ReadLine();
                                                    Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], cartas[menorCarta[1]]);
                                                    
                                                    Console.WriteLine("\nJogue sua ultima carta.");
                                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);

                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate.");
                                            Console.ReadLine();
                                            Console.WriteLine("\nJogue a melhor carta. \nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                            
                                            Console.WriteLine("\nDigite sua melhor carta que ainda nao foi jogada.");
                                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                            if (cartasJogador[cartaJogadaJog[1] - 1] > maiorCarta[0])
                                            {
                                                Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                PontosJog += pontojogada;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[1] - 1] < maiorCarta[0])
                                            {
                                                Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                PontosPC = PontosPC + 3;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[1] - 1] == maiorCarta[0])
                                            {
                                                if (cartasJogador[cartaJogadaJog[1] - 1] >= 9)
                                                {
                                                    if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[1] - 1])
                                                    {
                                                        Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                        PontosPC = PontosPC + 3;
                                                    }
                                                    if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[1] - 1])
                                                    {
                                                        Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                        PontosJog += pontojogada; ;
                                                    }
                                                }
                                                else
                                                {//terminar
                                                    if (cartaPc == 1)
                                                    {
                                                        Console.WriteLine("\nEmpate novamente.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], cartas[menorCarta[1]]);
                                                       
                                                        Console.WriteLine("Digite sua ultima carta restante.");
                                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                        if (cartasJogador[cartaJogadaJog[2] - 1] > menorCarta[0])
                                                        {
                                                            Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                            PontosJog += pontojogada;
                                                            continue;
                                                        }
                                                        else if (cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Empate novamente. Recomeçar!");
                                                            continue;
                                                        }
                                                    }
                                                    else if (cartaPc == 2)
                                                    {
                                                        Console.WriteLine("\nEmpate novamente.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("\nPc jogou: {0}{1}", cartas[mediaCarta[0]], cartas[mediaCarta[1]]);
                                                        
                                                        Console.WriteLine("\nDigite sua ultima carta restante.");
                                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                        if (cartasJogador[cartaJogadaJog[2] - 1] > mediaCarta[0])
                                                        {
                                                            Console.WriteLine("\nParabéns, você ganhou o jogo! ");
                                                            PontosJog += pontojogada;
                                                            continue;
                                                        }
                                                        else if (cartasJogador[cartaJogadaJog[2] - 1] < mediaCarta[0])
                                                        {
                                                            Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                                            PontosPC = PontosPC + 3;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Empate novamente. Recomeçar!");
                                                            
                                                            continue;
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }

                                
                                else
                                {
                                    Console.WriteLine("Puts, não foi dessa vez! O pc ganhou mais 3 pontos!");
                                    PontosPC = PontosPC + 3;
                                }
                            }
                            else
                            {
                                PontosPC = PontosJog + 1;
                            }

                        } while (maode11 != "S" || maode11 == "N'");

                    } while (PontosPC <= 12 || PontosJog <= 12);
                }

                else if (PontosPC == 11 && PontosJog < 11)
                {
                    Console.WriteLine("A mão de 11 vai começar");
                    Console.WriteLine(" ");
                    Console.WriteLine("Essa é a vira: {0}-{1}", cartas[cartasGeradas[0]], naipes[cartasGeradas[1]]);
                    Console.WriteLine(" ");
                    Console.WriteLine("Essas são as suas cartas: ({0}-{1}), ({2}-{3}) e ({4}-{5}).", cartas[cartasGeradas[2]], naipes[cartasGeradas[3]], cartas[cartasGeradas[4]], naipes[cartasGeradas[5]], cartas[cartasGeradas[6]], naipes[cartasGeradas[7]]);

                    if (maiorCarta[0] >= 8 && mediaCarta[0] >= 8)
                    {
                        
                        int[] cartaJogadaJog = new int[3];
                        Console.WriteLine("O Computador vai jogar!");
                        Console.WriteLine("Pc jogou: {0}{1}", maiorCarta[0], maiorCarta[1]);

                        cartaJogadaJog[0] = int.Parse(Console.ReadLine());

                        int pontoJogada = jogada1PcComecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], mediaCarta[0], mediaCarta[1], cartasGeradas[0], cartaJogadaJog[0]);
                        if (pontoJogada > 0)
                        {
                            
                            Console.WriteLine("\nVocê Ganhou a primeira jogada.");
                            
                            Console.WriteLine("Torne: ");
                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                            int cartaPc = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], maiorCarta[0], maiorCarta[1], menorCarta[0], menorCarta[1], cartasGeradas[0]);
                            if (cartaPc == 1)
                            {
                                if (cartasJogador[cartaJogadaJog[1] - 1] > menorCarta[0])
                                {
                                    Console.WriteLine("Pc jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                    Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                    PontosJog += 3;
                                    continue;
                                }
                                else if (cartasJogador[cartaJogadaJog[1] - 1] < menorCarta[0])
                                {
                                    
                                    Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                    Console.WriteLine("\nPc levou essa jogada.");
                                    
                                    Console.ReadLine();
                                    
                                    Console.WriteLine("\nPc torna: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                    
                                    Console.WriteLine("\nJogue sua última carta. ");
                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                    Console.WriteLine("\nVocê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[2] - 1]], naipes[naipesJogador[cartaJogadaJog[2] - 1]]);
                                    if (cartasJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                    {
                                        Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                        PontosJog += 3;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[2] - 1] < maiorCarta[0])
                                    {
                                        Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[2] - 1] == maiorCarta[0])
                                    {
                                        if (maiorCarta[0] >= 9)
                                        {
                                            if (naipesJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                            {
                                                Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                                PontosJog += 3;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Logo, voçê levou esta rodada.");
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                    }
                                }

                            }
                            else if (cartaPc == 0)
                            {
                                if (maiorCarta[0] > cartasJogador[cartaJogadaJog[1] - 1])
                                {
                                    
                                    Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                    Console.WriteLine("\nPc ganhou essa jogada.");
                                    Console.ReadLine();
                                    
                                    if (cartasJogador[cartaJogadaJog[1] - 1] < maiorCarta[0] && cartasJogador[cartaJogadaJog[1] - 1] > menorCarta[0])
                                    {
                                        
                                        Console.WriteLine("\nPc Jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                       
                                        Console.WriteLine("\nJogue sua última carta. ");
                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                        Console.WriteLine("\nVocê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[2] - 1]], naipes[naipesJogador[cartaJogadaJog[2] - 1]]);
                                        if (cartasJogador[cartaJogadaJog[2] - 1] > menorCarta[0])
                                        {
                                            Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                            PontosJog += 3;
                                            continue;
                                        }
                                        else if (cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                                        {
                                            Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                            PontosPC += pontojogada;
                                            continue;
                                        }

                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Empate!Logo, você ganhou 3 pontos! ");
                                    PontosJog += 3;
                                }

                            }
                        }
                        else if (pontoJogada < 0)
                        {
                            Console.WriteLine("\nPc ganhou. Pc torna.");

                            Console.ReadLine();
                            
                            
                            Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                            
                            Console.WriteLine("\nQue carta deseja jogar?");
                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                            int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                            if (pontos > 0)
                            {
                                Console.WriteLine("\nVocê levou esta jogada.");
                                
                                Console.WriteLine("\nJogue sua ultima carta.");
                                
                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                if (cartasJogador[cartaJogadaJog[2] - 1] > menorCarta[0])
                                {
                                    Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                    PontosJog += 3;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                            else if (pontos < 0)
                            {
                                Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                PontosPC += pontojogada;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate! Como Pc ganhou a primeira jogada, Pc levou esta rodada.\n\nNão foi dessa vez! O Pc te passou a perna!");
                                PontosPC += pontojogada;
                                continue;
                            }

                        }
                        else
                        {                         
                            Console.WriteLine("\nEmpate.");
                           
                            Console.WriteLine("\nJogue sua melhor carta.");
                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                            
                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);

                            int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                            if (pontos > 0)
                            {
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (pontos < 0)
                            {
                                PontosPC += pontojogada;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate novamente.");
                                
                                Console.WriteLine("\nPc jogou: {0}{1}");
                                
                                Console.WriteLine("\n Jogue sua última carta.", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                if (cartasJogador[cartaJogadaJog[2] - 1] > menorCarta[0])
                                {
                                    Console.WriteLine("Parabéns, você ganhou 3 pontos! ");
                                    PontosJog += 3;
                                    continue;
                                }
                                else if (cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                                {
                                    Console.WriteLine("Não foi dessa vez! O Pc te passou a perna! ");
                                    PontosPC += pontojogada;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("\nEmpate! Recomeçar!");                                    
                                    continue;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("O pc decidiu não jogar essa partida. Você ganhou mais 1 ponto!");
                        PontosJog++;
                    }
                    Console.ReadKey();
                    continue;
                }

               

                Console.WriteLine("\n\nRodada {0}", rodada);

                Console.WriteLine("Placar: {0} a {1}", PontosJog, PontosPC);
                Console.WriteLine("\n         Vira: {0}{1}", vira[0], vira[1]);
                Console.WriteLine("\nSuas cartas:    {0}{1}  {2}{3}  {4}{5}\n                1           2         3", carta1Jog[0], carta1Jog[1], carta2Jog[0], carta2Jog[1], carta3Jog[0], carta3Jog[1]);
                
                //analisa se o jogador quer iniciar a rodada
                string comecar;
                do
                { 

                    Console.Write("\nQuer jogar essa rodada (S/N)?  ");
                    comecar = Console.ReadLine();
                    if (comecar == "N")
                    {
                        PontosPC++;
                        continue;
                    }
                    else if (comecar == "S")
                    { }
                    else
                        Console.Write("Digite um valor válido");
                }
                while (comecar != "S" && comecar != "N");

                if (comecar == "N" || comecar == "n")
                    continue;
                //quem começa
               
               

                int quemComeca = rndNum.Next(0, 2);
                if (quemComeca == 1)
                    Console.WriteLine("\nPC começa.");
                else
                    Console.WriteLine("\nVocê começa.");

                pontojogada = 1;

                int jogadasjog = 0, jogadaspc = 0;
                string truco = "N";

                if (quemComeca == 1)
                {
                    int[] cartaJogadaJog = new int[3];
                    Console.WriteLine("\nPC Jogou:  {0} {1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                    Console.WriteLine("\nDeseja pedir truco?(S/N)");
                    truco = Console.ReadLine();
                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1],jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                    if (pontojogada == -1)
                    {
                        pontojogada = 1;
                        PontosJog += pontojogada;
                        continue;
                    }
                    else if (pontojogada == -4)
                    {
                        pontojogada = 3;
                        PontosJog += pontojogada;
                        continue;
                    }
                    Console.WriteLine("\nQue carta deseja jogar(1/2/3)?");
                    cartaJogadaJog[0] = int.Parse(Console.ReadLine());

                    int pontoJogada = jogada1PcComecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], mediaCarta[0], mediaCarta[1], cartasGeradas[0], cartaJogadaJog[0]);
                    if (pontoJogada > 0)
                    {
                        jogadasjog++;
                        Console.WriteLine("\nVocê Ganhou a primeira jogada.");
                        if (pontojogada == 1 && truco == "N")
                        {
                            Console.WriteLine("\nDeseja pedir truco ? (S / N)");
                            truco = Console.ReadLine();
                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                            if (pontojogada == -1)
                            {
                                pontojogada = 1;
                                PontosPC += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -4)
                            {
                                pontojogada = 3;
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        Console.WriteLine("Torne: ");
                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);                        
                        int cartaPc = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], maiorCarta[0], maiorCarta[1], menorCarta[0], menorCarta[1], cartasGeradas[0]);
                        if (cartaPc == 1)
                        {   
                            if (cartasJogador[cartaJogadaJog[1] - 1] > menorCarta[0])
                            {                              
                                Console.WriteLine("Pc jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                Console.WriteLine("\nVoçê levou essa rodada.");
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (cartasJogador[cartaJogadaJog[1] - 1] < menorCarta[0])
                            {
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                if (pontojogada == -3)
                                {
                                    pontojogada = 1;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -2)
                                {
                                    pontojogada = 3;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                Console.WriteLine("\nPc levou essa jogada.");
                                jogadaspc++;
                                Console.ReadLine();
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                if (pontojogada == -3)
                                {
                                    pontojogada = 1;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -2)
                                {
                                    pontojogada = 3;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                Console.WriteLine("\nPc torna: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);                                
                                if(pontojogada == 1)
                                {
                                    Console.WriteLine("Deseja pedir truco?(S/N)");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                    if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nJogue sua última carta. ");
                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                Console.WriteLine("\nVocê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[2] - 1]], naipes[naipesJogador[cartaJogadaJog[2] - 1]]);
                                if (cartasJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                {
                                    Console.WriteLine("\nVocê ganhou esta rodada.");
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                else if (cartasJogador[cartaJogadaJog[2] - 1] < maiorCarta[0])
                                {
                                    Console.WriteLine("\nPc ganhou esta rodada.");
                                    PontosPC += pontojogada;
                                    continue;
                                }
                                else if (cartasJogador[cartaJogadaJog[2] - 1] == maiorCarta[0])
                                {
                                    if (maiorCarta[0] >= 9)
                                    {
                                        if (naipesJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                        {
                                            Console.WriteLine("\nVocê venceu esta rodada.");
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nPc levou esta rodada.");
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpate. Logo, voçê levou esta rodada.");
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                }
                            }
                            
                        }
                        else if (cartaPc == 0)
                        {
                            if (maiorCarta[0] > cartasJogador[cartaJogadaJog[1] - 1])
                            {
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                if(pontojogada == -3)
                                {
                                    pontojogada = 1;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -2)
                                {
                                    pontojogada = 3;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                Console.WriteLine("\nPc ganhou essa jogada.");
                                Console.ReadLine();
                                jogadaspc++;
                                if (cartasJogador[cartaJogadaJog[1] - 1] < maiorCarta[0] && cartasJogador[cartaJogadaJog[1] - 1] > menorCarta[0])
                                {
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -3)
                                    {
                                        pontojogada = 1;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -2)
                                    {
                                        pontojogada = 3;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                                    if(pontojogada == 1 && truco == "N")
                                    {
                                        Console.WriteLine("Deseja pedir truco?(S/N)");
                                        truco = Console.ReadLine();
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -4)
                                        {
                                            pontojogada = 3;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -1)
                                        {
                                            pontojogada = 1;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nJogue sua última carta. ");
                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                    Console.WriteLine("\nVocê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[2] - 1]], naipes[naipesJogador[cartaJogadaJog[2] - 1]]);
                                    if (cartasJogador[cartaJogadaJog[2] - 1] > menorCarta[0])
                                    {
                                        Console.WriteLine("\nVocê ganhou esta rodada.");
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                                    {
                                        Console.WriteLine("\nPc ganhou esta rodada.");
                                        PontosPC += pontojogada; 
                                        continue;
                                    }

                                }
                                

                            }
                            else
                            {
                                Console.WriteLine("\nEmpate. Logo, voçê leva essa rodada.");
                                PontosJog += pontojogada;
                            }
                            
                        }                       
                    }
                    else if (pontoJogada < 0)
                    {
                        Console.WriteLine("\nPc ganhou. Pc torna.");

                        Console.ReadLine();
                        jogadaspc++;
                        if (pontojogada == 1 && truco == "N")
                        {
                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                            if (pontojogada == -3)
                            {
                                pontojogada = 1;
                                PontosPC += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -2)
                            {
                                pontojogada = 3;
                                PontosJog += pontojogada;
                                continue;
                            }
                        }
                        Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                        if (truco == "N" && pontojogada == 1)
                        {
                            Console.WriteLine("Deseja pedir truco?(S/N)");
                            truco = Console.ReadLine();
                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                            if (pontojogada == -4)
                            {
                                pontojogada = 3;
                                PontosPC += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -1)
                            {
                                pontojogada = 1;
                                PontosJog += pontojogada;
                                continue;
                            }
                        }
                        Console.WriteLine("\nQue carta deseja jogar?");
                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                        int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                        if (pontos > 0)
                        {
                            Console.WriteLine("\nVocê levou esta jogada.");
                            if (pontojogada == 1 && truco == "N")
                            {
                                Console.WriteLine("Deseja pedir truco?");
                                truco = Console.ReadLine();
                                if(truco == "S")
                                {
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                            }
                            Console.WriteLine("\nJogue sua ultima carta.");
                            jogadasjog++;
                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                            if (cartasJogador[cartaJogadaJog[2]-1] > menorCarta[0])
                            {
                                Console.WriteLine("\nVocê levou esta rodada.");
                                PontosJog += pontojogada;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nPc levou a rodada.");
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        else if (pontos < 0)
                        {
                            Console.WriteLine("Pc levou essa rodada.");
                            PontosPC += pontojogada;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("\nEmpate! Como Pc ganhou a primeira jogada. Pc levou esta rodada.");
                            PontosPC += pontojogada;
                            continue;
                        }
                        
                    }
                    else
                    {//terminar empate do empate
                        jogadasjog++; jogadaspc++;
                        Console.WriteLine("\nEmpate.");
                        if (truco == "N" && pontojogada == 1)
                        {
                            Console.WriteLine("Deseja pedir truco?");
                            if (truco == "S")
                            {
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                if(pontojogada == -1)
                                {
                                    pontojogada = 1;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -4)
                                {
                                    pontojogada = 3;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                        }
                        Console.WriteLine("\nJogue sua melhor carta.");
                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                        
                        if (truco == "N" && pontojogada == 1)
                        {
                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                            if (pontojogada == -2)
                            {
                                pontojogada = 3;
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -3)
                            {
                                pontojogada = 1;
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                        
                        int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                        if (pontos > 0)
                        {
                            PontosJog += pontojogada;
                            continue;
                        }
                        else if (pontos < 0)
                        {
                            PontosPC += pontojogada;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("\nEmpate novamente.");
                            if (truco == "N" && pontojogada == 1)
                            {
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                if (pontojogada == -2)
                                {
                                    pontojogada = 3;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -3)
                                {
                                    pontojogada = 1;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                            Console.WriteLine("\nPc jogou: {0}{1}");
                            if(truco == "N" && pontojogada == 1)
                            {
                                Console.WriteLine("Deseha pedir truco?(S/N)");
                                truco = Console.ReadLine();
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                            }
                            Console.WriteLine("\n Jogue sua última carta.", cartas[menorCarta[0]], naipes[menorCarta[1]]);
                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                            if (cartasJogador[cartaJogadaJog[2]-1] > menorCarta[0])
                            {
                                Console.WriteLine("\nVoçê levou esta rodada.");
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                            {
                                Console.WriteLine("\n Pc levou esta rodada.");
                                PontosPC += pontojogada;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate! Ambos pontuam.");
                                PontosPC += pontojogada;
                                PontosJog += pontojogada;
                                continue;
                            }
                        }
                    }


                }
                else
                {
                    int[] cartaJogadaJog = new int[3];
                    Console.WriteLine("Deseja pedir truco?(S/N)");
                    truco = Console.ReadLine();
                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                    if (pontojogada == -1)
                    {
                        pontojogada = 1;
                        PontosJog += pontojogada;
                        continue;
                    }
                    else if (pontojogada == -4)
                    {
                        pontojogada = 3;
                        PontosPC += pontojogada;
                        continue;
                    }
                    Console.WriteLine("\nQue carta deseja jogar? (1,2 ou 3)");
                    cartaJogadaJog[0] = int.Parse(Console.ReadLine());
                  
                    int cartaPc = jogabilidade1(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], cartasJogador[cartaJogadaJog[0] - 1], naipesJogador[cartaJogadaJog[0] - 1], cartasGeradas[0]);
                    if (cartasPc[cartaPc] > cartasJogador[cartaJogadaJog[0] - 1])
                    {
                        Console.WriteLine("\nPc Ganhou. Pc torna.");
                        if(pontojogada == 1 && truco == "N")
                        {
                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                            if (pontojogada == -2)
                            {
                                pontojogada = 3;
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -3)
                            {
                                pontojogada = 1;
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        Console.ReadLine();
                        jogadaspc++;
                        if (cartaPc == 0)
                        {
                            Console.WriteLine("\nPc tornou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                            if (pontojogada == 1 && truco == "N")
                            {
                                Console.WriteLine("Deseja pedir truco?(S/N)");
                                truco = Console.ReadLine();
                                if (truco == "S")
                                {
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                            }
                            Console.WriteLine("\nQue carta deseja jogar?");
                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                            int pontos = jogada2PcComecando(mediaCarta[0], mediaCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                            if (pontos < 0)
                            {
                                PontosPC += pontojogada;
                                continue;
                            }
                            else if(pontos > 0)
                            {
                                if (pontojogada == 1 && truco == "N")
                                {
                                    Console.WriteLine("Deseja pedir truco?(S/N)");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -2)
                                    {
                                        pontojogada = 3;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -3)
                                    {
                                        pontojogada = 1;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], menorCarta[0], menorCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                if (pontos > 0)
                                {
                                    PontosJog += pontojogada; continue;
                                }
                                else if (pontos < 0)
                                {
                                    PontosPC += pontojogada; continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate. Como Pc ganhou a primeira jogada. Pc levou esta rodada.");
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        else
                        {
                            if (pontojogada == 1 && truco == "N")
                            {
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                if (pontojogada == -2)
                                {
                                    pontojogada = 3;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -3)
                                {
                                    pontojogada = 1;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                            Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                            if (pontojogada == 1 && truco == "N")
                            {
                                Console.WriteLine("Deseja pedir truco?");
                                truco = Console.ReadLine();
                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                if (pontojogada == -1)
                                {
                                    pontojogada = 1;
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                else if (pontojogada == -4)
                                {
                                    pontojogada = 3;
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                            Console.WriteLine("\nQue carta deseja jogar?");
                            cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);
                            int pontos = jogada2PcComecando(maiorCarta[0], maiorCarta[1], cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], cartaJogadaJog[1] - 1, cartasGeradas[0]);
                            if (pontos < 0)
                            {
                                PontosPC += pontojogada;
                                continue;
                            }
                            else if (pontos > 0)
                            {
                                if (pontojogada == 1 && truco == "N")
                                {
                                    Console.WriteLine("Deseja pedir truco?");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nJogue sua última carta.");
                                if (cartaPc == 1)
                                    pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], menorCarta[0], menorCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                else if (cartaPc == 2)
                                    pontos = jogada3jogcomecando(cartasJogador[0], naipesJogador[0], cartasJogador[1], naipesJogador[1], cartasJogador[2], naipesJogador[2], mediaCarta[0], mediaCarta[1], cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                
                                if (pontos > 0)
                                {
                                    PontosJog+= pontojogada;
                                    continue;
                                }
                                else
                                {
                                    PontosPC += pontojogada;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate. Como Pc ganhou a primeira jogada. Pc levou esta rodada.");
                                PontosPC=pontojogada;
                                continue;
                            }
                        }
                    }
                    else if (cartasPc[cartaPc] < cartasJogador[cartaJogadaJog[0] - 1])
                    {
                        jogadasjog++;
                        Console.WriteLine("\nVoçê ganhou.");
                        if (pontojogada == 1 && truco == "N")
                        {
                            Console.WriteLine("Deseja pedir truco?");
                            truco = Console.ReadLine();
                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                            if (pontojogada == -1)
                            {
                                pontojogada = 1;
                                PontosJog += pontojogada;
                                continue;
                            }
                            else if (pontojogada == -4)
                            {
                                pontojogada = 3;
                                PontosPC += pontojogada;
                                continue;
                            }
                        }
                        Console.WriteLine("\nQue carta deseja tornar?");
                        
                        cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                        Console.WriteLine("\nVoçê jogou: {0}{1}", cartas[cartasJogador[cartaJogadaJog[1]-1]], naipes[naipesJogador[cartaJogadaJog[1] - 1]]);
                        
                        if (cartaPc == 2)
                        {
                            cartaPc = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], cartasPc[0], naipesPc[0], cartasPc[1], naipesPc[1], cartasGeradas[0]);
                            if (cartaPc == 0)
                            {
                                if (pontojogada == 1 && truco == "N")
                                {                                    
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -2)
                                    {
                                        pontojogada = 3;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -3)
                                    {
                                        pontojogada = 1;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                if (maiorCarta[0] == cartasJogador[cartaJogadaJog[1] - 1])
                                {
                                    Console.WriteLine("Empate! Logo, voçê leva essa rodada.");
                                    PontosJog+=pontojogada;
                                    continue;
                                }
                                else
                                {
                                    jogadaspc++;
                                    Console.WriteLine("\nPc ganhou essa jogada.");
                                    Console.ReadLine();
                                    if (pontojogada == 1 && truco == "N")
                                    {                                        
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -2)
                                        {
                                            pontojogada = 3;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -3)
                                        {
                                            pontojogada = 1;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nPc tornou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                    if (pontojogada == 1 && truco == "N")
                                    {
                                        Console.WriteLine("Deseja pedir truco?");
                                        truco = Console.ReadLine();
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -1)
                                        {
                                            pontojogada = 1;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -4)
                                        {
                                            pontojogada = 3;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nJogue sua ultima carta.");
                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                    if (cartasJogador[cartaJogadaJog[2] - 1] > mediaCarta[0])
                                    {
                                        Console.WriteLine("\nVoçê levou esta rodada.");
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[2] - 1] < mediaCarta[0])
                                    {
                                        Console.WriteLine("\nPc levou esta rodada.");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpate! Logo, você pontua.");
                                        PontosJog+=pontojogada;
                                        continue;
                                    }
                                }
                            }
                            else if (cartaPc == 1)
                            {
                                if (pontojogada == 1 && truco == "N")
                                {
                                    
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -2)
                                    {
                                        pontojogada = 3;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -3)
                                    {
                                        pontojogada = 1;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nPc jogou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                if (cartasJogador[cartaJogadaJog[1] - 1] > mediaCarta[0])
                                {
                                    Console.WriteLine("\nVoçê levou essa rodada.");
                                    PontosJog+=pontojogada;
                                    continue;
                                }
                                else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                {
                                    Console.WriteLine("\nPc levou essa jogada.");
                                    Console.ReadLine();
                                    if (pontojogada == 1 && truco == "N")
                                    {                                        
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, maiorCarta[0], maiorCarta[1], truco);
                                        if (pontojogada == -2)
                                        {
                                            pontojogada = 3;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -3)
                                        {
                                            pontojogada = 1;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nPc torna: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                    if (pontojogada == 1 && truco == "N")
                                    {
                                        Console.WriteLine("Deseja pedir truco?");
                                        truco = Console.ReadLine();
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -1)
                                        {
                                            pontojogada = 1;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -4)
                                        {
                                            pontojogada = 3;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nQue carta deseja jogar?");
                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                    if (cartasJogador[cartaJogadaJog[2] - 1] > maiorCarta[0])
                                    {
                                        Console.WriteLine("\nVoçê levou esta rodada.");
                                        PontosJog+=pontojogada;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[2] - 1] < maiorCarta[0])
                                    {
                                        Console.WriteLine("\nPc levou esta rodada.");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpate! Logo, você pontua.");
                                        PontosJog+=pontojogada;
                                        continue;                                   
                                    }
                                }

                            }
                        }                        
                    }
                    else if (cartasPc[cartaPc] == cartasJogador[cartaJogadaJog[0] - 1])
                    {
                        if(cartasJogador[cartaJogadaJog[0] - 1] >= 9)
                        { 
                            if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[0] - 1])
                            {
                                Console.WriteLine("\nPc Ganhou. Pc torna.");
                                jogadaspc++;
                                Console.ReadLine();
                                if (cartaPc == 0)
                                {
                                    if (pontojogada == 1 && truco == "N")
                                    {
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -2)
                                        {
                                            pontojogada = 3;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -3)
                                        {
                                            pontojogada = 1;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nPc tornou: {0}{1}",cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                    if (pontojogada == 1 && truco == "N")
                                    {
                                        Console.WriteLine("Deseja pedir truco?");
                                        truco = Console.ReadLine();
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -1)
                                        {
                                            pontojogada = 1;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -4)
                                        {
                                            pontojogada = 3;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nQue carta deseja jogar?");
                                    cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                    if (cartasJogador[cartaJogadaJog[1]-1] > mediaCarta[0])
                                    {
                                        jogadasjog++;
                                        Console.WriteLine("\nVoce levou esta jogada.");
                                        if (pontojogada == 1 && truco == "N")
                                        {
                                            Console.WriteLine("Deseja pedir truco?");
                                            truco = Console.ReadLine();
                                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                            if (pontojogada == -1)
                                            {
                                                pontojogada = 1;
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if (pontojogada == -4)
                                            {
                                                pontojogada = 3;
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        Console.WriteLine("Jogue sua ultima carta.");
                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                        if (cartasJogador[cartaJogadaJog[2]-1] > cartasPc[2])
                                        {
                                            Console.WriteLine("Voce ganhou esta rodada.");
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("PC levou esta rodada!!");
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                        
                                        
                                    }
                                    else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                    {
                                        Console.WriteLine("\nPc levou esta rodada.");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else
                                    {
                                        if (mediaCarta[0] >= 9)
                                        {
                                            if (naipesJogador[cartaJogadaJog[1] - 1] > mediaCarta[1])
                                            {
                                                jogadasjog++;
                                                Console.WriteLine("\nVoce levou esta jogada.");
                                                if (pontojogada == 1 && truco == "N")
                                                {
                                                    Console.WriteLine("Deseja pedir truco?");
                                                    truco = Console.ReadLine();
                                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                                    if (pontojogada == -1)
                                                    {
                                                        pontojogada = 1;
                                                        PontosJog += pontojogada;
                                                        continue;
                                                    }
                                                    else if (pontojogada == -4)
                                                    {
                                                        pontojogada = 3;
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }
                                                Console.WriteLine("Jogue sua ultima carta.");
                                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                {
                                                    Console.WriteLine("Voce ganhou esta rodada.");
                                                    PontosJog += pontojogada;
                                                    continue;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("PC levou esta rodada!!");
                                                    PontosPC += pontojogada;
                                                    continue;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPc levou esta rodada.");
                                                PontosPC += pontojogada;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nPc tornou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                    Console.WriteLine("\nQue carta deseja jogar?");
                                    cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                    if (cartasJogador[cartaJogadaJog[1] - 1] > maiorCarta[0])
                                    {
                                        jogadasjog++;
                                        Console.WriteLine("\nVoce levou esta jogada.");
                                        if (pontojogada == 1 && truco == "N")
                                        {
                                            Console.WriteLine("Deseja pedir truco?");
                                            truco = Console.ReadLine();
                                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                            if (pontojogada == -1)
                                            {
                                                pontojogada = 1;
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if (pontojogada == -4)
                                            {
                                                pontojogada = 3;
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        Console.WriteLine("Jogue sua ultima carta.");
                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                        if (cartaPc == 1)
                                        {
                                            if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                            {
                                                Console.WriteLine("Voce ganhou esta rodada.");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("PC levou esta rodada!!");
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[1])
                                            {
                                                Console.WriteLine("Voce ganhou esta rodada.");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("PC levou esta rodada!!");
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }

                                    }
                                    else if (cartasJogador[cartaJogadaJog[1] - 1] < maiorCarta[0])
                                    {
                                        Console.WriteLine("\nPc levou esta rodada.");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else
                                    {
                                        if (maiorCarta[0] >= 9)
                                        {
                                            if (naipesJogador[cartaJogadaJog[1] - 1] > maiorCarta[1])
                                            {
                                                jogadasjog++;
                                                Console.WriteLine("\nVoce levou esta jogada.");
                                                if (pontojogada == 1 && truco == "N")
                                                {
                                                    Console.WriteLine("Deseja pedir truco?");
                                                    truco = Console.ReadLine();
                                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                                    if (pontojogada == -1)
                                                    {
                                                        pontojogada = 1;
                                                        PontosJog += pontojogada;
                                                        continue;
                                                    }
                                                    else if (pontojogada == -4)
                                                    {
                                                        pontojogada = 3;
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }
                                                Console.WriteLine("Jogue sua ultima carta.");
                                                cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                                if (cartaPc == 1)
                                                {
                                                    if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[2])
                                                    {
                                                        Console.WriteLine("Voce ganhou esta rodada.");
                                                        PontosJog += pontojogada;
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("PC levou esta rodada!!");
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }
                                                else
                                                {
                                                    if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[1])
                                                    {
                                                        Console.WriteLine("Voce ganhou esta rodada.");
                                                        PontosJog += pontojogada;
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("PC levou esta rodada!!");
                                                        PontosPC += pontojogada;
                                                        continue;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPc levou esta rodada.");
                                                PontosPC += pontojogada;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                }
                                
                            }
                            else if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[0] - 1])
                            {
                                jogadasjog++;
                                Console.WriteLine("\nVocê Ganhou.");
                                if (pontojogada == 1 && truco == "N")
                                {
                                    Console.WriteLine("Deseja pedir truco?");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }

                                Console.WriteLine("Que carta deseja tornar?");                                 
                                cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);                                                                
                                
                                int cartaPc2 = jogabilidade2(cartasJogador[cartaJogadaJog[1] - 1], naipesJogador[cartaJogadaJog[1] - 1], maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], cartasGeradas[0]);
                                
                                Console.WriteLine("\nPc jogou: {0}{1}", cartas[cartasPc[cartaPc2]], naipes[naipesPc[cartaPc2]]);
                                
                                if (cartasPc[cartaPc2] > cartasJogador[cartaJogadaJog[1]-1])
                                {
                                    Console.WriteLine("\nPc levou esta jogada. Pc torna.");
                                    Console.ReadLine();
                                    int cartaPc3;
                                    do
                                    {
                                        cartaPc3 = rndNum.Next(0, 3);
                                    } while (cartaPc3 == cartaPc2 || cartaPc3 == cartaPc);
                                    Console.WriteLine("\nPc tornou: {0}{1}", cartas[cartasPc[cartaPc3]], naipes[naipesPc[cartaPc3]]);
                                    if (pontojogada == 1 && truco == "N")
                                    {
                                        Console.WriteLine("Deseja pedir truco?");
                                        truco = Console.ReadLine();
                                        pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                        if (pontojogada == -1)
                                        {
                                            pontojogada = 1;
                                            PontosJog += pontojogada;
                                            continue;
                                        }
                                        else if (pontojogada == -4)
                                        {
                                            pontojogada = 3;
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("\nJogue sua ultima carta.");
                                    cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                   
                                    if (cartasJogador[cartaJogadaJog[2] - 1] > cartasPc[cartaPc3])
                                    {
                                        Console.WriteLine("\nVoce levou esta rodada.");
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (cartasJogador[cartaJogadaJog[1] - 1] < cartasPc[cartaPc3])
                                    {
                                        Console.WriteLine("\nPc levou esta rodada.");
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                    else
                                    {
                                        if (cartasPc[cartaPc3] >= 9)
                                        {
                                            if (naipesJogador[cartaJogadaJog[1] - 1] > cartasPc[cartaPc3])
                                            {
                                                Console.WriteLine("\nVoce levou esta rodada.");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPc levou esta rodada.");
                                                PontosPC += pontojogada;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpate. Logo, Pc leva esta rodada para casa.");
                                            PontosPC += pontojogada;
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nVoçê levou esta rodada.");
                                    PontosJog += pontojogada;
                                    continue;
                                }
                                
                            }


                        }
                        else
                        {
                            if (cartaPc == 0)
                            {
                                Console.WriteLine("\nEmpate.");
                                Console.ReadLine();
                                Console.Write("\nJogue a melhor carta. \nPc jogou: {0}{1}", cartas[mediaCarta[0]], naipes[mediaCarta[1]]);
                                if (pontojogada == 1 && truco == "N")
                                {
                                    Console.WriteLine("Deseja pedir truco?");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nDigite sua melhor carta que ainda nao foi jogada.");
                                cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                if (cartasJogador[cartaJogadaJog[1] - 1] > mediaCarta[0])
                                {
                                    Console.WriteLine("\nVocê ganhou essa rodada.");
                                    PontosJog += pontojogada;
                                }
                                else if (cartasJogador[cartaJogadaJog[1] - 1] < mediaCarta[0])
                                {
                                    Console.WriteLine("\nVocê perdeu essa rodada.");
                                    PontosPC += pontojogada;
                                }
                                else if (cartasJogador[cartaJogadaJog[1] - 1] == mediaCarta[0])
                                {
                                    if (cartasJogador[cartaJogadaJog[1] - 1] == 10)
                                    {
                                        if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[0] - 1])
                                        {
                                            Console.WriteLine("\nVocê perdeu essa rodada.");
                                            PontosPC += pontojogada;
                                        }
                                        if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[0] - 1])
                                        {
                                            Console.WriteLine("\nVocê ganhou essa rodada.");
                                            PontosJog += pontojogada;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpate novamente.");
                                        Console.ReadLine();
                                        Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], cartas[menorCarta[1]]);
                                        if (pontojogada == 1 && truco == "N")
                                        {
                                            Console.WriteLine("Deseja pedir truco?");
                                            truco = Console.ReadLine();
                                            pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                            if (pontojogada == -1)
                                            {
                                                pontojogada = 1;
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if (pontojogada == -4)
                                            {
                                                pontojogada = 3;
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        Console.WriteLine("\nJogue sua ultima carta.");
                                        cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nEmpate.");
                                Console.ReadLine();
                                Console.WriteLine("\nJogue a melhor carta. \nPc jogou: {0}{1}", cartas[maiorCarta[0]], naipes[maiorCarta[1]]);
                                if (pontojogada == 1 && truco == "N")
                                {
                                    Console.WriteLine("Deseja pedir truco?");
                                    truco = Console.ReadLine();
                                    pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                    if (pontojogada == -1)
                                    {
                                        pontojogada = 1;
                                        PontosJog += pontojogada;
                                        continue;
                                    }
                                    else if (pontojogada == -4)
                                    {
                                        pontojogada = 3;
                                        PontosPC += pontojogada;
                                        continue;
                                    }
                                }
                                Console.WriteLine("\nDigite sua melhor carta que ainda nao foi jogada.");
                                cartaJogadaJog[1] = naoRepetirCarta1(cartaJogadaJog[0], cartaJogadaJog[1]);

                                if (cartasJogador[cartaJogadaJog[1]- 1] > maiorCarta[0])
                                {
                                    Console.WriteLine("\nVocê ganhou essa rodada.");
                                    PontosJog += pontojogada;
                                }
                                else if (cartasJogador[cartaJogadaJog[1]- 1] < maiorCarta[0])
                                {
                                    Console.WriteLine("\nVocê perdeu essa rodada.");
                                    PontosPC += pontojogada;
                                }
                                else if (cartasJogador[cartaJogadaJog[1]-1] == maiorCarta[0])
                                {
                                    if (cartasJogador[cartaJogadaJog[1]-1] >= 9)
                                    {
                                        if (naipesPc[cartaPc] > naipesJogador[cartaJogadaJog[1] - 1])
                                        {
                                            Console.WriteLine("\nVocê perdeu essa rodada.");
                                            PontosPC += pontojogada;
                                        }
                                        if (naipesPc[cartaPc] < naipesJogador[cartaJogadaJog[1] - 1])
                                        {
                                            Console.WriteLine("\nVocê ganhou essa rodada.");
                                            PontosJog += pontojogada; ;
                                        }
                                    }
                                    else
                                    {//terminar
                                        if (cartaPc == 1)
                                        {
                                            Console.WriteLine("\nEmpate novamente.");
                                            Console.ReadLine();
                                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[menorCarta[0]], cartas[menorCarta[1]]);
                                            if (pontojogada == 1 && truco == "N")
                                            {
                                                Console.WriteLine("Deseja pedir truco?");
                                                truco = Console.ReadLine();
                                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                                if (pontojogada == -1)
                                                {
                                                    pontojogada = 1;
                                                    PontosJog += pontojogada;
                                                    continue;
                                                }
                                                else if (pontojogada == -4)
                                                {
                                                    pontojogada = 3;
                                                    PontosPC += pontojogada;
                                                    continue;
                                                }
                                            }
                                            Console.WriteLine("Digite sua ultima carta restante.");
                                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                            if(cartasJogador[cartaJogadaJog[2]-1] > menorCarta[0])
                                            {
                                                Console.WriteLine("Voce levou esta rodada.");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if(cartasJogador[cartaJogadaJog[2] - 1] < menorCarta[0])
                                            {
                                                Console.WriteLine("Pc levou esta rodada.");
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Empate novamente. Os dois pontuam");
                                                PontosJog += pontojogada;
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }
                                        else if (cartaPc == 2)
                                        {
                                            Console.WriteLine("\nEmpate novamente.");
                                            Console.ReadLine();
                                            Console.WriteLine("\nPc jogou: {0}{1}", cartas[mediaCarta[0]], cartas[mediaCarta[1]]);
                                            if (pontojogada == 1 && truco == "N")
                                            {
                                                Console.WriteLine("Deseja pedir truco?");
                                                truco = Console.ReadLine();
                                                pontojogada = Truco3(maiorCarta[0], maiorCarta[1], mediaCarta[0], mediaCarta[1], menorCarta[0], menorCarta[1], jogadaspc, jogadasjog, menorCarta[0], menorCarta[1], truco);
                                                if (pontojogada == -1)
                                                {
                                                    pontojogada = 1;
                                                    PontosJog += pontojogada;
                                                    continue;
                                                }
                                                else if (pontojogada == -4)
                                                {
                                                    pontojogada = 3;
                                                    PontosPC += pontojogada;
                                                    continue;
                                                }
                                            }
                                            Console.WriteLine("Digite sua ultima carta restante.");
                                            cartaJogadaJog[2] = naoRepetirCarta2(cartaJogadaJog[0], cartaJogadaJog[1], cartaJogadaJog[2]);
                                            if (cartasJogador[cartaJogadaJog[2] - 1] > mediaCarta[0])
                                            {
                                                Console.WriteLine("Voce levou esta rodada.");
                                                PontosJog += pontojogada;
                                                continue;
                                            }
                                            else if (cartasJogador[cartaJogadaJog[2] - 1] < mediaCarta[0])
                                            {
                                                Console.WriteLine("Pc levou esta rodada.");
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Empate novamente. Os dois pontuam");
                                                PontosJog += pontojogada;
                                                PontosPC += pontojogada;
                                                continue;
                                            }
                                        }

                                    }
                                }
                            }                            

                        }
                        
                    }
                }



                Console.Clear();
                Console.ReadLine();
            } while (PontosPC < 12 && PontosJog < 12);

            

            Console.WriteLine("\nO jogo acabou.");
            if(PontosJog > PontosPC)
            {
                Console.WriteLine("\nVOÇÊ GANHOU!");
            }
            else
            {
                Console.WriteLine("\nVoçê perdeu para um programa do 1 periodo! Parabens, você parece ter uns Q.I. a menos que o normal.");
            }
            Console.WriteLine("\nPlacar final: {0} a {1}", PontosJog, PontosPC);
            Console.ReadLine();
        }





        static int jogabilidade1(int carta1Pc,int naipe1Pc, int carta2Pc,int naipe2Pc, int carta3Pc,  int naipe3Pc, int cartaJog, int naipeJog, int vira)
        {
            Random rndNum = new Random();
            string[] naipes = { "Ouro", "Espadas", "Coração", "Paus" };
            string[] cartas = new string[10];
            
            if (vira == 0)
            {
                cartas[0] = "4"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "5";
            }

            if (vira == 1)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "6";
            }

            if (vira == 2)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "7";
            }

            if (vira == 3)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "Q";
            }

            if (vira == 4)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "J";
            }

            if (vira == 5)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "K";
            }

            if (vira == 6)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "A";
            }

            if (vira == 7)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "3"; cartas[9] = "2";
            }

            if (vira == 8)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3";
            }

            if (vira == 9)
            {
                cartas[0] = "5"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "4";
            }

            int[] cartasGeradas = new int[14];

            int[] cartasPc = { carta1Pc, carta2Pc, carta3Pc };
            int[] naipesPc = { naipe1Pc, naipe2Pc, naipe3Pc };
            int cartaJogada;
            int acumulador = 0;
            int empate = 0;
            int x = 0;

            for (x = 0; x < 3; x++)
            {
                
                if (cartasPc[x] > cartaJog)
                {
                    acumulador++;
                }
                else if (cartasPc[x] < cartaJog)
                {

                }
                else
                {
                    if(cartasPc[x] == 10 && cartaJog == 10)
                    {
                        if (naipesPc[x] > naipeJog)
                        { acumulador++;
                            continue;
                        }
                            
                    }
                    empate++;
                }
            } 
            if (acumulador == 1)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[0]], naipes[naipesPc[0]]);
                cartaJogada = 0;
                
            }
            else if(acumulador == 2)
            {
                Console.WriteLine("\nPc jogou: {0}{1}", cartas[cartasPc[1]], naipes[naipesPc[1]]);
                cartaJogada = 1;
                
            }
            else if (acumulador == 3)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[2]], naipes[naipesPc[2]]);
                cartaJogada = 2;
            }
            else if (empate == 1 && acumulador == 0)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[0]], naipes[naipesPc[0]]);
                cartaJogada = 0;
            }
            else if (empate == 1 && acumulador == 1)
            {
                int sorteio = rndNum.Next(0, 2);
                if (sorteio == 1)
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[1]], naipes[naipesPc[1]]);
                    cartaJogada = 1;
                }
                else
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[0]], naipes[naipesPc[0]]);
                    cartaJogada = 0;
                }
                
            } 
            else if (empate == 1 && acumulador == 2)
            {
                int sorteio = rndNum.Next(0, 2);
                if (sorteio == 1)
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[2]], naipes[naipesPc[2]]);
                    cartaJogada = 2;
                }
                else
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[1]], naipes[naipesPc[1]]);
                    cartaJogada = 1;
                }

            }

            else if (empate == 2 && acumulador == 0)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[1]], naipes[naipesPc[1]]);
                cartaJogada = 1;
            }
            else if(empate == 2 && acumulador == 1)
            {
                int sorteio = rndNum.Next(0, 2);
                if (sorteio == 1)
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[0]], naipes[naipesPc[0]]);
                    cartaJogada = 0;
                }
                else
                {
                    Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[2]], naipes[naipesPc[2]]);
                    cartaJogada = 2;
                }
            }
            else if (empate == 3 && acumulador == 0)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[2]], naipes[naipesPc[2]]);
                cartaJogada = 0;
            }
            else if (acumulador == 0)
            {
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[2]], naipes[naipesPc[2]]);
                cartaJogada = 2;
            }
            else
            {
                int sorteio = rndNum.Next(0, 3);
                Console.WriteLine("\nPc Jogou: {0}{1}", cartas[cartasPc[sorteio]], naipes[naipesPc[sorteio]]);
                cartaJogada = sorteio;
                
            }
 

            return cartaJogada;  
        }

        static int jogada1PcComecando(int carta1Jogador, int naipe1Jogador, int carta2Jogador, int naipe2Jogador, int carta3Jogador, int naipe3Jogador, int cartaMedia, int naipeCartaMedia, int vira, int Jogada1)
        {
            int pontoJogada = 0;
            int[] cartajogada = { carta1Jogador, carta2Jogador, carta3Jogador };
            int[] naipejogado = { naipe1Jogador, naipe2Jogador, naipe3Jogador };
            
            string[] cartas = new string[10];
            if (vira == 0)
            {
                cartas[0] = "4"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "5";
            }

            if (vira == 1)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "6";
            }

            if (vira == 2)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "7";
            }

            if (vira == 3)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "Q";
            }

            if (vira  == 4)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "J";
            }

            if (vira == 5)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "K";
            }

            if (vira == 6)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "A";
            }

            if (vira == 7)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "3"; cartas[9] = "2";
            }

            if (vira == 8)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3";
            }

            if (vira == 9)
            {
                cartas[0] = "5"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "4";
            }

            if (cartajogada[Jogada1-1] > cartaMedia)
                pontoJogada++;
            else if (cartajogada[Jogada1-1] == cartaMedia)
            {
                if (cartaMedia >= 9)
                {
                    if (naipeCartaMedia > naipejogado[Jogada1-1])
                    {
                        pontoJogada--;
                    }
                    else
                    {
                        pontoJogada++;
                    }
                }

            }
            else
                pontoJogada--;
            

            return pontoJogada;
        }

        static int jogada2PcComecando(int cartaPc, int naipePc, int carta1Jog, int naipe1Jog, int carta2Jog, int naipe2Jog, int carta3Jog, int naipe3Jog, int cartaJogada2, int vira)
        {
            int[] cartasJog = { carta1Jog, carta2Jog, carta3Jog };
            int[] naipesJog = { naipe1Jog, naipe2Jog, naipe3Jog };


            string[] gabarito = { "4", "5", "6", "7", "Q", "J", "K", "A", "2", "3" };
            
            int pontoJogada = 0;
            string[] cartas = new string[11];
            if (vira == 0)
            {
                cartas[0] = "4"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "5";
            }

            if (vira == 1)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "6";
            }

            if (vira == 2)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "7";
            }

            if (vira == 3)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "Q";
            }

            if (vira == 4)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "J";
            }

            if (vira == 5)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "K";
            }

            if (vira == 6)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "A";
            }

            if (vira == 7)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "3"; cartas[9] = "2";
            }

            if (vira == 8)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3";
            }

            if (vira == 9)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3"; cartas[10] = "4";
                
            }



            string[] naipes = { "Ouro", "Espadas", "Coração", "Paus" };

            
            
            if(cartaPc > cartasJog[cartaJogada2])
            {
                Console.WriteLine("\nPc ganhou a rodada.");
                pontoJogada--;
            }
            else if (cartaPc < cartasJog[cartaJogada2 - 1])
            {
                Console.WriteLine("\nVocê ganhou essa jogada.");
                pontoJogada++;
            }
            else if (cartaPc == cartasJog[cartaJogada2 - 1])
            {
                if (cartaPc >= 9)
                {
                    if (naipePc > naipesJog[cartaJogada2 - 1])
                    {
                        Console.WriteLine("\nPc ganhou a rodada.");
                        pontoJogada--;
                    }
                    else if (naipePc < naipesJog[cartaJogada2 - 1])
                    {
                        Console.WriteLine("\nVocê ganhou essa jogada. ");
                        pontoJogada++;
                    }
                }
                else
                {
                    Console.WriteLine("\nEmpate.");
                }
            }

            return pontoJogada;
        }    

        static int naoRepetirCarta1 (int cartaJogada1, int cartaJogada2)
        {
            do
            {
                cartaJogada2 = int.Parse(Console.ReadLine());

                if (cartaJogada1 == cartaJogada2)
                {
                    Console.WriteLine("\nDigite uma carta que nao foi jogada.");
                }
                else if(cartaJogada2 > 3)
                {
                    Console.WriteLine("\nDigite um número válido.");
                }

            } while (cartaJogada1 == cartaJogada2 || cartaJogada2 > 3);

            return cartaJogada2;
        }

        static int naoRepetirCarta2(int cartaJogada1, int cartaJogada2, int cartaJogada3)
        {
            do
            {
                cartaJogada3 = int.Parse(Console.ReadLine());

                if ((cartaJogada3 == cartaJogada2) || (cartaJogada3 == cartaJogada1))
                {
                    Console.WriteLine("\nDigite uma carta que nao foi jogada.");
                }
            } while ((cartaJogada3 == cartaJogada2) || (cartaJogada3 == cartaJogada1));

            return cartaJogada3;
        }

        static int  jogada3jogcomecando (int carta1jog, int naipe1jog, int carta2jog, int naipe2jog, int carta3jog, int naipe3jog, int cartapc, int naipepc, int cartaJogada1, int cartaJogada2, int cartaJogada3)
        {
            int pontosJogada = 0;
            int[] cartasJogador = { carta1jog, carta2jog, carta3jog };
            int[] naipesJogado = { naipe1jog, naipe2jog, naipe3jog };
            Console.WriteLine("\nQue carta deseja jogar?");
            cartaJogada3 = naoRepetirCarta2(cartaJogada1, cartaJogada2, cartaJogada3);
            Console.WriteLine("\nPc jogou: {0}{1}", cartapc, naipepc);
            if (cartasJogador[cartaJogada3-1] > cartapc)
            {
                Console.WriteLine("\nVocê ganhou esta rodada");
                pontosJogada++;
            }
            else if (cartasJogador[cartaJogada3 - 1] < cartapc)
            {
                Console.WriteLine("\nPc ganhou esta rodada");
                pontosJogada--;
            }
            else
            {
                Console.WriteLine("\nEmpate. Logo, Pc leva essa rodada.");
                pontosJogada--;
            }
            return pontosJogada;
        }

        static int jogabilidade2 (int cartaJogada, int naipeJogado, int carta1pc, int naipe1pc, int carta3pc, int naipe3pc, int vira)
        {
            string[] naipes = { "Ouro", "Espadas", "Coração", "Paus" };
            string[] cartas = new string[11];
            if (vira == 0)
            {
                cartas[0] = "4"; cartas[1] = "6"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "5";
            }

            if (vira == 1)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "7"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "6";
            }

            if (vira == 2)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "Q"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "7";
            }

            if (vira == 3)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "J"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "Q";
            }

            if (vira == 4)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "K"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "J";
            }

            if (vira == 5)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "A"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "K";
            }

            if (vira == 6)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "2"; cartas[8] = "3"; cartas[9] = "A";
            }

            if (vira == 7)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "3"; cartas[9] = "2";
            }

            if (vira == 8)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3";
            }

            if (vira == 9)
            {
                cartas[0] = "4"; cartas[1] = "5"; cartas[2] = "6"; cartas[3] = "7"; cartas[4] = "Q"; cartas[5] = "J"; cartas[6] = "K"; cartas[7] = "A"; cartas[8] = "2"; cartas[9] = "3"; cartas[10] = "4";
                
            }
            int cartajogada = 0;
            int[] cartasPc = { carta1pc, carta3pc };
            int[] naipesPc = { naipe1pc, naipe3pc };
            int acumulador = 0, empate = 0;
            for (int x=0; x < 2; x++)
            {
                if (cartasPc[x] > cartaJogada)
                    acumulador++;

                if(cartasPc[x] == cartaJogada)
                {
                    if(cartaJogada == vira + 1)
                    {
                        if (naipesPc[x] > naipeJogado)
                            acumulador++;                        
                    }
                    else
                    {
                        empate++;
                    }
                }
            }
            
            if(acumulador == 2)
            {                
                cartajogada = 1;
            }
            else if(empate == 2 && acumulador == 0)
            {               
                cartajogada = 1;
            }
            else if(acumulador == 0 && empate == 0)
            {                
                cartajogada = 1;
            }
            else if (acumulador == 1)
            {                
                cartajogada = 0;
            }
            else if (empate == 1 && acumulador == 0)
            {                
                cartajogada = 0;
            }
            return cartajogada;
        }

        static int Truco3(int carta1pc, int naipe1pc, int carta2pc, int naipe2pc, int carta3pc, int naipe3pc, int jogadaspc, int jogadasjog, int ultimacarta, int naipeultimacarta, string truco)
        {
            int pontojogada = 1;
            
            if (truco == "S" && jogadaspc == 0 && jogadasjog == 0)
            {
                Console.WriteLine("\n     TRUCO LADRAO!");
                if (carta1pc >= 7 && carta2pc >= 6)
                {
                    Console.WriteLine("\nPc aceitou o truco.");
                    pontojogada = 3;
                }
                else
                {
                    Console.WriteLine("\nPc fugiu do truco");
                    pontojogada = -1;
                }
            }
            else if (truco == "N" && jogadaspc == 0 && jogadasjog == 0)
            {
                if (carta1pc >= 8 && carta2pc >= 7)
                {
                    Console.WriteLine("\n   TRUCO LADRAO! \n\nPc pediu Truco. Aceitar ou aumentar?(S/N/6)");
                    truco = Console.ReadLine();
                    if(truco == "S")
                    {
                        pontojogada = 3;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -3;
                    }
                    else if (truco == "6")
                    {
                        if (carta1pc >= 9 && carta2pc >= 8)
                        {
                            Console.WriteLine("Pc aceitou o truco.");
                            pontojogada = 6;
                        }
                        else
                        {
                            Console.WriteLine("Pc fugiu.");
                            pontojogada = -2;
                        }
                    }
                } 
            }
            else if (truco == "S" && jogadaspc == 1 && jogadasjog == 0)
            {
                if (carta1pc >= 7 || carta3pc >= 6)
                {
                    Console.WriteLine("\nPc aceitou o truco.");
                    pontojogada = 3;
                }
                else if (carta1pc >= 9 && naipe1pc >= 2)
                {
                    Console.WriteLine("\nPc aumentou o truco para 6.");
                    Console.WriteLine("\nAceita ou corre? (S/N)");
                    truco = Console.ReadLine();
                    if (truco == "S")
                    {
                        pontojogada = 6;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -3;
                    }
                }
                else
                {
                    Console.WriteLine("\nPc fugiu do truco. ");
                    pontojogada = -1;
                }
            }
            else if (truco == "S" && jogadaspc == 0 && jogadasjog == 1)
            {
                if (carta1pc >= 8 && carta2pc >= 8 && carta3pc > 4)
                {
                    Console.WriteLine("\nPc aceitou o truco.");
                    pontojogada = 3;
                }
                else if (carta1pc >= 9 && carta2pc >= 9 && carta3pc >= 5)
                {
                    Console.WriteLine("\nPc aumentou o truco para 6.");
                    Console.WriteLine("\nAceita ou corre? (S/N)");
                    truco = Console.ReadLine();
                    if (truco == "S")
                    {
                        pontojogada = 6;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -4;
                    }
                }
                else
                {
                    Console.WriteLine("\nPc fugiu do truco. ");
                    pontojogada = -1;
                }
            }
            else if (truco == "N" && jogadaspc == 1 && jogadasjog == 0)
            {
                if (carta1pc >= 8 && carta2pc >= 7)
                {
                    Console.WriteLine("\n   TRUCO LADRAO!!!\n\nPc pediu truco. Aceitar ou aumentar?(S/N/6)");
                    truco = Console.ReadLine();
                    if (truco == "S")
                    {
                        pontojogada = 3;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -3;
                    }
                    else if (truco == "6")
                    {
                        if (carta1pc >= 9 && carta3pc >= 7)
                        {
                            Console.WriteLine("Pc aceitou o truco.");
                            pontojogada = 6;
                        }
                        else
                        {
                            Console.WriteLine("Pc fugiu.");
                            pontojogada = -2;
                        }
                    }
                }
            }
            else if (truco == "S" && jogadaspc == 1 && jogadasjog == 1)
            {
                if (ultimacarta >= 9)
                {
                    Console.WriteLine("Pc aceitou o truco.");
                    pontojogada = 3;
                }
                else if (ultimacarta >= 9 && naipeultimacarta == 3)
                {
                    Console.WriteLine("Pc aumentou para 6!");
                    Console.WriteLine("Deseja aceitar?(S/N)");
                    truco = Console.ReadLine();
                    if (truco == "S")
                    {
                        pontojogada = 6;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -4;
                    }
                }
                else
                {
                    Console.WriteLine("Pc fugiu!");
                    pontojogada = -1;
                }
            }
            else if (truco == "N" && jogadaspc == 1 && jogadasjog == 1)
            {
                if (ultimacarta >= 9)
                {
                    Console.WriteLine("\n    TRUCO LADRAO\n\nPc pediu truco. Aceitar ou aumentar?(S/N/6)");
                    truco = Console.ReadLine();
                    if (truco == "S")
                    {
                        pontojogada = 6;
                    }
                    else if (truco == "N")
                    {
                        pontojogada = -1;
                    }
                    else if (truco == "6")
                    {
                        if (ultimacarta >= 9 && naipeultimacarta >= 2)
                        {
                            Console.WriteLine("PC aceitou!");
                            pontojogada = 3;
                        }
                        else
                        {
                            Console.WriteLine("PC fugiu!");
                            pontojogada = -2;
                        }
                    }
                }
            }
           

            return pontojogada;
        }
        
       
       
    }
}
