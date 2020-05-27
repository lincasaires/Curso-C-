using System;

namespace ref_e_out
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref
            int resultadoRef = 10;
            Calculator.TripleRef(ref resultadoRef); //ref faz com que a variável "resultadoRef" seja referência para o agora ponteiro "x" de "Calculator.TripleRef"
            Console.WriteLine(resultadoRef);

            //Out - Cria um parâmetro de saída
            int resultadoOut = 10;
            int triple;

            Calculator.TripleOut(resultadoOut, out triple); // out faz com que o resultado da função seja guardado no parâmetro de saída triple 
            Console.WriteLine(triple);
        }
    }
}
