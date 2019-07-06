using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.dynamicsvar
{
    class Program
    {
        // var is statically typed
        // dynamic is late bounded or checked on runtime

        static void Main(string[] args)
        {
            var x1 = "string"; // earlu bounded
            int len = x1.Length;

            dynamic y = "string1"; // late bounded
            int len1 = y.Length;
        }
    }
}
