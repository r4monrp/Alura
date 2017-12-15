using CasaDeCodigo.Models;
using System.Collections.Generic;

namespace CasaDeCodigo
{
    public interface IDataService
    {
        void InicializaDB();

        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}