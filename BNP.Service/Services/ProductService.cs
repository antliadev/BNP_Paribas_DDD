using BNP.Data.Repositories;
using BNP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNP.Service.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public IEnumerable<Product> FetchProduct()
        {
            return _productRepository.GetAllNoTracking();
        }

        public Product FetchGroupsById(int iIdProduct)
        {
            return _productRepository.Find(iIdProduct);
        }

        public bool UpdateGroups(int iIdProduct, Product group)
        {
            Product obj = _productRepository.Find(iIdProduct);

            if (obj == null)
                return false;

            obj.Description = group.Description;
            obj.Active = group.Active;

            _productRepository.Update(obj);
            return true;
        }

        public bool UpdateStatusGroups(int iIdProduct, bool status)
        {
            Product obj = _productRepository.Find(iIdProduct);

            if (obj == null)
                return false;

            obj.Active = !status;

            _productRepository.Update(obj);
            return true;
        }

        public bool DeleteGroups(int iIdProduct)
        {
            Product group = _productRepository.Find(iIdProduct);

            if (group == null)
                return false;

            _productRepository.Delete(group);
            return true;
        }
    }
}
