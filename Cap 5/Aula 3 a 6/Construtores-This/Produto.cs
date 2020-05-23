using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
       /* public Produto(string nome, double preco, int quantidade) //Construtor1
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }*/

        public Produto(string nome, double preco) //Construtor2: sem quantidade
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public Produto(string Nome) //Construtor3: utilizamos "this" para diferenciar o parâmetro Nome da variável Nome
        {
            this.Nome = Nome;
            Preco = 0;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade): this(nome, preco) { //Construtor4: reaproveitando os dados do construtor 2
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() { return Preco * Quantidade; }
        public void AdicionarProdutos(int quantidade) { Quantidade += quantidade; }
        public void RemoverProdutos(int quantidade) { Quantidade -= quantidade; }
        public override string ToString() { return Nome 
                   + ", $ " 
                   + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                   + ", " + Quantidade + " unidades, Total: $ " 
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }
    }
}
