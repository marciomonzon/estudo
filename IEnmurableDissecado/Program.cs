using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnmurableDissecado
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1a10 = NumerosDe1A10().Onde(x => x < 3);

            foreach (var i in num1a10)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static IEnumerable<int> NumerosDe1A10()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
        }
    }

    public static class MeuLinq
    {
        public static IEnumerable<T> Onde<T>(this IEnumerable<T> lista, Func<T, bool> condicao)
        {
            foreach (var item in lista)
            {
                if (condicao(item))
                    yield return item;
                else
                    yield break;
            }
        }
    }
}
