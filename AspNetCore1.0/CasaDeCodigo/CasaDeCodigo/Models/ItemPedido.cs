using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeCodigo.Models
{
    public class ItemPedido
    {
        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitatio { get; private set; }
        public decimal SubTotal { get { return Quantidade * PrecoUnitatio; } }

        public ItemPedido()
        {
                
        }

        public ItemPedido(int id, Produto produto,int quantidade) : this(produto,quantidade)
        {
            this.Id = id;

        }

        public ItemPedido(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitatio = produto.Preco;
        }
    }
}
