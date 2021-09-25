using System;

namespace SegundoGrau
{
    class Program
    {
        static void Main (string[] arg)
        {
            double a, b, c, delta, x1, x2, xv, yv;

            Console.WriteLine("Calculadora de Equação do Segundo Grau (JJoabeLima)");
            Console.WriteLine("Insira os coeficientes da Equação do Segundo Grau: ax² + bx + c = 0 ");

            Console.WriteLine("Insira o coeficiente a ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o coeficiente b ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a constante c ");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            xv = -b  / (2 * a);
            yv = -delta / (4 * a);

            if (delta < 0)
            {
                Console.WriteLine($"\n ({a})x² + ({b})x + ({c}) = 0");
                Console.WriteLine("\nO valor de delta é menor que zero, não existem soluções reais!!!");
                Console.WriteLine($"O valor de delta é: {delta}");
                Console.WriteLine($"Os extremos da equação são: xv = {xv} e yv = {yv}");
            }
            if (delta == 0)
            {
                x1 = (-b )/ (2 * a);
                Console.WriteLine($"\n ({a})x² + ({b})x + ({c}) = 0");
                Console.WriteLine($"\nO valor de delta é: {delta}");
                Console.WriteLine($"Existe uma solução real:\nx = {x1}");
                Console.WriteLine($"Os extremos da equação são: xv = {xv} e yv = {yv}");
            }
            if (delta > 0)
            {
                x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"\n ({a})x² + ({b})x + ({c}) = 0");
                Console.WriteLine($"\nO valor de delta é: {delta}");
                Console.WriteLine("Existem duas soluções reais:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                Console.WriteLine($"Os extremos da equação são: xv = {xv} e yv = {yv}");
            }

            Console.ReadKey();
         }

    }
}
