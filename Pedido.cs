using System;
using System.Collections.Generic;

namespace ATI1_Sherley_Lopes_Felipe
{


    public class Pedido
    {

        private List<ItemPedido> pedidos = new List<ItemPedido>();
        

        public void Inserir(ItemPedido pedido)
        {
            pedidos.Add(pedido);
        }

        public double TotalPedido()
        {

            double total = 0;

            for (int i=0; i < pedidos.Count; i++)
            {
            
                total = total + pedidos[i].valor_unitario * pedidos[i].quantidade;
            }
            return total;
        }
   }
}