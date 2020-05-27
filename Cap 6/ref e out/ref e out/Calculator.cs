using System;
using System.Collections.Generic;
using System.Text;

namespace ref_e_out
{
    class Calculator
    {
        //Ref - faz com que a variável da função referencie a variável da chamada do programa principal
        public static void TripleRef(ref int x)  // ref faz com que a variável x se torne um ponteiro para a variável passada no programa principal
        {
            x = x * 3;           
        }

        //Out - cria um parâmetro de saída que referencia a variável "out triple" da chamada da função
        public static void TripleOut(int origin, out int triple) //"int triple" agora é um ponteiro para a variável que foi passada na função principal
        {
            triple = origin * 3;
        }
    }
}
