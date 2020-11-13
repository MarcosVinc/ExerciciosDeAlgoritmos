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
            Console.WriteLine("Digite 0 para voltar a tela inicial: ");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc)) // verifica se e um numero
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
            Console.WriteLine("Digite as notas do aluno: ");
            string[] notas = Console.ReadLine().Split(' ');
            double nota1 = 0;
            double nota2 = 0;
            double somanotas = nota1 + nota2;
            double divisãonotas = somanotas / 2;
            if (double.TryParse(notas[0], out nota1) && double.TryParse(notas[1], out nota2))
            {
                if (somanotas >= 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Aprovado!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");

                }
                else if (somanotas < 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Reprovado!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }
                else if (divisãonotas == 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("|----------------------------------------|");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("O aluno foi Aprovado com Distinção!");
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|----------------------------------------|");
                }

            }
            else
            {
                Console.WriteLine("nota Inválida");
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
            double nun1 = 0;
            double nun2 = 0;
            double nun3 = 0;
            if (double.TryParse(numeros[0], out nun1) && double.TryParse(numeros[1], out nun2) && double.TryParse(numeros[2], out nun3))
            {
                

            }
            else
            {
                Console.WriteLine("numero Inválido");

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