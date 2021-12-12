using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            // EXERCICIO IF-ELSE

            //int numero1 = int.Parse(Console.ReadLine());
            //int numero2 = int.Parse(Console.ReadLine());

            //if (numero1 >= numero2)
            //{
            //    Console.WriteLine("O " + numero1 + " e maior que o " + numero2);
            //}
            //else (numero2 >= numero1)
            //{
            //    Console.WriteLine("O " + numero2 + " e maior que o " + numero1);



            // SINTAXE DE FUNCOES

            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }


        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;

            } else
            {
                m = c;
            }
            return m;
        }

    }
}