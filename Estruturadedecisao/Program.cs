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
                case 10:
                    Console.Clear();
                    Exercicio10();
                    break;
            }

            Console.Clear();
            TelaInicial();
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
            Console.Clear();
            TelaInicial();
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
            Console.Clear();
            TelaInicial();
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
                if ((l1 == l2) && (l1 == l3) && (l2 == l1) && (l2 == l3) && (l3 == l1) && (l3 ==l2))
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
            Console.WriteLine("Pergunta: ");
            EscolhaDeTela();

        }
        public static void Exercicio17()
        {
            Console.WriteLine("||---------------------- EXERCICIO 17 ----------------------------||");
            Console.WriteLine("Pergunta: ");
            EscolhaDeTela();

        }
        public static void Exercicio18()
        {
            Console.WriteLine("||---------------------- EXERCICIO 18 ----------------------------||");
            Console.WriteLine("Pergunta: ");
            EscolhaDeTela();

        }
        public static void Exercicio19()
        {
            Console.WriteLine("||---------------------- EXERCICIO 19 ----------------------------||");
            Console.WriteLine("Pergunta: ");
            EscolhaDeTela();

        }
        public static void Exercicio20()
        {
            Console.WriteLine("||---------------------- EXERCICIO 20 ----------------------------||");
            Console.WriteLine("Pergunta: ");
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


