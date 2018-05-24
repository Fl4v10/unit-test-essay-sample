 using System;

namespace xUnitTestEssaySample
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int parcela1 = Int32.Parse(Console.ReadLine());
                int parcela2 = Int32.Parse(Console.ReadLine());
                int total = Soma(parcela1, parcela2);

                Console.WriteLine("Resultado: " + total.ToString());
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        private static void RetornarExcecao()
        {
            throw new NotImplementedException();
        }

        private static int Soma(int parcela1, int parcela2)
        {
            int resultado = parcela1 + parcela2;
            return resultado;
        }

    }
}
