using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace EstruturaSequencial

{
    class Program
    {
        public static void Main()
        {
            TelaInicial();
        }
        public static void TelaInicial()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Tela Inicial---------------------------------");
            Console.WriteLine("||-----------------------------------------------------------------------||");
            Console.WriteLine("||----------------------------Lista de Atividades------------------------||");
            Console.WriteLine("||--- 1* Atividade                                                tecle 1||");
            Console.WriteLine("||--- 2* Atividade                                                tecle 2||");
            Console.WriteLine("||--- 3* Atividade                                                tecle 3||");
            Console.WriteLine("||--- 4* Atividade                                                tecle 4||");
            Console.WriteLine("||--- 5* Atividade                                                tecle 5||");
            Console.WriteLine("||------------------------------------------------ Proxima pagina tecle 0||");
            Console.WriteLine("||----------------------------------------------------------------------||");
            var esc = int.Parse(Console.ReadLine());
            switch (esc)
            {

                case 1:
                    Atividade1();
                    break;
                case 2:
                    Atividade2();
                    break;
                case 3:
                    Atividade3();
                    break;
                case 4:
                    Atividade4();
                    break;
                case 5:
                    Atividade5();
                    break;
                case 0:
                    Console.Clear();
                    TelaInicial2();
                    break;

                default:
                    Console.WriteLine($"A atividade {esc} ainda não foi feita");
                    Console.Clear();
                    TelaInicial();
                    break;

            }
        }

            public static void TelaInicial2()
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------Tela Inicial---------------------------------");
                Console.WriteLine("||-----------------------------------------------------------------------||");
                Console.WriteLine("||----------------------------Lista de Atividades------------------------||");
                Console.WriteLine("||--- 6* Atividade                                                tecle 1||");
                Console.WriteLine("||--- 7* Atividade                                                tecle 2||");
                Console.WriteLine("||--- 8* Atividade                                                tecle 3||");
                Console.WriteLine("||--- 9* Atividade                                                tecle 4||");
                Console.WriteLine("||--- 10* Atividade                                               tecle 5||");
                Console.WriteLine("||--- 11* Atividade                                               tecle 6||");
                Console.WriteLine("||--- 12* Atividade                                               tecle 7||");
                Console.WriteLine("||------------------------------------------------ Proxima pagina tecle 0||");
                Console.WriteLine("||----------------------------------------------------------------------||");
                var esc = int.Parse(Console.ReadLine());
                switch (esc)
                {

                    case 1:
                        Atividade6();
                        break;
                    case 2:
                        Atividade7();
                        break;
                    case 3:
                        Atividade8();
                        break;
                    case 4:
                        Atividade9();
                        break;
                    case 5:
                        Atividade10();
                        break;
                    case 6:
                        Atividade11();
                        break;
                    case 7:
                        Atividade12();
                        break;
                    case 0:
                        Console.Clear();
                        TelaInicial3();
                        break;

                    default:
                        Console.WriteLine($"A atividade {esc} ainda não foi feita");
                        Console.Clear();
                        TelaInicial();
                        break;

                }
            }
            public static void TelaInicial3()
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("--------------Tecle 0 para voltar para a Tela Principal-------------------");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("||----------------------------Lista de Atividades------------------------||");
                Console.WriteLine("||--- 13* Atividade                                                tecle 1||");
                Console.WriteLine("||--- 14* Atividade                                                tecle 2||");
                Console.WriteLine("||--- 15* Atividade                                                tecle 3||");
                Console.WriteLine("||--- 16* Atividade                                                tecle 4||");
                Console.WriteLine("||--- 17* Atividade                                                tecle 5||");
                Console.WriteLine("||--- 18* Atividade                                                tecle 6||");
                Console.WriteLine("||------------------------------------------------ Primeira pagina tecle 0||");
                Console.WriteLine("--------------------------------------------------------------------------");
                int esc = int.Parse(Console.ReadLine());
                switch (esc)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                    case 1:
                        Atividade13();
                        break;
                    case 2:
                        Atividade14();
                        break;
                    case 3:
                        Atividade15();
                        break;
                    case 4:
                        Atividade16();
                        break;
                    case 5:
                        Atividade17();
                        break;
                    case 6:
                        Atividade18();
                        break;

                    default:
                        Console.WriteLine($"A atividade {esc} ainda não foi feita");
                        Console.Clear();
                        TelaInicial();
                        break;

                }
            }
        public static void Atividade1()
        {
            Console.WriteLine("----- Atividade numero 1 -----");
            Console.WriteLine("Alo Mundo!");
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------------------Tecle 0");
            double vol = double.Parse(Console.ReadLine());
            switch (vol)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }
        public static void Atividade2()
        {
            Console.WriteLine("----- Atividade numero 2 -----");
            Console.WriteLine("Digite um numero e 1 a 10");
             string numero = Console.ReadLine();
            Console.WriteLine($"O numero que voce digitou foi:{numero}");;
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------------------Tecle 0");
            double vol = double.Parse(Console.ReadLine());
            switch (vol)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }
        public static void Atividade3()
        {
            Console.WriteLine("----- Atividade numero 3 -----");
             Console.WriteLine("Digite um numero:");
             int x = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite outro numero:");
             int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os valores somados dos dois são {x + y}");;
            Console.WriteLine("-----------------------Tecle 0");
            double vol = double.Parse(Console.ReadLine());
            switch (vol)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }
        public static void Atividade4()
        {
            Console.WriteLine("----- Atividade numero 4 -----");
            Console.WriteLine("Calculo de Notas");
            Console.WriteLine("Digite a primeira nota:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota:");
            int n4 = int.Parse(Console.ReadLine());
            int med = (n1 + n2 + n3 + n4) / 4;
            string para = "PARABÉNS VOCÊ PASSOU!";
            string ret = "VOCÊ NÃO ALCANÇOU A NOTA NESSESARIA PARRA AVANÇAR DE ANO LETIVO";
            if (med > 5)
            {
                Console.WriteLine($"Sua media foi {med:f3}: {para}");
            }
            else
            {
                Console.WriteLine($"Sua media foi {med:f3}: {ret}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------------------Tecle 0");
            double vol = double.Parse(Console.ReadLine());
            switch (vol)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }
        public static void Atividade5()
        {
            Console.WriteLine("----- Atividade numero 5 -----");
            Console.WriteLine("Conversor de METROS para Centimetros");
            Console.WriteLine("Digite o metro desejado");
            int met = int.Parse(Console.ReadLine());
            int conv = met * 100;
            Console.WriteLine($"A conversão do {met} para centimetros foi de {conv} cm!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----------------------Tecle 0");
            double vol = double.Parse(Console.ReadLine());
            switch (vol)
            {
                case 0:
                    Console.Clear();
                    TelaInicial();
                    break;
            }
        }
        public static void TelaIniciaDo13M()
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("---------------Tecle 0 para voltar para O exercicio 13 --------------------");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("||----------------------------IMC MASCULINO -----------------------------||");
                Console.WriteLine("||Digite sua Altura:                                                     ||");
                double alt = double.Parse(Console.ReadLine());
                double peso = (72.7 * alt) - 58;
                Console.WriteLine($"||Seu peso ideal: {peso:f1}                                             ||");
                Console.WriteLine("--------------------------------------------------------------------------");
                int esc = int.Parse(Console.ReadLine());
                switch (esc)
                {
                    case 0:
                        Console.Clear();
                        Atividade13();
                        break;
                }

            }
            public static void TelaIniciaDo13F()
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("---------------Tecle 0 para voltar para O exercicio 13 --------------------");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("||----------------------------IMC FEMININO -----------------------------||");
                Console.WriteLine("||Digite sua Altura:                                                     ||");
                double alt = double.Parse(Console.ReadLine());
                double peso = (62.1 * alt) - 44.7;
                Console.WriteLine($"||Seu peso ideal: {peso:f1}                                             ||");
                Console.WriteLine("--------------------------------------------------------------------------");
                int esc = int.Parse(Console.ReadLine());
                switch (esc)
                {
                    case 0:
                        Console.Clear();
                        Atividade13();
                        break;
                }
            }

            public static void Atividade6()
            {
                Console.WriteLine("----- Atividade numero 6 -----");
                Console.WriteLine("Digite o raio do circulo");
                double raio = double.Parse(Console.ReadLine());
                double area = ((3.1415 * (raio * 2)));
                Console.WriteLine($"A área do circulo e:{area:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
            public static void Atividade7()
            {
                Console.WriteLine("----- Atividade numero 7 -----");
                Console.WriteLine("Digite a altura do quadrado");
                double al = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o comprimento do quadrado");
                double comp = double.Parse(Console.ReadLine());
                double area = al * comp;
                Console.WriteLine($"A área do quadrado e:{area * 2:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
            public static void Atividade8()
            {
                Console.WriteLine("----- Atividade numero 8 -----");
                Console.WriteLine("Quando voce ganha por hora: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de horas trabalhadas no mes: ");
                double horas = double.Parse(Console.ReadLine());
                double salario = (valor * horas);
                Console.WriteLine($"Calculo total do seu salario referido mês: {salario}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }

            }
            public static void Atividade9()
            {
                Console.WriteLine("----- Atividade numero 9 -----");
                Console.WriteLine("Transfome a temperatura em Graus Fahrenheit para Celsius");
                Console.WriteLine("");
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());
                double tf = ((f - 32) / 1.8);
                Console.WriteLine($"A temperatura em Fahrenheit: {tf:f1}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }



            }
            public static void Atividade10()
            {
                Console.WriteLine("----- Atividade numero 10 -----");
                Console.WriteLine("Transfome a temperatura em Graus Celsius para Fahrenheit");
                Console.WriteLine("");
                Console.WriteLine("Digite a temperatura em Celsius: ");
                double c = double.Parse(Console.ReadLine());
                double tc = ((c * 1.8) + 32);
                Console.WriteLine($"A temperatura em Fahrenheit: {tc:f1}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }


            }
            public static void Atividade11()
            {
                Console.WriteLine("----- Atividade numero 11 -----");
                Console.WriteLine("Numeros Inteiros: Z = ...-3 -2 -1 0 1 2 3...");
                Console.WriteLine("Numeros Reais: Englobam todos os conjuntos");
                Console.WriteLine("Digite o primeiro numero inteiro: ");
                int p1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero inteiro: ");
                int p2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero real: ");
                int r1 = int.Parse(Console.ReadLine());
                int a1 = (((p1 + p2) * 2));
                int a2 = (r1 / 2);
                int a3 = a1 + a2;
                Console.WriteLine($"A. O produto do dobro do primeiro com metade do segund {a3:f2}");
                int b1 = ((p1 + p2) * 3);
                int b2 = b1 + r1;
                Console.WriteLine($"A soma do triplo do primeiro com o terceiro {b2:f2}");
                double cb1 = Math.Sqrt(r1);
                Console.WriteLine($"O terceiro elevado ao cubo {cb1:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }

            }
            public static void Atividade12()
            {
                Console.WriteLine("----- Atividade numero 12 -----");
                Console.WriteLine("Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7 * altur) - 58");
                Console.WriteLine("Digite sua altura: ");
                double alt = double.Parse(Console.ReadLine());
                double peso = ((72.7 * alt) - 58);
                Console.WriteLine($"Seu peso ideal: {peso:f1}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }

            }
            public static void Atividade13()
            {
                Console.WriteLine("----- Atividade numero 13 -----");
                Console.WriteLine("Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando asseguintes fórmulas: ");
                Console.WriteLine("Escolha seu genero");
                Console.WriteLine("Masculino = 1  Feminino = 2");
                int genero = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                switch (genero)
                {
                    case 1:
                        Console.Clear();
                        TelaIniciaDo13M();
                        break;
                    case 2:
                        Console.Clear();
                        TelaIniciaDo13F();
                        break;
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;

                }

            }

            public static void Atividade14()
            {
                double rp = 50;
                Console.WriteLine("----- Atividade numero 14 -----");
                Console.WriteLine("Digite o peso de peixes pescados hoje: ");
                double pp = double.Parse(Console.ReadLine());
                double ex = pp - rp;
                double multa = ex * 4;
                Console.WriteLine($"O peso que voce pescou foi {pp}");
                Console.WriteLine($"De acordo com o estado de SÃO PAULO voce passou o limite em quilos: {ex}");
                Console.WriteLine($"A multa que voce deve pagar: {multa:f2} reais");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;

                }
            }
            public static void Atividade15()
            {
                Console.WriteLine("----- Atividade numero 15 -----");
                Console.WriteLine("Quando voce ganha por hora: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Numero de horas trabalhadas no mes: ");
                double horas = double.Parse(Console.ReadLine());
                double salario = (valor * horas);
                Console.WriteLine($"Calculo salario bruto referido mês: {salario:f2}");
                double ir = ((salario * 11) / 100);
                Console.WriteLine($" Valor descontado de Imposto de renda {ir:f2}");
                double inss = ((salario * 8) / 100);
                Console.WriteLine($" Valor descontado de INSS {inss:f2}");
                double sind = ((salario * 5) / 100);
                Console.WriteLine($" Valor descontado de Sindicato {sind:f2}");
                double salarioLiquido = salario - ir - inss - sind;
                Console.WriteLine($"Salario Liquido: {salarioLiquido:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
            public static void Atividade16()
            {
                Console.WriteLine("----- Atividade numero 16 -----");
                Console.WriteLine("Qual e a altura da parede: ");
                double alt = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual e o comprimento da parede: ");
                double comp = double.Parse(Console.ReadLine());
                double area = alt * comp;
                double tintamet = ((area * 1) / 3);
                double latas = tintamet / 18;
                double valorlat = latas * 80.00;
                Console.WriteLine($"A quantidade de latas que voce tera que comprar e: {latas:f0} latas, e o valor gasto sera R$:{valorlat:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
            public static void Atividade17()
            {
                Console.WriteLine("----- Atividade numero 17 -----");
                Console.WriteLine("Qual e a altura da parede: ");
                double alt = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual e o comprimento da parede: ");
                double comp = double.Parse(Console.ReadLine());
                double area = alt * comp;
                double tintamet = ((area * 1) / 6);
                double latasNor = tintamet / 18;
                double latas39 = tintamet / 3.6;
                double valorlat = latasNor * 80.00;
                double valorlat3 = latas39 * 25.00;
                Console.WriteLine($"A quantidade de latas 18 litros que voce tera que comprar e: {latasNor:f0} latas, e o valor gasto sera R$:{valorlat:f2}");
                Console.WriteLine($"A quantidade de latas 3,6 litros que voce tera que comprar e: {latas39:f0} latas, e o valor gasto sera R$:{valorlat3:f2}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
            public static void Atividade18()
            {
                Console.WriteLine("----- Atividade numero 18 -----");
                Console.WriteLine("Qual e o tamanho do arquivo para dowload em MB: ");
                double dw = double.Parse(Console.ReadLine());
                Console.WriteLine("Sua velocidade de internet em Mbps:");
                double mps = double.Parse(Console.ReadLine());
                double conv = ((dw / 1) * 75);
                Console.WriteLine($"Tempo aproximado de download por minutos: {conv / 60:f0}");

                Console.WriteLine("------------------------------");
                Console.WriteLine("-----------------------Tecle 0");
                double vol = double.Parse(Console.ReadLine());
                switch (vol)
                {
                    case 0:
                        Console.Clear();
                        TelaInicial();
                        break;
                }
            }
        }
    }

