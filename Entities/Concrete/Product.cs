using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCurrency { get; set; }
    }
}
