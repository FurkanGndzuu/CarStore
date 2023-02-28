using RentACarAPI.Application.Repositories.BrandRepositories;
using RentACarAPI.Domain.Entities;
using RentACarAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance.Repositories.BrandRepositories
{
    public class BrandReadRepository : ReadRepository<Brand>, IBrandReadRepository
    {
        public BrandReadRepository(RenACarDbContext _context) : base(_context)
        {
        }
    }
}
