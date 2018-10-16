using System;

namespace Fernanda_Alves_31828917
{
    class Program
    {
        private const int A = 1;

        public static void Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
                return b;
        }

        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static bool Resto(int c)
        {
            if (c % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {

            //questão 01

         {
                Console.Write("QUESTÃO NÚMERO 1:");
                Console.WriteLine(Maior(A, 2));
                Console.WriteLine(Maior2(5, 2));

                Console.Write("\n\n\n\n\nDigite uma tecla para ir para a questão 02");
                Console.ReadKey();
                Console.Clear();

                //questão 02 - eu me esqueci totalmente de como se cria classe

                Console.Write("QUESTÃO NÚMERO 2:");

                class imc();




                if (imc == 16)
                {
                    Console.Write("\n\nMagreza Grave");
                }

                else if (imc >= 16 | imc >17)
                {
                    Console.Write("\n\nMagreza Moderada");
                }

                else if (imc >=17 | imc > 18.5)
                 {
                    Console.WriteLine("\n\nMagreza Leve");
                }

                else if (imc >= 18.5 | imc < 25)
                {
                    Console.WriteLine("\n\nSaudável");
                }

                else if (imc >= 25 | imc < 30)
                {
                    Console.WriteLine("\n\nSobrepeso");
                }

                else if (imc >= 30 | imc < 35)
                {
                    Console.WriteLine("\n\nObesidade Grau I");
                }

                else if (imc >= 35 | imc < 40)
                {
                    Console.WriteLine("\n\nObesidade Grau II");
                }

                else if (imc >= 35 | imc < 40)
                {
                    Console.WriteLine("\n\nObesidade Grau II (Severa)");
                }





                Console.Write("\n\n\n\n\nDigite uma tecla para ir para a questão 03");
                Console.ReadKey();
                Console.Clear();
            }

        //questão 03

        int numq3;
            Console.Write("QUESTÃO NÚMERO 3:");



            Console.WriteLine(Resto(2));

            Console.Write("\n\n\n\n\nDigite uma tecla para ir para a questão 04");
            Console.ReadKey();
            Console.Clear();



            //QUESTÃO 04

            Console.Write("QUESTÃO NÚMERO 4:");

                double x;

                x = Math.Abs(7.5);

                Console.Write("\na) " + x);

                x = Math.Floor(7.5);

                Console.Write("\nb) " + x);

                x = Math.Abs(0.0);

                Console.Write("\nc) " + x);

                x = Math.Ceiling(0.0);

                Console.Write("\nd) " + x);

                x = Math.Abs(-6.4);

                Console.Write("\ne) " + x);

                x = Math.Ceiling(-6.4);

                Console.Write("\nf) " + x);

                x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));

                Console.Write("\ng) " + x);

                Console.ReadKey();





            }
    }
}
