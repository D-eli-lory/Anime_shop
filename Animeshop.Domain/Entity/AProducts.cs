using Animeshop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animeshop.Domain.Entity
{
    public class AProducts
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreat { get; set; }

        public TypeAProducts TypeAProducts { get; set; }

    }
}
