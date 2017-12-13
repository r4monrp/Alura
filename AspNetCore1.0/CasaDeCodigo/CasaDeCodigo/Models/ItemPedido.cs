﻿using System;
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

        public ItemPedido(int id, Produto produto,int quantidade)
        {
            this.Id = id;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitatio = produto.Preco;
        }
    }
}
