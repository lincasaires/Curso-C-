using Exercicio_Composicao.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            post = new Post(DateTime.Now,
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            post.AddComment(c1);
            post.AddComment(c2);

            Console.WriteLine(post);
            
            
            
        }
    }
}
