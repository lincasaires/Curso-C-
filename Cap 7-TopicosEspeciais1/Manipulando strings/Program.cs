using System;

namespace Manipulando_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DefG   ";
           
            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: " + s1);

            s1 = original.ToLower();
            Console.WriteLine("ToLower: " + s1);

            s1 = original.Trim( ); // Apaga espaços entre os concatenados
            Console.WriteLine("Trim: -" + s1 + "-");

            int n1 = original.IndexOf("bc");
            Console.WriteLine("Index do 'bc': " + n1);

            n1 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndex do 'bc': " + n1);

            s1 = original.Substring(1, 8); // (startIndex , lengh)
            Console.WriteLine("Pedaço da string: " + s1);

            s1 = original.Replace('a' , 'Z'); // (old char , new char)
            Console.WriteLine("Replace 'a' for 'Z': " + s1);

            s1 = original.Replace("abc", "XYZ"); // (old char , new char)
            Console.WriteLine("Replace 'abc' for 'XYZ': " + s1);

            bool b1 = String.IsNullOrEmpty(original); //testa se a variável é vazia
            Console.WriteLine("IsNullOrEmpty: " + b1);

            b1 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace: " + b1);



        }
    }
}
