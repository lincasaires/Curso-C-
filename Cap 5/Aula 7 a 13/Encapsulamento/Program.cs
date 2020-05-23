using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 100.0, 10);

            //USANDO PROPERTIES
            p.Nome = "TV 4k"; //Alterando atributo Produto._nome através do propertie Nome criado na classe Produto
            Console.WriteLine(p.Nome); //Acessando atributo Produto._nome através do propertie Nome criado na classe Produto
            p.Preco = 100.00;
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            /*     //OS MÉTODOS SetNome() e GetNome() FORAM SUBSTITUÍDOS POR PROPERTIES NA CLASSE Produto
             p.SetNome(Console.ReadLine()); //Alterando atributo Produto._nome através do método SetNome(string nome) criado na classe Produto
             Console.WriteLine(p.GetNome()); //Acessando atributo Produto._nome através do método GetNome() criado na classe Produto
            */
        }
    }

}
