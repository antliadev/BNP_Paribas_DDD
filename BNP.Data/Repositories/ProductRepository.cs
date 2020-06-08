using BNP.Data.DataContext;
using BNP.Data.Repository;
using BNP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNP.Data.Repositories
{
    public  class ProductRepository : Repository<Product>
    {
        public ProductRepository(BNPDataContext context) : base(context) { }
    }
}
