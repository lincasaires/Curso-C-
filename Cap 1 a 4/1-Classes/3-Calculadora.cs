using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Estática1
{
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * 3.14 * r;
        }
        public static double Volume(double r)
        {
            return 4.0/3.0*3.14 * r * r * r;
        }
    }
}
