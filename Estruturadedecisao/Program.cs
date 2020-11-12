using System;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Estruturadedecisao
{
    class Program
    {
        static void Main()
        {
            TelaInicial();
        }
        public static void TelaInicial()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||---------Exercicios de estrutura de decisão-----------||");
            Console.WriteLine("|| 1 Exercicio                                 Digite 1 ||");
            Console.WriteLine("|| 2 Exercicio                                 Digite 2 ||");
            Console.WriteLine("|| 3 Exercicio                                 Digite 3 ||");
            Console.WriteLine("|| 4 Exercicio                                 Digite 4 ||");
            Console.WriteLine("|| 5 Exercicio                                 Digite 5 ||");
            Console.WriteLine("|| 6 Exercicio                                 Digite 6 ||");
            Console.WriteLine("|| 7 Exercicio                                 Digite 7 ||");
            Console.WriteLine("|| 8 Exercicio                                 Digite 8 ||");
            Console.WriteLine("|| 9 Exercicio                                 Digite 9 ||");
            Console.WriteLine("|| 10 Exercicio                                Digite 10||");
            Console.WriteLine("||------------------------------------------------------||");
            Console.WriteLine("||Segunda Pagina-------------------------------Digite 0 ||");
            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 0:
                    Console.Clear();
                    SegundaTela();
                    break;
                case 1:
                    Console.Clear();
                    Exercicio1();
                    break;
                case 2:
                    Console.Clear();
                    Exercicio2();
                    break;
                case 3:
                    Console.Clear();
                    Exercicio3();
                    break;
                case 4:
                    Console.Clear();
                    Exercicio4();
                    break;
            }
        }
        public static void SegundaTela()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||---------Exercicios de estrutura de decisão-----------||");
            Console.WriteLine("|| 11 Exercicio                                Digite 1 ||");
            Console.WriteLine("|| 12 Exercicio                                Digite 2 ||");
            Console.WriteLine("|| 13 Exercicio                                Digite 3 ||");
            Console.WriteLine("|| 14 Exercicio                                Digite 4 ||");
            Console.WriteLine("|| 15 Exercicio                                Digite 5 ||");
            Console.WriteLine("|| 16 Exercicio                                Digite 6 ||");
            Console.WriteLine("|| 17 Exercicio                                Digite 7 ||");
            Console.WriteLine("|| 18 Exercicio                                Digite 8 ||");
            Console.WriteLine("|| 19 Exercicio                                Digite 9 ||");
            Console.WriteLine("|| 20 Exercicio                                Digite 10||");
            Console.WriteLine("||------------------------------------------------------||");
            Console.WriteLine("||Terceira Pagina------------------------------Digite 0 ||");
            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 0:
                    Console.Clear();
                    TerceiraTela();
                    break;
            }
        }
        public static void TerceiraTela()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||---------Exercicios de estrutura de decisão-----------||");
            Console.WriteLine("|| 21 Exercicio                                Digite 1 ||");
            Console.WriteLine("|| 22 Exercicio                                Digite 2 ||");
            Console.WriteLine("|| 23 Exercicio                                Digite 3 ||");
            Console.WriteLine("|| 24 Exercicio                                Digite 4 ||");
            Console.WriteLine("|| 25 Exercicio                                Digite 5 ||");
            Console.WriteLine("|| 26 Exercicio                                Digite 6 ||");
            Console.WriteLine("|| 27 Exercicio                                Digite 7 ||");
            Console.WriteLine("|| 28 Exercicio                                Digite 8 ||");
            Console.WriteLine("||------------------------------------------------------||");
            Console.WriteLine("||Tela Inicial---------------------------------Digite 0 ||");
            int esc = int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }

        public static void EscolhaDeTela()
        {
            Console.WriteLine("");
            Console.WriteLine("||-------------------------------------||");
            Console.WriteLine("Digite 0 para voltar a tela inicial: ");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc)) // vereficar se e um numero
            {
                if (esc == 0)
                {
                    Console.Clear();
                    TelaInicial();
                }

            }
            else
            {
                Console.WriteLine("esc Inválido");
            }
        }

        public static void Exercicio1()
        {
            Console.WriteLine("||---------------------- EXERCICIO 1 ----------------------------||");
            Console.WriteLine(" Faça um Programa que peça dois números e imprima o maior deles ");
            Console.WriteLine("Digite os dois numeros: ");
            string[] ex = Console.ReadLine().Split(' ');
            int nun1 = 0;
            int nun2 = 0;
            if (int.TryParse(ex[0], out nun1) && int.TryParse(ex[1], out nun2)) // && é um e
            {
                if (nun1 > nun2)
                {
                    Console.WriteLine($"O MAIOR DELES E: {nun1}");
                }
                else
                {
                    Console.WriteLine($"O MAIOR DELES E: {nun2}");
                }

            }
            else
            {
                Console.WriteLine("nun1 ou nun2 Inválida");
            }

            EscolhaDeTela();

        }

        public static void Exercicio2()
        {
            Console.WriteLine("||---------------------- EXERCICIO 2 ----------------------------||");
            Console.WriteLine("Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo");
            Console.WriteLine("Digite o numero: ");
            int nun1 = 0;
            if (int.TryParse(Console.ReadLine(), out nun1)) // vereficar se e um numero
            {
                if (nun1 >= 0)
                {
                    Console.WriteLine($"Esse numero e positivo: {nun1}");
                }
                else
                {
                    Console.WriteLine($"Esse numero e negativo: {nun1}");
                }
            }
            else
            {
                Console.WriteLine("nun1 Inválida");
            }

            EscolhaDeTela();

        }
        public static void Exercicio3()
        {
            Console.WriteLine("||---------------------- EXERCICIO 3 ----------------------------||");
            Console.Write("Pergunta :Faça um Programa que verifique se uma letra digitada é F ou M . Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.");
            char genero = 'O';
            if (char.TryParse(Console.ReadLine(), out genero)) 
            {
                if (genero == 'M'|| genero == 'm')
                {
                    Console.WriteLine($"{genero} - Masculino");
                }
                else if (genero == 'F' || genero == 'f')
                {
                    Console.WriteLine($"{genero} - Feminino");
                }
                else
                {
                    Console.WriteLine($"{genero} Sexo Inválido");
                }

            }
            else
            {
                Console.WriteLine("genero Inválido");
            }

            EscolhaDeTela();


        }
        public static void Exercicio4()
        {
            Console.WriteLine("||---------------------- EXERCICIO 3 ----------------------------||");
            Console.Write("Pergunta:  Faça um Programa que verifique se uma letra digitada é vogal ou consoante ");
            Console.WriteLine("Digite uma letra");
            string vogal = Console.ReadLine();
            if (vogal.ToLower() == "a" || vogal.ToLower() == "e" || vogal.ToLower() == "i" || vogal.ToLower() == "o" || vogal.ToLower() == "u")
            {
                Console.WriteLine($"");

            }
          
        }

    }
}



/*public static void Exercicio3()
{
    Console.WriteLine("||---------------------- EXERCICIO 3 ----------------------------||");
    Console.Write("Pergunta: ");

    Console.WriteLine("");
    Console.WriteLine("||-------------------------------------||");
    Console.WriteLine("Digite 0 para voltar a tela inicial: ");
    int esc = int.Parse(Console.ReadLine());
    if (esc == 0)
    {
        Console.Clear();
        TelaInicial();
    }
}*/