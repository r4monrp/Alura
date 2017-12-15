using CasaDeCodigo.Models;
using CasaDeCodigo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeCodigo.Controllers
{
    public class PedidoController : Controller
    {


        public IActionResult Carrossel()
        {
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel carrinho = GetCarrinhoViewModel();

            return View(carrinho);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            return new CarrinhoViewModel(new List<ItemPedido>()
            {
                new ItemPedido(1, produtos[0],1),
                new ItemPedido(2, produtos[1],2),
                new ItemPedido(3, produtos[2],3)

            });
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel carrinho = GetCarrinhoViewModel();
            return View(carrinho);
        }
    }
}
