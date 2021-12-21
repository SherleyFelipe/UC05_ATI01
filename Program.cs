using System;
using System.Collections.Generic;

namespace ATI1_Sherley_Lopes_Felipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedidos = new Pedido();
            char fim = 'S';

            do
            {

                Console.Clear();
                ItemPedido pedido = new ItemPedido();

                Console.WriteLine("Digite o produto");
                pedido.descricao = Console.ReadLine();

                Console.WriteLine("Digite a valor unitario ");
                pedido.valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade");
                pedido.quantidade = int.Parse(Console.ReadLine());

                pedidos.Inserir(pedido);

                Console.WriteLine("Quer adicionar novo PEDIDO? (S/N)");
                fim = Char.Parse(Console.ReadLine());

            } while (fim == 'S' || fim == 's');
            {

                //apresento o total do pedido

                Console.WriteLine("O total do pedido é {0} ", pedidos.TotalPedido());


            }

        }
    }
}
