using System;
using System.Collections.Generic;

namespace ATI1_Sherley_Lopes_Felipe
{
    class Program
    {
        static void Main(string[] args)
        {
            string descricao;
            double valor_unitario, quantidade;
            char fim = 'S';

            do
            {

                Console.Clear();
                Console.WriteLine("Digite o produto");
                descricao = Console.ReadLine();

                Console.WriteLine("Digite a valor unitario ");
                valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade");
                quantidade = double.Parse(Console.ReadLine());


                Console.WriteLine("Quer adicionar novo PEDIDO? (S/N)");
                fim = Char.Parse(Console.ReadLine());       
            } while (fim == 'S');
            {

             //apresento o total do pedido

              Console.WriteLine("O total do pedido é "  );
            

            }

        }
    }
}
