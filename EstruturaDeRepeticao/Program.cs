using System;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();
        }
        public static void TelaInicial()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("||                 ESTRUTURA DE REPETIÇÃO            ||");
            Console.WriteLine("|| 1 - Exercicio                                    1||");
            Console.WriteLine("|| 2 - Exercicio                                    2||");
            Console.WriteLine("|| 3 - Exercicio                                    3||");
            Console.WriteLine("|| 4 - Exercicio                                    4||");
            Console.WriteLine("|| 5 - Exercicio                                    5||");
            Console.WriteLine("|| 6 - Exercicio                                    6||");
            Console.WriteLine("|| 7 - Exercicio                                    7||");
            Console.WriteLine("|| 8 - Exercicio                                    8||");
            Console.WriteLine("|| 9 - Exercicio                                    9||");
            Console.WriteLine("|| 10 - Exercicio                                  10||");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("|| Segunda Pagina                                   0||");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("|| Escolher um exercicio especifico               100||");
            Console.WriteLine("--------------------------------------------------------");
            int escolhaTela = 0;
            if (int.TryParse(Console.ReadLine(), out escolhaTela))
            {
                switch (escolhaTela)
                {
                    case 100:
                        {
                            Console.Clear();
                            ExercicioEspecifico();
                            break;
                        }
                    case 1:

                        {
                            Console.Clear();
                            Exercicio01();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Exercicio02();
                            break;

                        }
                    case 3:
                        {
                            Console.Clear();
                            Exercicio03();
                            break;

                        }
                }


            }
            Console.WriteLine("Número inválido");
            Console.ReadLine();
            Console.Clear();
            TelaInicial();

        }
        public static void ExercicioEspecifico()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("------- TELA    DE     ESCOLHA ---------");
            Console.WriteLine("");
            Console.Write(" DIGITE O NUMERO DO EXERCICIO OU PRECIONE ZERO PARA VOLTAR A TELA INICIAL!  ");
            int exEspe = 0;
            if (int.TryParse(Console.ReadLine(), out exEspe))
            {
                switch (exEspe)
                {
                    case 0:
                        {
                            Console.Clear();
                            TelaInicial();
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Exercicio01();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Exercicio02();
                            break;

                        }
                    case 3:
                        {
                            Console.Clear();
                            Exercicio03();
                            break;

                        }
                }
            }
            Console.WriteLine("Número inválido");
            Console.ReadLine();
            Console.Clear();
            ExercicioEspecifico();


        }
        public static void Exercicio01()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("|Digite a nota de 0 a 10: |");
            double nota = 0;
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                while (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota invalida!");
                    Console.Write("Digite outra nota:");
                    nota = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("| ----------------------------------- |");
                Console.WriteLine("|    Nota cadastrada com sucesso!     |");
                Console.WriteLine("| ----------------------------------- |");

            }

            Console.WriteLine("");
            ExercicioEspecifico();
        }
        public static void Exercicio02()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Plano de vacinação   ");
            Console.Write("Usuario: ");
            var us = Console.ReadLine();
            Console.Write("Senha: ");
            var sen = Console.ReadLine();
            while (us == sen)
            {
                Console.WriteLine("Erro!");
                Console.WriteLine($"Senha igual ao o usuario, usuario {us} e senha {sen}");
                Console.WriteLine("");
                Console.WriteLine("Digite novamente:");
                Console.WriteLine("Usuario: ");
                us = Console.ReadLine();
                Console.WriteLine("Senha: ");
                sen = Console.ReadLine();

            }
            Console.WriteLine("| ----------------------------------------------- |");
            Console.WriteLine("|    usuario e senha cadastradas com sucesso!     |");
            Console.WriteLine("| ----------------------------------------------- |");
            Console.WriteLine(" ");
            ExercicioEspecifico();

        }
        public static void Exercicio03() 
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Faça um programa que leia e valide as seguintes informações ");
            Console.WriteLine("a. Nome: maior que 3 caracteres;");
            Console.WriteLine("b. Idade: entre 0 e 150;");
            Console.WriteLine("c. Salário: maior que zero;");
            Console.WriteLine("d. Sexo: 'f' ou 'm';");
            Console.WriteLine("Estado Civil: 's', 'c', 'v', 'd';");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            double idade = double.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Estado civil: ");
            char escivil = char.Parse(Console.ReadLine());

            while (idade <= 0 || idade > 150) 
            {
                Console.WriteLine("Idade invalida!");
                Console.Write("Digite novamente a idade: ");
                idade = double.Parse(Console.ReadLine());
            
            }
            while (salario > 0)
            {
                Console.WriteLine("Salário invalido!");
                Console.Write("Digite novamente o salário: ");
                salario = double.Parse(Console.ReadLine());

            }
            while (sexo != 'm' || sexo != 'M' || sexo != 'f' || sexo != 'F' )
            {
                Console.WriteLine("sexo invalido!");
                Console.Write("Digite novamente o sexo: ");
                sexo = char.Parse(Console.ReadLine());

            }
            while (escivil != 's' || escivil != 'S' || escivil != 'c' || escivil != 'C' || escivil != 'v' || escivil != 'V' || escivil != 'd' || escivil != 'D')
            {
                Console.WriteLine("Estado civil invalido!");
                Console.Write("Digite novamente o estado civil: ");
                escivil = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("| ---------------------------------------------------------------------------------- |");
            Console.WriteLine($"|                        informações cadastradas com sucesso!                       |");
            Console.WriteLine($"Nome: {nome}, Idade:{idade}, Salário: {salario}, Sexo:{sexo}, Estado civil: {escivil}");
            Console.WriteLine("| ---------------------------------------------------------------------------------- |");
            Console.WriteLine(" ");
            ExercicioEspecifico();




        }

        }
}
