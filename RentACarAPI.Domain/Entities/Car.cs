using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Domain.Entities
{
    public class Car : BaseEntity
    {
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        
        public long Price { get; set; }
        public Guid? BrandId { get; set; }
        public Brand Brand { get; set; }
        public Guid? ColorId { get; set; }
        public Color Color { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
