using RentACarAPI.Application.Repositories.CategoryRepositories;
using RentACarAPI.Domain.Entities;
using RentACarAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance.Repositories.CategoryRepositories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(RenACarDbContext _context) : base(_context)
        {
        }
    }
}
