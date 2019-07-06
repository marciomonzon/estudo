using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCodigoEmExecuxao
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(int);
            Func<int, int, int> soma = Soma; // delegate

            var dynamicMethod = new DynamicMethod("SomaCriadoEmExecucao", type, new[] { type, type });
            var ilGenerator = dynamicMethod.GetILGenerator();

            //ilGenerator.Emit(OpCode,Ldarg_0);
            //ilGenerator.Emit();
            //ilGenerator.Emit();
            //ilGenerator.Emit();
        }

        static int Soma(int valorA, int valorB)
        {
            return valorA + valorB;
        }
    }
}
