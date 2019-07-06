using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnmurableDissecado
{
    public class MaquinaEstado : IEnumerator<int>, IEnumerator
    {
        private int estado;

        public MaquinaEstado()
        {
            estado = 0;
        }

        public int Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public bool MoveNext()
        //{
        //    switch (estado)
        //    {
        //        case 0: Current = 1; estado = 1; return true;
        //        default:
        //            break;
        //    }
        //}

        public void Reset()
        {
            throw new NotSupportedException("Cire uma nova instância");
        }
    }
}
