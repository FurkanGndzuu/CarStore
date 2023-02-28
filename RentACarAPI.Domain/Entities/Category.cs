using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
