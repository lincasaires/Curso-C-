/*
  ORDEM SUGERIDA PARA A IMPLEMENTAÇÃO DOS MEMBROS DA CLASSE:
  .Atributos privados
  .Propriedades autoimplementadas
  .Construtores
  .Propriedades customizadas
  .Outros métodos da classe
*/


using System;
using System.Globalization;
namespace Course
{
    class Produto
    {
        //Trocando "public" por "private" torna esses atributos inacessíveis para outros arquivos.
        private string _nome; //_nomenclatura convencional _atributo
        private double _preco;
        public int Quantidade { get;  private set; } //Auto Propertie (caso não precise de tratamento dos dados)

        public Produto(string nome, double preco, int quantidade) //Construtor
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;

        }

        //DEFININDO PROPERTIES PARA SUBSTITUIR OS MÉTODOS GetNome() E SetNome() ABAIXO
        public string Nome //Propertie Customizada criada para conseguir acessar _nome em outro arquivo (com tratamento de dados)
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //O parâmetro "nome" que se encontrava no método SetNome() abaixo foi substituido por "value"
                    _nome = value;
                else
                    Console.WriteLine("Nome Inválido");
            }
        }

        // OS MÉTODOS GetNome() E SetNome() FORAM SUBSTITUIDOS PELAS PROPERTIES ACIMA
        /*
          public string GetNome() //Método criado para conseguir acessar _nome em outro arquivo
        {
            return _nome;
        }
        public void SetNome(string nome) //Método criado para conseguir alterar _nome em outro arquivo
        {
            if (nome != null && nome.Length > 1) //Vatagem: possibilidade de tratar dados
                _nome = nome;
            else
                Console.WriteLine("Nome Inválido");
        }
        */

        //DEFININDO PROPERTIES PARA ACESSAR _preco
        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                    _preco = value;
            }
        }

       
        public double ValorTotalEmEstoque() { return _preco * Quantidade; }
        public void AdicionarProdutos(int _quantidade) { _quantidade += _quantidade; }
        public void RemoverProdutos(int _quantidade) { _quantidade -= _quantidade; }
        public override string ToString()
        {
            return _nome + ", $ "
+ _preco.ToString("F2", CultureInfo.InvariantCulture)
+ ", " + Quantidade
+ " unidades, Total: $ "
+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
