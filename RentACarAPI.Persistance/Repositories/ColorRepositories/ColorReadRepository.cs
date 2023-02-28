using RentACarAPI.Application.Repositories.ColorRepositories;
using RentACarAPI.Domain.Entities;
using RentACarAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance.Repositories.ColorRepositories
{
    public class ColorReadRepository : ReadRepository<Color> , IColorReadRepository
    {
        public ColorReadRepository(RenACarDbContext _context) : base(_context)
        {
        }
    }
}
