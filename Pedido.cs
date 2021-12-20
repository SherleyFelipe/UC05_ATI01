using System;
using System.Collections.Generic;

namespace ATI1_Sherley_Lopes_Felipe
{


    public class Pedido
    {

        public static List<ItemPedido> pedidos;


        static Pedido()
        {
            pedidos = new List<ItemPedido>();
        }

        public void Inserir(ItemPedido pedido)
        {

            pedidos.Add(pedido);

        }

        public List<ItemPedido> Listar()
        {
            return pedidos;
        }


        public double TotalPedido()
        {

            double total = 0;

            foreach (ItemPedido p in pedidos)
            {
            
                total = total + (p.valor_unitario * p.quantidade);
            }
            return total;
        }
   }
}