using System;
using System.Collections.Generic; // Necessário para trabalhar com listas

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            List<string> lista1 = new List<string> { "João", "Maria" };

            // Adicionando elemento na lista com Add. Por padrão, o Add adiciona no final da lista
            lista.Add("Lucas");
            lista.Add("Joao");
            lista.Add("Leandro");
            lista.Add("Rosa");
            lista.Add("Indim");
            lista.Add("Matheus");
            lista.Add("Joaquim");
            lista.Add("Strogonoff");

            // Adicionando elemento na lista com Insert. Serve para adicionar um elemento na posção especificada
            lista.Insert(1, "Maria"); // (posição, valor)

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + lista.Count); // Usando .Count para verificar o tamanho da lista

            // Usando .Find para pesquisar a primeira ocorrência na lista. Find(função bool ou expressão lambda)
            string s1 = lista.Find(Test); // Find utilizando a função Test
            Console.WriteLine("Resultado do Find utilizando função bool: " + s1);

            s1 = lista.Find(x => x[0] == 'J'); // Find utilizando expressão lambda. "Quero o objeto x tal que x na posição 0 seja igual a 'J'"
            Console.WriteLine("Resultado do Find utilizando expressão lambda: " + s1);

            // Usando .FindLast para pesquisar a ultima ocorrência de x na lista. FindLast(função bool ou expressão lambda)
            s1 = lista.FindLast(x => x[0] == 'J');
            Console.WriteLine("Resultado do FindLast utilizando expressão lambda: " + s1);
            Console.WriteLine();

            // Usando .FindIndex para pesquisar a posição do primeiro elemento que começa com 'J'
            int posicao = lista.FindIndex(x => x[0] == 'J');
            Console.WriteLine("Posição do primeiro elemento que começa com J = " + posicao);

            // Usando .FindLastIndex para pesquisar a posição do ultimo elemento que começa com 'J'
            posicao = lista.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("Posição do ultimo elemento que começa com J = " + posicao);
            Console.WriteLine();

            // Usando .FindAll para filtrar na lista todos os elementos que começam com 'J'
            List<string> lista2 = lista.FindAll(x => x[0] == 'J');
            Console.WriteLine("Todos os elementos que começam com J:");
            foreach(string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Usando .Remove para remover o elemento "Lucas" da lista. Remove("Elemento")
            lista.Remove("Lucas");
            Console.WriteLine("Removendo 'Lucas' da lista: ");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine( );

            // Usando .RemoveAll para remover todo mundo que começa com a letra 'J'
            lista.RemoveAll(x => x[0] == 'J');
            Console.WriteLine("Removendo todos que começam com 'J' da lista ");
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            // .RemoveAt para remover o elemento da posição informada
            lista.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("Removendo elemento da posição 1");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // .RemoveRange para remover os elementos em um range especificado
            lista.RemoveRange(0, 2); // .RemoveRange(posicao , contagem)

            Console.WriteLine("Removendo 2 elementos a partir da posição 0");
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
        static bool Test(string x)
        {
            return x[0] == 'J';
        }

    }
}
