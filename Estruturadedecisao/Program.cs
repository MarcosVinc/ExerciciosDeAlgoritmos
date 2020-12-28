
using System;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PrototipoEstruturaDeDecisao
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
            Console.WriteLine("||                  Primeira Pagina                     ||");
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
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||Escolher um exercicio especifico----------- Digite 100||");
            Console.WriteLine("");
            string esc1 = (Console.ReadLine());
            int esc = 0;
            if (int.TryParse(esc1, out esc))
            {

                switch (esc)
                {
                    case 300195:
                        Console.Clear();
                        EasterEgg();
                        break;
                    case 0:
                        Console.Clear();
                        SegundaTela();
                        break;
                    case 100:
                        Console.Clear();
                        EscolhDeTela2();
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
                    case 5:
                        Console.Clear();
                        Exercicio5();
                        break;
                    case 6:
                        Console.Clear();
                        Exercicio6();
                        break;
                    case 7:
                        Console.Clear();
                        Exercicio7();
                        break;
                    case 8:
                        Console.Clear();
                        Exercicio8();
                        break;
                    case 9:
                        Console.Clear();
                        Exercicio9();
                        break;
                    case 10:
                        Console.Clear();
                        Exercicio10();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Comando Invalido caso Primario, a atividade não consta na pagina!");
                EscolhaDeTela();
            }
            Console.WriteLine("Comando Invalido caso Secundario, erro de leitura. O valor que você digitou não pode ser recebido!");
            EscolhaDeTela();
        }
        public static void SegundaTela()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||                   Segunga Pagina                     ||");
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
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||Escolher um exercicio especifico----------- Digite 100||");
            Console.WriteLine("");
            string esc1 = (Console.ReadLine());
            int esc = 0;
            if (int.TryParse(esc1, out esc))
            {

                switch (esc)
                {
                    case 0:
                        Console.Clear();
                        TerceiraTela();
                        break;
                    case 1:
                        Console.Clear();
                        Exercicio11();
                        break;
                    case 2:
                        Console.Clear();
                        Exercicio12();
                        break;
                    case 3:
                        Console.Clear();
                        Exercicio13();
                        break;
                    case 4:
                        Console.Clear();
                        Exercicio14();
                        break;
                    case 5:
                        Console.Clear();
                        Exercicio15();
                        break;
                    case 6:
                        Console.Clear();
                        Exercicio16();
                        break;
                    case 7:
                        Console.Clear();
                        Exercicio17();
                        break;
                    case 8:
                        Console.Clear();
                        Exercicio18();
                        break;
                    case 9:
                        Console.Clear();
                        Exercicio19();
                        break;
                    case 10:
                        Console.Clear();
                        Exercicio20();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Comando Invalido caso Primario, a atividade não consta na pagina!");
                EscolhaDeTela();
            }
            Console.WriteLine("Comando Invalido caso Secundario, erro de leitura. O valor que você digitou não pode ser recebido!");
            EscolhaDeTela();

        }
        public static void TerceiraTela()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||                   Terceira Pagina                    ||");
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
            Console.WriteLine("||Primeira Pagina------------------------------Digite 0 ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||                                                      ||");
            Console.WriteLine("||Escolher um exercicio especifico----------- Digite 100||");
            Console.WriteLine("");
            string esc1 = (Console.ReadLine());
            int esc = 0;
            if (int.TryParse(esc1, out esc))
            {

                switch (esc)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                    case 1:
                        Console.Clear();
                        Exercicio21();
                        break;
                    case 2:
                        Console.Clear();
                        Exercicio22();
                        break;
                    case 3:
                        Console.Clear();
                        Exercicio23();
                        break;
                    case 4:
                        Console.Clear();
                        Exercicio24();
                        break;
                    case 5:
                        Console.Clear();
                        Exercicio25();
                        break;
                    case 6:
                        Console.Clear();
                        Exercicio26();
                        break;
                    case 7:
                        Console.Clear();
                        Exercicio27();
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Comando Invalido caso Primario, a atividade não consta na pagina!");
                EscolhaDeTela();
            }
            Console.WriteLine("Comando Invalido caso Secundario, erro de leitura. O valor que você digitou não pode ser recebido!");
            EscolhaDeTela();
        }

        public static void EscolhaDeTela()
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha a opção que você deseja: ");
            Console.WriteLine(" 0 para ir a TELA INICIAL e 1 para escolher um Exercicio Especifico");
            int esc = 0;

            if (int.TryParse(Console.ReadLine(), out esc)) // verifica se e um numero
            {
                if (esc == 0)
                {
                    Console.Clear();
                    TelaInicial();
                }
                else if (esc == 1)
                {

                    Console.Clear();
                    EscolhDeTela2();
                }

            }
            Console.WriteLine("Comando Invalido caso Secundario, erro de leitura. O valor que você digitou não pode ser recebido!");
            EscolhaDeTela();


        }
        public static void EscolhDeTela2()
        {
            Console.WriteLine("Escolha um exercicio especifico: ");
            string esc1 = (Console.ReadLine());
            int esc = 0;
            if (int.TryParse(esc1, out esc))
            {

                switch (esc)
                {
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
                    case 5:
                        Console.Clear();
                        Exercicio5();
                        break;
                    case 6:
                        Console.Clear();
                        Exercicio6();
                        break;
                    case 7:
                        Console.Clear();
                        Exercicio7();
                        break;
                    case 8:
                        Console.Clear();
                        Exercicio8();
                        break;
                    case 9:
                        Console.Clear();
                        Exercicio9();
                        break;
                    case 10:
                        Console.Clear();
                        Exercicio10();
                        break;
                    case 11:
                        Console.Clear();
                        Exercicio11();
                        break;
                    case 12:
                        Console.Clear();
                        Exercicio12();
                        break;
                    case 13:
                        Console.Clear();
                        Exercicio13();
                        break;
                    case 14:
                        Console.Clear();
                        Exercicio14();
                        break;
                    case 15:
                        Console.Clear();
                        Exercicio15();
                        break;
                    case 16:
                        Console.Clear();
                        Exercicio16();
                        break;
                    case 17:
                        Console.Clear();
                        Exercicio17();
                        break;
                    case 18:
                        Console.Clear();
                        Exercicio18();
                        break;
                    case 19:
                        Console.Clear();
                        Exercicio19();
                        break;
                    case 20:
                        Console.Clear();
                        Exercicio20();
                        break;
                    case 21:
                        Console.Clear();
                        Exercicio21();
                        break;
                    case 22:
                        Console.Clear();
                        Exercicio22();
                        break;
                    case 23:
                        Console.Clear();
                        Exercicio23();
                        break;
                    case 24:
                        Console.Clear();
                        Exercicio24();
                        break;
                    case 25:
                        Console.Clear();
                        Exercicio25();
                        break;
                    case 26:
                        Console.Clear();
                        Exercicio26();
                        break;
                    case 27:
                        Console.Clear();
                        Exercicio27();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Comando Invalido!");
                EscolhaDeTela();
            }
            Console.WriteLine("Comando Invalido caso Secundario, erro de leitura. O valor que você digitou não pode ser recebido!");
            EscolhaDeTela();


        }
        public static void EasterEgg()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|FaceBook: https://www.facebook.com/marcos.viniciuswac");
            Console.WriteLine("");
            Console.WriteLine("|Instagram: https://www.instagram.com/marcl.x/?hl=pt-br");
            Console.WriteLine("");
            Console.WriteLine("|Twitter: https://twitter.com/MarcosV10865185");
            Console.WriteLine("");
            Console.WriteLine("|Github:https://github.com/MarcosVinc");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("|Emulador de SuperNintendo: https://drive.google.com/file/d/1Y5DoZrt16avq3NXH39IAA0gFLQk4SBAT/view?usp=sharing");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            EscolhaDeTela();

        }


        public static void Exercicio1()
        {
            Console.WriteLine("||---------------------- EXERCICIO 1 ----------------------------||");
            Console.WriteLine(" Faça um Programa que peça dois números e imprima o maior deles ");
            Console.WriteLine("Digite os dois numeros: ");
            Console.WriteLine("Esse exercicio foi feito em VETOR![]");
            Console.WriteLine("Digite com espaço entre os números, exemplo: 1  2");
            string[] ex = Console.ReadLine().Split(' ');
            double nun1 = 0;
            double nun2 = 0;
            if (double.TryParse(ex[0], out nun1) && double.TryParse(ex[1], out nun2)) // && é um e
            {
                if (nun1 > nun2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O MAIOR DELES E: {nun1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O MAIOR DELES E: {nun2:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
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
            double nun1 = 0;
            if (double.TryParse(Console.ReadLine(), out nun1)) // vereficar se e um numero
            {
                if (nun1 >= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"Esse numero e positivo: {nun1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"Esse numero e negativo: {nun1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
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
            Console.WriteLine("Pergunta :Faça um Programa que verifique se uma letra digitada é F ou M .");
            Console.WriteLine(" Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.");
            char genero = 'O';
            if (char.TryParse(Console.ReadLine(), out genero))
            {
                if (genero == 'M' || genero == 'm')
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"{genero} - Masculino");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (genero == 'F' || genero == 'f')
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"{genero} - Feminino");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"{genero} Sexo Inválido");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
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
            Console.WriteLine("||---------------------- EXERCICIO 4 ----------------------------||");
            Console.WriteLine("Pergunta:  Faça um Programa que verifique se uma letra digitada é vogal ou consoante ");
            Console.WriteLine("Digite uma letra");
            string vogal = Console.ReadLine();
            if (vogal.ToLower() == "a" || vogal.ToLower() == "e" || vogal.ToLower() == "i" || vogal.ToLower() == "o" || vogal.ToLower() == "u")
            {
                Console.WriteLine("");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("|                                        |");
                Console.WriteLine($"A letra que você digitou e uma vogal!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("|                                        |");
                Console.WriteLine("A letra que você digitou não e uma vogal!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");

            }
            EscolhaDeTela();

        }
        public static void Exercicio5()
        {
            Console.WriteLine("||---------------------- EXERCICIO 5 ----------------------------||");
            Console.WriteLine("Pergunta:  Faça um programa para a leitura de duas notas parciais de um aluno.");
            Console.WriteLine("O programa deve calcular a média alcançada por aluno e apresentar.");
            Console.WriteLine("A mensagem Aprovado, se a média alcançada for maior ou igual a sete;");
            Console.WriteLine("A mensagem Reprovado, se a média for menor do que sete");
            Console.WriteLine("A mensagem Aprovado com Distinção, se a média for igual a dez");
            Console.WriteLine("");
            Console.WriteLine("Digite a primeira nota do aluno: ");
            string nota1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda nota do aluno: ");
            string nota2 = Console.ReadLine();
            double n1 = 0;
            double n2 = 0;

            if (double.TryParse(nota1, out n1) && double.TryParse(nota2, out n2))
            {
                double mediaDeNotas = (n1 + n2) / 2;

                if (mediaDeNotas >= 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Aprovado!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (mediaDeNotas < 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Reprovado!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (mediaDeNotas == 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Aprovado com Distinção!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("nota Inválida");

                }



            }
            EscolhaDeTela();

        }
        public static void Exercicio6()
        {
            Console.WriteLine("||---------------------- EXERCICIO 6 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um Programa que leia três números e mostre o maior deles ");
            Console.WriteLine("Digite o primeiro numero: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo numero: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro numero: ");
            string n3 = Console.ReadLine();
            Console.WriteLine("");
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            if (double.TryParse(n1, out num1) && double.TryParse(n2, out num2) && double.TryParse(n3, out num3))
            {
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num2:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num3:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }

            }
            else
            {
                Console.WriteLine("n1 Inválida");
            }

            EscolhaDeTela();

        }
        public static void Exercicio7()
        {
            Console.WriteLine("||---------------------- EXERCICIO 7 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que leia três números e mostre o maior e o menor deles");
            Console.WriteLine("Digite o primeiro numero: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo numero: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro numero: ");
            string n3 = Console.ReadLine();
            Console.WriteLine("");
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            if (double.TryParse(n1, out num1) && double.TryParse(n2, out num2) && double.TryParse(n3, out num3))
            {
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num2:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O maior e o: {num3:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }

            }
            if (double.TryParse(n1, out num1) && double.TryParse(n2, out num2) && double.TryParse(n3, out num3))
            {
                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O menor e o: {num1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O menor e o: {num2:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O menor e o: {num3:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }

            }
            else
            {
                Console.WriteLine("n1 Inválida");
            }

            EscolhaDeTela();

        }
        public static void Exercicio8()
        {
            Console.WriteLine("||---------------------- EXERCICIO 8 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um programa que pergunte o preço de três produtos e informe qual");
            Console.WriteLine("produto você deve comprar, sabendo que adecisão é sempre pelo mais barato.");
            Console.WriteLine("");
            Console.WriteLine("Digite o preço do primeiro produto: ");
            string produto1 = Console.ReadLine();
            Console.WriteLine("Digite o preço do segundo produto: ");
            string produto2 = Console.ReadLine();
            Console.WriteLine("Digite o preço do terceiro produto: ");
            string produto3 = Console.ReadLine();
            double preco1 = 0;
            double preco2 = 0;
            double preco3 = 0;
            if (double.TryParse(produto1, out preco1) && double.TryParse(produto2, out preco2) && double.TryParse(produto3, out preco3))
            {
                if (preco1 < preco2 && preco1 < preco3)
                {
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O produto mas barato e o de valor: R$: {preco1:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (preco2 < preco1 && preco2 < preco3)
                {
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O produto mas barato e o de valor: R$: {preco2:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O produto mas barato e o de valor: R$: {preco3:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
            }
            else
            {
                Console.WriteLine("produto Inválido");

            }

            EscolhaDeTela();

        }
        public static void Exercicio9()
        {
            Console.WriteLine("||---------------------- EXERCICIO 9 ----------------------------||");
            Console.WriteLine("Pergunta:  Faça um Programa que leia três números e mostre-os em ordem decrescente ");
            Console.WriteLine("");
            Console.WriteLine("Digite os três numeros: ");
            string[] numeros = Console.ReadLine().Split(' ');
            string a = "";
            int nun1 = 0;
            int nun2 = 0;
            int nun3 = 0;
            if (int.TryParse(numeros[0], out nun1) && int.TryParse(numeros[1], out nun2) && int.TryParse(numeros[2], out nun3))
            {
                int[] numerosint = Array.ConvertAll(numeros, s => int.Parse(s));
                bubblesort(numerosint);
                for (int i = 0; i < numerosint.Length; i++)
                {
                    a += " " + numerosint[i];
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"A forma ordenada decrescente dos numeros são: {a}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }



            }

            else
            {
                Console.WriteLine("numero Inválido");

            }

            EscolhaDeTela();

        }

        // criando o método bubblesort
        public static void bubblesort(int[] y)
        {
            for (int i = 1; i < y.Length; i++)
                for (int j = 0; j < y.Length - 1; j++)
                    if (y[j] < y[j + 1])
                        troca(y, j);
        }
        // algoritmo de troca de valores de variáveis:
        public static void troca(int[] g, int primeiro)
        {
            int aux;
            aux = g[primeiro];
            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = aux;
        }
        public static void Exercicio10()
        {
            Console.WriteLine("||---------------------- EXERCICIO 10 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-Vespertino ou N- Noturno ");
            Console.WriteLine("Imprima a mensagem Bom Dia!, Boa Tarde! ou Boa Noite! ou Valor Inválido!, conforme o caso.");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("----------------------- Que turno você estuda ? -----------------------");
            Console.WriteLine("--- DIGITE M para Matutino --- V para Vespertino --- N para noturno ---");
            string entrada = Console.ReadLine();
            Console.WriteLine("");
            if (entrada.ToLower() == "m")
            {
                Console.WriteLine("Bom dia!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");
            }
            else if (entrada.ToLower() == "v")
            {
                Console.WriteLine("Boa tarde!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");
            }
            else if (entrada.ToLower() == "n")
            {
                Console.WriteLine("Boa noite!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");
            }
            else
            {
                Console.WriteLine("Valor invalido!");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|----------------------------------------|");
            }

            EscolhaDeTela();
        }
        public static void Exercicio11()
        {
            Console.WriteLine("||---------------------- EXERCICIO 11 ----------------------------||");
            Console.WriteLine("Pergunta: As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e lhe contraram para");
            Console.WriteLine("desenvolver o programa que calculará os reajustes.");
            Console.WriteLine("");
            Console.WriteLine("Digite seu salário atual: ");
            double salarioAtual = double.Parse(Console.ReadLine());
            double aumento20 = (salarioAtual * 20) / 100;
            double aumento15 = (salarioAtual * 15) / 100;
            double aumento10 = (salarioAtual * 10) / 100;
            double aumento5 = (salarioAtual * 5) / 100;
            Console.WriteLine("");
            Console.WriteLine($"Salario antes do reajuste: R$:{salarioAtual}");
            Console.WriteLine("");
            if (salarioAtual < 280)
            {
                Console.WriteLine("o percentual de aumento aplicado: 20%");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o valor do aumento: R$:{aumento20:f2}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o novo salário, após o aumento R$:{salarioAtual + aumento20:f2}");
            }
            if (salarioAtual >= 280 && salarioAtual < 700)
            {
                Console.WriteLine("o percentual de aumento aplicado: 15%");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o valor do aumento: R$:{aumento15:f2}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o novo salário, após o aumento R$:{salarioAtual + aumento15:f2}"); ;
            }
            if (salarioAtual >= 700 && salarioAtual < 1500)
            {
                Console.WriteLine("o percentual de aumento aplicado: 10%");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o valor do aumento: R$:{aumento10:f2}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o novo salário, após o aumento R$:{salarioAtual + aumento10:f2}");
            }
            if (salarioAtual >= 1500)
            {
                Console.WriteLine("o percentual de aumento aplicado: 5%");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o valor do aumento: R$:{aumento5:f2}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"o novo salário, após o aumento R$:{salarioAtual + aumento5:f2}");
            }


            EscolhaDeTela();

        }
        public static void Exercicio12()
        {
            Console.WriteLine("||---------------------- EXERCICIO 12 ----------------------------||");
            Console.WriteLine("Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do Imposto de Renda,");
            Console.WriteLine(" que depende do salário bruto(conforme tabela abaixo) e 3 % para o Sindicato e que o FGTS corresponde a 11 % do SalárioBruto");
            Console.WriteLine("mas não é descontado (é a empresa que deposita). O Salário Líquido corresponde ao Salário Bruto menos osdescontos");
            Console.WriteLine("Pergunta:  O programa deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês");
            Console.WriteLine("");
            Console.WriteLine("Digite o valor da sua hora trabalhada");
            double valorTrabalhado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas no mês");
            double horaTrabalhada = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double salarioBruto = valorTrabalhado * horaTrabalhada;
            double ir = (salarioBruto * 5) / 100;
            double inss = (salarioBruto * 10) / 100;
            double fgts = (salarioBruto * 11) / 100;
            double acima2500 = (salarioBruto * 20) / 100;

            if (salarioBruto <= 900)
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir} ISENTO ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {salarioBruto - inss}");
            }
            else if (salarioBruto > 900 && salarioBruto <= 1500)
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {(salarioBruto - ir) - inss} ");
            }
            else if (salarioBruto > 1500 && salarioBruto <= 2500)
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {(salarioBruto - ir) - inss} ");
            }
            else
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {salarioBruto - acima2500} ");
            }



            EscolhaDeTela();

        }
        public static void Exercicio13()
        {
            Console.WriteLine("||---------------------- EXERCICIO 13 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que leia um número e exiba o dia correspondente da semana. (1-Domingo, 2- Segunda, etc.), se digitar");
            Console.WriteLine("outro valor deve aparecer valor inválido");
            Console.WriteLine("");
            Console.WriteLine("Digite o numero: ");
            string numero = Console.ReadLine();
            int numeroDaSemana = 0;
            if (int.TryParse(numero, out numeroDaSemana))
            {

                if (numeroDaSemana == 1)
                {
                    Console.WriteLine("Domingo");
                }
                else if (numeroDaSemana == 2)
                {
                    Console.WriteLine("Segunda-Feira");
                }
                else if (numeroDaSemana == 3)
                {
                    Console.WriteLine("Terça-Feira");
                }
                else if (numeroDaSemana == 4)
                {
                    Console.WriteLine("Quarta-Feira");
                }
                else if (numeroDaSemana == 5)
                {
                    Console.WriteLine("Quinta-Feira");
                }
                else if (numeroDaSemana == 6)
                {
                    Console.WriteLine("Sexta-Feira");
                }
                else if (numeroDaSemana == 7)
                {
                    Console.WriteLine("Sabado");
                }
                else
                {
                    Console.WriteLine("Numero Invalido");
                }

                Console.WriteLine("");
                EscolhaDeTela();
            }


        }
        public static void Exercicio14()
        {
            Console.WriteLine("||---------------------- EXERCICIO 14 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um programa que lê as duas notas parciais obtidas por um aluno numa disciplina ao longo de um semestre, e calcule");
            Console.WriteLine("a sua média");
            Console.WriteLine("");
            Console.WriteLine("Digite a primeira nota do aluno: ");
            string primeiraNota = Console.ReadLine();
            Console.WriteLine("Digite a segunda nota do aluno: ");
            string segundaNota = Console.ReadLine();
            Console.WriteLine("");
            double nota1 = 0;
            double nota2 = 0;

            if (double.TryParse(primeiraNota, out nota1) && double.TryParse(segundaNota, out nota2))
            {
                double mediaDeNotas = (nota1 + nota2) / 2;

                if (mediaDeNotas == 9 && mediaDeNotas < 10)
                {
                    Console.WriteLine($"Media:{mediaDeNotas:f2}, APROVADO");
                    Console.WriteLine("Conceito A aplicado!");
                }
                else if (mediaDeNotas == 7.5 && mediaDeNotas < 9)
                {
                    Console.WriteLine($"Media:{mediaDeNotas:f2}, APROVADO");
                    Console.WriteLine("Conceito B aplicado!");
                }
                else if (mediaDeNotas == 6 && mediaDeNotas < 7.5)
                {
                    Console.WriteLine($"Media:{mediaDeNotas:f2}, APROVADO");
                    Console.WriteLine("Conceito C aplicado!");
                }
                else if (mediaDeNotas == 4 && mediaDeNotas < 6)
                {
                    Console.WriteLine($"Media:{mediaDeNotas:f2}, REPROVADO");
                    Console.WriteLine("Conceito D aplicado!");
                }
                else if (mediaDeNotas == 0 && mediaDeNotas < 4)
                {
                    Console.WriteLine($"Media:{mediaDeNotas:f2}, REPROVADO");
                    Console.WriteLine("Conceito C aplicado!");
                }
                else
                {
                    Console.WriteLine("Numero Invalido");

                }

            }
            EscolhaDeTela();

        }
        public static void Exercicio15()
        {
            Console.WriteLine("||---------------------- EXERCICIO 15 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que peça os 3 lados de um triângulo ");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro lado: ");
            string primeiroLado = Console.ReadLine();
            Console.WriteLine("Digite o segundo lado: ");
            string segundoLado = Console.ReadLine();
            Console.WriteLine("Digite o terceiro lado: ");
            string terceiroLado = Console.ReadLine();
            Console.WriteLine("");
            double l1 = 0;
            double l2 = 0;
            double l3 = 0;
            if (double.TryParse(primeiroLado, out l1) && double.TryParse(segundoLado, out l2) && double.TryParse(terceiroLado, out l3))
            {
                if ((l1 == l2) && (l1 == l3) && (l2 == l1) && (l2 == l3) && (l3 == l1) && (l3 == l2))
                {
                    Console.WriteLine("Triângulo Equilátero: três lados iguais");
                }
                else if (((l1 == l2) && (l1 != l3)) || ((l2 == l1) && (l2 != l3)) || ((l3 == l1) && (l3 != l2)))


                {
                    Console.WriteLine("Triângulo Isósceles: quaisquer dois lados iguais");
                }
                else if ((l1 != l2) && (l1 != l3) && (l2 != l1) && (l2 != l3) && (l3 != l1) && (l3 != l2))
                {
                    Console.WriteLine("Triângulo Escaleno: três lados diferentes;");
                }
                else
                {
                    Console.WriteLine("Numero Invalido");
                }

            }

            EscolhaDeTela();

        }
        public static void Exercicio16()
        {
            Console.WriteLine("||---------------------- EXERCICIO 16 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um programa que calcule as raízes de uma equação do segundo grau, na forma ax2 + bx + c. ");
            Console.WriteLine("O programa deverá pedir os valores de a, b e c e fazer as consistências");
            Console.WriteLine("");
            Console.WriteLine("Digite o valor de A:");
            string valorA = Console.ReadLine();
            double a = 0;
            if (double.TryParse(valorA, out a))
            {
                if (a == 0)
                {
                    Console.WriteLine("Se o usuário informar o valor de A igual a zero, a equação não é do segundo grau e o programa não deve fazer pedir os demais valores, sendo encerrado");
                    Console.WriteLine("");
                    Console.WriteLine("Tchau!");
                    Console.ReadLine();
                    Console.Clear();
                    Exercicio16();
                }

            }
            Console.WriteLine("Digite o valor de B:");
            string valorB = Console.ReadLine();
            Console.WriteLine("Digite o valor de C:");
            string valorC = Console.ReadLine();
            double b = 0;
            double c = 0;
            if (double.TryParse(valorB, out b) && double.TryParse(valorC, out c))
            {
                double calculoDeltaPotencia = b * b;
                double calculoDeltaQuatro = -4 * a;
                double calculoDeltaMeio = calculoDeltaQuatro * c;
                double Delta = calculoDeltaPotencia + calculoDeltaMeio;

                if (Delta < 0)
                {

                    Console.WriteLine($"Se o delta calculado for negativo, a equação não possui raizes reais.");
                    Console.WriteLine($"Informe ao usuário e encerre o programa DELTA {Delta}");
                    Console.WriteLine("Tchau!");
                    Console.ReadLine();
                    Console.Clear();
                    Exercicio16();

                }
                else if (Delta == 0)
                {
                    double valorDeX = (-b) / 2 * a; ;
                    Console.WriteLine(". Se o delta calculado for igual a zero a equação possui apenas uma raiz real; informe-a ao usuário;");
                    Console.WriteLine($"RAIZ {valorDeX}");

                }
                else if (Delta > 0)
                {
                    double raizMaisA = -b + (Math.Sqrt(Delta));
                    double raizMaisFinal = raizMaisA / (2 * a);
                    double raizMenosA = -b - (Math.Sqrt(Delta));
                    double raizMenosFinal = raizMenosA / (2 * a);

                    double raizDeMenos = (-b - (Math.Sqrt(Delta)) / (2 * a));
                    Console.WriteLine(". Se o delta for positivo, a equação possui duas raiz reais; informe-as ao usuário;");
                    Console.WriteLine($"RAIZ  do +: {raizMaisFinal}");
                    Console.WriteLine($"RAIZ  do -: {raizDeMenos}");


                }

            }

            EscolhaDeTela();

        }


        public static void Exercicio17()
        {
            Console.WriteLine("||---------------------- EXERCICIO 17 ----------------------------||");
            Console.WriteLine("Faça um Programa que peça um número correspondente a um determinado ano e em seguida informe se este ano é ou não bissexto");
            Console.WriteLine("Digite o ano: ");
            string ano = Console.ReadLine();
            double anoBissexto = 0;
            if (double.TryParse(ano, out anoBissexto))
            {


                if (((anoBissexto % 400) == 0) || (anoBissexto % 4 == 0 && anoBissexto % 100 != 0))
                {
                    Console.WriteLine("Ano Bissexto");

                }
                else
                {
                    Console.WriteLine("Esse ano não é bissexto");
                }

            }


            EscolhaDeTela();

        }
        public static void Exercicio18()
        {
            Console.WriteLine("||---------------------- EXERCICIO 18 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que peça uma data no formato dd/mm/aaaa e determine se a mesma é uma data válida ");
            Console.WriteLine("");
            Console.WriteLine("Digite a data desejada: ");
            Console.WriteLine("Digite o Dia:");
            string diaPrimeiro = Console.ReadLine();
            Console.WriteLine("Digite o Mês:");
            string mesPrimeiro = Console.ReadLine();
            Console.WriteLine("Digite o Ano:");
            string anoPrimeiro = Console.ReadLine();
            int dia = 0;
            int mes = 0;
            int ano = 0;
            if (int.TryParse(diaPrimeiro, out dia) && int.TryParse(mesPrimeiro, out mes) && int.TryParse(anoPrimeiro, out ano))
            {
                if ((dia > 31 && dia <= 0) || (mes > 12 && mes < 1) || (ano <= 0))
                {
                    Console.WriteLine("Esse ano non exziste!");

                }
                else
                {

                    Console.WriteLine($"A DATA QUE VOCÊ ESCREVEU FOI: {dia}/{mes}/{ano}");
                }


            }

            EscolhaDeTela();

        }
        public static void Exercicio19()
        {
            Console.WriteLine("||---------------------- EXERCICIO 19 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um Programa que leia um número inteiro menor que 1000 e imprima a quantidade de centenas, dezenas e unidades");
            Console.WriteLine("do mesmo");
            Console.WriteLine("");
            Console.WriteLine("Digite um numero inteiro: ");
            int nun = 0;
            if (int.TryParse(Console.ReadLine(), out nun))
            {

                if (nun >= 1001)
                {
                    Console.WriteLine($"Esse numero e maior que 1000! {nun}");
                    EscolhaDeTela();

                }
                else if (nun >= 0 && nun <= 1000)
                {
                    int centena = 0;
                    int dezena = 0;
                    int unidade = 0;

                    centena = nun / 100;
                    dezena = (nun % 100) / 10;
                    unidade = (nun % 100) % 10;
                    Console.WriteLine($"Centena {centena}, dezena {dezena}, unidade {unidade}");


                }


            }

            EscolhaDeTela();
        }
        public static void Exercicio20()
        {
            Console.WriteLine("||---------------------- EXERCICIO 20 ----------------------------||");
            Console.WriteLine(" Faça um Programa para leitura de três notas parciais de um aluno.");
            Console.WriteLine("O programa deve calcular a média alcançada por aluno e apresentar.");
            Console.WriteLine(". A mensagem Aprovado, se a média for maior ou igual a 7, com a respectiva média alcançada");
            Console.WriteLine("A mensagem Reprovado, se a média for menor do que 7, com a respectiva média alcançada;");
            Console.WriteLine(" A mensagem Aprovado com Distinção, se a média for igual a 10.");
            Console.WriteLine("");
            Console.WriteLine("Digite a primeira nota do aluno: ");
            string nota1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda nota do aluno: ");
            string nota2 = Console.ReadLine();
            Console.WriteLine("Digite a terceira nota do aluno: ");
            string nota3 = Console.ReadLine();
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;

            if (double.TryParse(nota1, out n1) && double.TryParse(nota2, out n2) && double.TryParse(nota3, out n3))
            {
                double mediaDeNotas = (n1 + n2 + n3) / 3;

                if (mediaDeNotas >= 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O aluno foi Aprovado! Média alcançada: {mediaDeNotas:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (mediaDeNotas < 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O aluno foi Reprovado! Media alcançada: {mediaDeNotas:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (mediaDeNotas == 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine($"O aluno foi Aprovado com Distinção! Média alcançada: {mediaDeNotas:f2}");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else
                {
                    Console.WriteLine("nota Inválida");

                }



            }

            EscolhaDeTela();

        }
        public static void Exercicio21()
        {
            Console.WriteLine("||---------------------- EXERCICIO 21 ----------------------------||");
            Console.WriteLine("Pergunta:. Faça um Programa para um caixa eletrônico ");
            Console.WriteLine("O programa deverá perguntar ao usuário a valor do saque e depois informar quantas notas de cada valor serão fornecidas");
            Console.WriteLine("As notas disponíveis serão as de 1,  10, 50 e 100 reais");
            Console.WriteLine("O valor mínimo é de 10 reais e o máximo de 600 reais");
            Console.WriteLine("O programa não deve se preocupar com a quantidade de notas existentes na máquina");
            Console.WriteLine("");
            Console.WriteLine("Qual o valor do saque ?");
            double caixaeletronico = 0;
            if (double.TryParse(Console.ReadLine(), out caixaeletronico))
            {
                double centena = 0;
                double dez = 0;
                double cinco = 0;
                double um = 0;

                centena = caixaeletronico / 100;
                dez = (caixaeletronico % 100) / 10;
                cinco = ((caixaeletronico % 100) % 5);
                um = (caixaeletronico % 100) % 10;
                if (caixaeletronico < 10)
                {
                    Console.WriteLine("Não coresponde ao valor minimo de R$ 10,00");
                    EscolhaDeTela();


                }
                else if (caixaeletronico > 600)
                {
                    Console.WriteLine("Não coresponde ao valor maximo que e de ate R$ 600,00");
                    EscolhaDeTela();
                }

                else
                {
                    Console.WriteLine($"A quantia a ser sacada e de R$: {caixaeletronico}");
                    Console.WriteLine($"Notas de Cem reais = {Math.Floor(centena)}, notas de dez reais =  {Math.Floor(dez)}, e notas de um real = {Math.Floor(um)}");

                }
            }

            EscolhaDeTela();
        }
        public static void Exercicio22()
        {
            Console.WriteLine("||---------------------- EXERCICIO 22 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um Programa que peça um número inteiro e determine se ele é par ou impar. Dica: utilize o operador módulo (resto da divisão) ");
            Console.WriteLine("");
            Console.WriteLine("Digite o numero inteiro: ");
            int imparoupar = 0;
            if (int.TryParse(Console.ReadLine(), out imparoupar))
            {
                int horaDaVerdade = imparoupar % 2;

                if (horaDaVerdade == 0)
                {
                    Console.WriteLine("Este número par");
                }
                else
                {
                    Console.WriteLine("Esse número e impar");

                }
                EscolhaDeTela();

            }

        }
        public static void Exercicio23()
        {
            Console.WriteLine("||---------------------- EXERCICIO 23 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um Programa que peça um número e informe se o número é inteiro ou decimal. Dica: utilize uma função de arredondamento ");
            Console.WriteLine("");
            Console.WriteLine("Digite o número: ");
            decimal verificadorNumeral = 0;
            if (decimal.TryParse(Console.ReadLine(), out verificadorNumeral))
            {

                if ((verificadorNumeral % 1) == 0)
                {
                    Console.WriteLine($"Este número e inteiro: {verificadorNumeral:F2}");
                }
                else
                {
                    Console.WriteLine($"Esse número e decimal: {verificadorNumeral:F2}");

                }

            }
            EscolhaDeTela();
        }
        public static void Exercicio24()
        {
            Console.WriteLine("||---------------------- EXERCICIO 24 ----------------------------||");
            Console.WriteLine("Pergunta: Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar ");
            Console.WriteLine("O resultado da operação deve ser acompanhado de uma frase que diga se o número é: ");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro Numero: ");
            string primeiraEntrada = Console.ReadLine();
            Console.WriteLine("Digite o segundo Numero: ");
            string segundaEntrada = Console.ReadLine();

            decimal px = 0;
            decimal sx = 0;

            if (decimal.TryParse(primeiraEntrada, out px) && decimal.TryParse(segundaEntrada, out sx))
            {
                Console.WriteLine("Qual dessas opções você deseja que o programa realize ?");
                Console.WriteLine("a. par ou ímpar; b.positivo ou negativo; c.inteiro ou decimal.");
                string escolha = Console.ReadLine();
                if (escolha.ToLower() == "a")
                {
                    decimal hd1 = px % 2;
                    decimal hd2 = sx % 2;

                    if ((hd1 == 0) && (hd2 == 1))
                    {
                        Console.WriteLine($"Número par {px} Número impar {sx}");
                    }
                    else if (hd1 == 1 && hd2 == 0)
                    {
                        Console.WriteLine($"Número par {sx} Número impar {px}");
                    }
                    else if (hd1 == 0 && hd2 == 0)
                    {
                        Console.WriteLine($"Os dois números são pares {px} e {sx}");
                    }
                    else
                    {
                        Console.WriteLine($"Os dois números são impares {px} e {sx} ");
                    }

                    EscolhaDeTela();
                }
                else if (escolha.ToLower() == "b")
                {
                    if (px >= 0 && sx >= 0)
                    {
                        Console.WriteLine($"Esses números são positivos: {px} e {sx}");
                    }
                    else if (px >= 0 && sx < 0)
                    {
                        Console.WriteLine($"Número positivo {px}, número negativo {sx}");
                    }
                    else if (sx >= 0 && px < 0)
                    {
                        Console.WriteLine($"Número positivo {sx}, número negativo {px}");
                    }
                    else
                    {
                        Console.WriteLine($"Esses números são negativos: {px} e {sx}");
                    }
                    
                     EscolhaDeTela();

                   

                }
                else if (escolha.ToLower() == "c")
                {
                    decimal esc1 = px % 1;
                    decimal esc2 = sx % 1;

                    if (esc1 == 0 && esc2 == 0)
                    {
                        Console.WriteLine($"Esses números sao inteiros: {px} e {sx}");
                    }

                    else if (esc1 != 0 && esc2 == 0)
                    {

                        Console.WriteLine($"Número decimal: {px}, número inteiro {sx}");
                    }

                    else if (esc2 != 0 && esc1 == 0)
                    {
                        Console.WriteLine($"Número decimal: {sx}, número inteiro {px}");
                    }

                    else
                    {
                        Console.WriteLine($"Os dois números são decimais: {px}, {sx}");

                    }
                    
                    EscolhaDeTela();

                  
                }
                else
                {
                    Console.WriteLine("Número invalido!!");
                    EscolhaDeTela();
                }

            }
             
            EscolhaDeTela();
        }
        public static void Exercicio25()
        {

            Console.WriteLine("||---------------------- EXERCICIO 25 ----------------------------||");
            Console.WriteLine("Pergunta:Faça um programa que faça 5 perguntas para uma pessoa sobre um crime ");
            Console.WriteLine(" ");
            Console.WriteLine("Telefonou para a vítima?");
            var telefonevitima = Console.ReadLine();
            Console.WriteLine("Esteve no local do crime?");
            var localcrime = Console.ReadLine();
            Console.WriteLine("Mora perto da vítima?");
            var moravitima = Console.ReadLine();
            Console.WriteLine("Devia para a vítima?");
            var dvitima = Console.ReadLine();
            Console.WriteLine("Já trabalhou com a vítima?");
            var trabalhouvitima = Console.ReadLine();
            var aglutinadorDeVariaveis = telefonevitima + localcrime + moravitima + dvitima + trabalhouvitima;
            var palavraChave = "sim";
            int count = 0;
            foreach (Match match in Regex.Matches(aglutinadorDeVariaveis, palavraChave, RegexOptions.IgnoreCase))
            {
                count++;
            }

            if (count == 2)
            {
                Console.WriteLine($"Suspeita ");
            }
            else if (count >= 3 && count <= 4)
            {
                Console.WriteLine($"Cúmplice");
            }
            else if (count == 5)
            {
                Console.WriteLine($"Assasino");

            }
            else
            {
                Console.WriteLine($"Inocente");

            }

            EscolhaDeTela();



        }
        public static void Exercicio26()
        {
            Console.WriteLine("Um posto está vendendo combustíveis com a seguinte tabela de descontos:");
            Console.WriteLine("-----------------");
            Console.WriteLine("a. Álcool:");
            Console.WriteLine("b. até 20 litros, desconto de 3% por litro");
            Console.WriteLine("c. acima de 20 litros, desconto de 5% por litro");
            Console.WriteLine("-----------------");
            Console.WriteLine("d. Gasolina:");
            Console.WriteLine("e. até 20 litros, desconto de 4% por litro");
            Console.WriteLine("f. acima de 20 litros, desconto de 6% por litro");
            Console.WriteLine("");
            Console.WriteLine("Gasolina ou Álcool, senhor ?");
            var escolhaGA = Console.ReadLine();
            if (escolhaGA.ToLower() == "gasolina")
            {
                Console.WriteLine("Quantos Litros você vai querer ?");
                double abastecimentoLitro = int.Parse(Console.ReadLine());
                if (abastecimentoLitro <= 20)
                {
                    double desconto = 0.10 * abastecimentoLitro;
                    double valorPago = abastecimentoLitro - desconto;
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"Valor pago R$: {valorPago:F2}, desconto R$ {desconto:F2}");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");

                }
                else
                {
                    double desconto = 0.15 * abastecimentoLitro;
                    double valorPago = abastecimentoLitro - desconto;
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"Valor pago R$:{valorPago:F2}, desconto R$:{desconto:F2}");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");


                }

            }
            else if (escolhaGA.ToLower() == "alcool")
            {


                Console.WriteLine("Quantos Litros você vai querer ?");
                double abastecimentoLitro = int.Parse(Console.ReadLine());
                if (abastecimentoLitro <= 20)
                {
                    double desconto = 0.057 * abastecimentoLitro;
                    double valorPago = abastecimentoLitro - desconto;
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"Valor pago R$: {valorPago:f2}, desconto R$:{desconto:f2}");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");

                }
                else
                {
                    double desconto = 0.095 * abastecimentoLitro;
                    double valorPago = abastecimentoLitro - desconto;
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"Valor pago R$:{valorPago:F2}, desconto R$:{desconto:F2}");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------");


                }
            }

            EscolhaDeTela();


        }
        public static void Exercicio27()
        {
            Console.WriteLine("||---------------------- EXERCICIO 27 ----------------------------||");
            Console.WriteLine("Pergunta: Uma fruteira está vendendo frutas com a seguinte tabela de preços: ");
            Console.WriteLine("-----------------Até 5 Kg ---------- Acima de 5 Kg");
            Console.WriteLine("Morango ----- R$ 2,50 por Kg ------ R$ 2,20 por Kg");
            Console.WriteLine("Maçã -------- R$ 1,80 por Kg ------ R$ 1,50 por Kg");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("O que vai querer frequesa ?");
            var EscolhaFruta = Console.ReadLine();
            if (EscolhaFruta.ToLower() == "morango")
            {
                Console.WriteLine("Quantos quilos vai querer ?");
                int quilos = int.Parse(Console.ReadLine());



                if (quilos <= 5)
                {
                    double ateCincoQuilos = 2.50 * quilos;
                    Console.WriteLine($"Valor a ser pago R${ateCincoQuilos}");

                }
                else if (quilos > 5)
                {
                    double maisQueCincoQuilos = 2.20 * quilos;

                    if ((quilos >= 8) && ((maisQueCincoQuilos >= 25)))
                    {
                        double porcentagem = maisQueCincoQuilos / 100;
                        Console.WriteLine($"Valor a ser pago R$:{maisQueCincoQuilos - porcentagem}");
                    }


                }



            }
            if (EscolhaFruta.ToLower() == "maça")
            {
                Console.WriteLine("Quantos quilos vai querer ?");
                int quilos = int.Parse(Console.ReadLine());

                double ateCincoQuilosMaça = 1.80 * quilos;
                double maisQueCincoQuilosMaça = 1.50 * quilos;
                double porcentagem = maisQueCincoQuilosMaça / 100;

                if (quilos <= 5)
                {
                    if (ateCincoQuilosMaça < 25)
                    {

                        Console.WriteLine($"Valor a ser pago R${ateCincoQuilosMaça}");
                    }
                    else
                    {
                        Console.WriteLine($"Valor a ser pago R$:{ateCincoQuilosMaça - porcentagem}");

                    }


                }
                else if (quilos > 5)
                {
                    if ((quilos >= 8) && ((maisQueCincoQuilosMaça >= 25)))
                    {
                        Console.WriteLine($"Valor a ser pago R$:{maisQueCincoQuilosMaça - porcentagem}");
                    }
                    else
                    {
                        Console.WriteLine($"Valor a ser pago R$:{maisQueCincoQuilosMaça }");

                    }


                }
            }

            EscolhaDeTela();
        }
        public static void Exercicio28()
        {
            Console.WriteLine("||---------------------- EXERCICIO 28 ----------------------------||");
            Console.WriteLine("Pergunta: O Hipermercado Tabajara está com uma promoção de carnes que é imperdível. Confira: ");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("             Até 5 Kg            Acima de 5 Kg");
            Console.WriteLine("File Duplo  R$ 4,90 por Kg       R$ 5,80 por Kg");
            Console.WriteLine("Alcatra     R$ 5,90 por Kg       R$ 6,80 por Kg");
            Console.WriteLine("Picanha     R$ 6,90 por Kg       R$ 7,80 por Kg");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Qual o tipo de carne você quer");
            var tipoDeCarne = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Quantos quilos da carne {tipoDeCarne}, você quer ?");
            int quiloCarne = int.Parse(Console.ReadLine());
            Console.WriteLine("Caixa: Dinheiro ou cartão senhor(a) ?");
            var escolha = Console.ReadLine();
            if (escolha.ToLower() == "cartao")
            {
                if (tipoDeCarne.ToLower() == "file duplo")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 4.90;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");


                    }
                    else
                    {
                        double precoCarne = quiloCarne * 5.80;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }


                }

                else if (tipoDeCarne.ToLower() == "alcatra")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 5.90;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    else
                    {
                        double precoCarne = quiloCarne * 6.80;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }

                }
                else if (tipoDeCarne.ToLower() == "picanha")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 6.90;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    else
                    {
                        double precoCarne = quiloCarne * 7.80;
                        double precoComDesconto = precoCarne * 0.05;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}. DESCONTO 5% . VALOR A PAGAR R$:{quiloCarne - precoComDesconto:F2}.");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }

                }

            }
            else if (escolha.ToLower() == "dinheiro")
            {

                if (tipoDeCarne.ToLower() == "file duplo")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 4.90;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");


                    }
                    else
                    {
                        double precoCarne = quiloCarne * 5.80;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }


                }

                else if (tipoDeCarne.ToLower() == "alcatra")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 5.90;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    else
                    {
                        double precoCarne = quiloCarne * 6.80;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }

                }
                else if (tipoDeCarne.ToLower() == "picanha")
                {
                    if (quiloCarne < 5)
                    {
                        double precoCarne = quiloCarne * 6.90;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}"); ;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    else
                    {
                        double precoCarne = quiloCarne * 7.80;
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             Hipermercado Tabajara           ");
                        Console.WriteLine("Endereço: Casa do caralho, 69, Bairro: Cu do mundo");
                        Console.WriteLine("");
                        Console.WriteLine("               CUPOM FISCAL                  ");
                        Console.WriteLine($"QTD {quiloCarne} KG.  VALOR TOTAL R$:{precoCarne:F2}. TIPO DE PAGAMENTO {escolha.ToUpper()}.VALOR A PAGAR R$:{precoCarne:F2}");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------");

                    }

                }

            }
            EscolhaDeTela();
        }


    }
}










/*public static void Exercicio3()
{
    Console.WriteLine("||---------------------- EXERCICIO 3 ----------------------------||");
    Console.WriteLine("Pergunta: ");
    EscolhaDeTela();
}*/