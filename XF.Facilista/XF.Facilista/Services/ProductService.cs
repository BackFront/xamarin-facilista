using System;
using System.Collections.Generic;
using System.Text;
using XF.Facilista.Entities;
using XF.Facilista.Repositories;

namespace XF.Facilista.Services
{  
    public class ProductService
    {
        protected ProductSQLiteRepository _productsRepository = new Repositories.ProductSQLiteRepository();

        public List<Product> Listar() => _productsRepository.GetList();
    }
}
