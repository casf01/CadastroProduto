using System;

namespace Livraria.Models.Domain
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataVenda { get; set; }
    }
}