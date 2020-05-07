using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioClasse3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;

        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
                return true;
            else
                return false;
        }

        public double NotaRestante()
        {
            if (Aprovado())
                return 0;
            else
                return (60.0 - NotaFinal())*-1;
        }
        public override string ToString()
        {
            if (Aprovado())
                return "NOTA FINAL = "
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\r\nAPROVADO";
            else 
                return "NOTA FINAL = "
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\r\nREPROVADO"
                    + "\r\nFALTARAM " 
                    + NotaRestante().ToString("F2", CultureInfo.InvariantCulture) 
                    + " PONTOS";

        }
    }

}
 
