using System;

namespace Exercicio.Tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe km");
            string distanciaStr = Console.ReadLine();
            Console.WriteLine("Informe o Gasto");
            string gastoStr = Console.ReadLine();
            decimal distancia = 0.0m;
            decimal gasto = 0.0m;
            decimal media = 0.0m;

            decimal.TryParse(distanciaStr, out distancia);
            decimal.TryParse(gastoStr, out gasto);
            media = distancia / gasto;

            Console.WriteLine($"Seu veiculo fez de {media}KM por litro");
        }
    }
}
