using EFWithRepo.Core;
using EFWithRepo.Model;
using EFWithRepo.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWithRepo.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly Context _context;
        public ProductRepo()
        {
            _context = new Context();
        }

        public Product GetById(int id)
        {
            var data = _context.Product.Find(id);
            return data;
            //_context.Product.Where(x => x.Id == id).FirstOrDefault();
            //var item = _context.Product.FirstOrDefault(x => x.Id == id);
        }


        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }



        public void Add(Product model)
        {
            _context.Product.Add(model);
            _context.SaveChanges();
            //_context.Set<Product>().Add(model);
        }

        public void Update(Product model)
        {
            var entity = GetById(model.Id);

            entity.Name = model.Name;
            entity.ManufacturedDate = model.ManufacturedDate;
            entity.BatchNo = model.BatchNo;
            entity.ExpireDate = model.ExpireDate;

            //_context.Entry(entity).State = EntityState.Detached;
            //_context.Product.Attach(model);
            //_context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            GetById(id);
            _context.Product.Remove(GetById(id));
            _context.SaveChanges();

        }
    }
}
