using EFWithRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWithRepo.Repo.Interface
{
    public interface IProductRepo
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Add(Product model);
        void Update(Product model);
        void Delete(int id);
    }
}
