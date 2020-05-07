using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioClasse
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Altura * 2 + Largura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura*Altura + Largura*Largura);
        }

        public override string ToString()
        {
            return "ÁREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\r\nPERÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\r\nDIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
