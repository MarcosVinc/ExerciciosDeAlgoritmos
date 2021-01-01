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

                }


            }
            Console.WriteLine("Número inválido");
            Console.ReadLine();
            Console.Clear();
            TelaInicial();

        }
        public static void ExercicioEspecifico()
        {
            Console.WriteLine("Digite o número do exercicio");
            int exEspe = 0;
            if (int.TryParse(Console.ReadLine(), out exEspe))
            {
                switch (exEspe)
                {

                }
            }
            Console.WriteLine("Número inválido");
            Console.ReadLine();
            Console.Clear();
            ExercicioEspecifico();


        }
    }
}
