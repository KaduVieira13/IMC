using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaM;
            double pesoKg;
            double resultado;

            Console.WriteLine("--- Cálculo de Índice de Massa Corporal ---");
            Console.Write("Digite sua altura..: ");
            alturaM = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.Write("Digite seu peso..: ");
            pesoKg = Convert.ToDouble(Console.ReadLine());
            resultado = pesoKg / Math.Pow(alturaM, 2);
            Console.Write($"O IMC é..: {resultado:N1} Kg/m²"); 
        }
    }
}
