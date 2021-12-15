using System;
using System.Globalization;

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

            //    Console.WriteLine("Digite tres numeros: ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = int.Parse(Console.ReadLine());


            //    double resultado = Maior(n1, n2, n3);

            //    Console.WriteLine("Maior = " + resultado);
            //}


            //static int Maior(int a, int b, int c)
            //{
            //    int m;
            //    if (a > b && a > c)
            //    {
            //        m = a;
            //    }
            //    else if (b > c)
            //    {
            //        m = b;

            //    } else
            //    {
            //        m = c;
            //    }
            //    return m;


            // ESTRUTURA DE REPETICAO 

            // SITAXY

            //while (  CONDICAO )
            //{
            //    COMANDO1
            //        COMANDO2
            //}



            //Console.Write("Type a number: ");
            //double x = double.Parse(Console.ReadLine());

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.Write(raiz.ToString("F3"));
            //    Console.Write("Type another number: ");
            //    x = double.Parse(Console.ReadLine());

            //    Console.Write("Negative number bye!");

            // EXERCICIO DE FIXACAO


            //Console.Write("Type your password: ");
            //int password = int.Parse(Console.ReadLine());

            //while ( password != 2002)
            //{
            //    Console.Write("Wrong password, try again!");

            //    password = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine("Welcome Jean Michael");



            // ESTRUTURA DE REPETICCAO (FOR)

            // SINTAX 

            //for ( INICIO, CONDICAO, INCREMENTO)
            //{
            //    COMANDO1
            //    COMANDO2
            //}


            Console.Write("Quantos numeros inteiros voce vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("Soma = " + soma);
        }

    }
}