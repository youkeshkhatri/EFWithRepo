using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWithRepo.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string BatchNo { set; get; }
    }
}
