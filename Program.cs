using System;

namespace Aula24ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "Red dead", 299.99f);
            Produto p2 = new Produto(2, "Call of Duty", 25.40f);
            Produto p3 = new Produto(2, "Dead Cells", 23.80f);
            Produto p4 = new Produto(1, "Detroit Become Human", 99.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p2);
            
            // Produto produtoAlterado = new Produto(3, "Celeste", 230.46f);
            // cart.Alterar(3, produtoAlterado);

            cart.Ler();
            cart.MostrarTotal();

        }
    }
}
