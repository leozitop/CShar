using System;
    
namespace DesafioPizzaria
{
    public class Produto
    {
        static Produto[] arrayDeProdutos = new Produto[1000];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get ; set; }

        public Produto(string nome, string descricao, float preco, string categoria){
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Categoria = categoria;
            this.Id = contador +1;
            this.DataCriacao = DateTime.Now;
        }
        public static void CadastrarProduto(){
            string nome;
            string descricao;
            float preco;
            string categoria;

            System.Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();
            
            System.Console.WriteLine("Dê a descrição:");
            descricao = Console.ReadLine();

            System.Console.WriteLine("Digite o preço do produto");
            preco = float.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Qual a categotria? (Pizza ou bebida)");
            categoria = Console.ReadLine();

            Produto p = new Produto(nome, descricao, preco, categoria);

            arrayDeProdutos[contador] = p;

            contador++;
        }

        public static void ListarProduto() {
            foreach (var item in arrayDeProdutos) {
                if (item == null) {
                    break;
                }
                Console.WriteLine($"Id: {item.Id} Nome: {item.Nome} Preço: {item.Preco}");

            }
        }

        public static void BuscaPorId(){
            System.Console.WriteLine("Digite o ID do produto que busca");
            int idProduto = int.Parse(Console.ReadLine());
            foreach (var item in arrayDeProdutos) {
                if (item == null) {
                    System.Console.WriteLine("Produto não cadastrado");
                }if (idProduto.Equals(item.Id))
                {
                    System.Console.WriteLine($"ID: {item.Id}");
                    System.Console.WriteLine($"Nome: {item.Nome}");
                    System.Console.WriteLine($"Descrição: {item.Descricao}");
                    System.Console.WriteLine($"Preço: {item.Preco}");
                    System.Console.WriteLine($"Categoria: {item.Categoria}");
                    System.Console.WriteLine($"Data de criação: {item.DataCriacao}");
                    
                }
            }
        }


    }
}